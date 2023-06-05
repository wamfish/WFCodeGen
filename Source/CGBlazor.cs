using Microsoft.CodeAnalysis;

namespace WFCodeGen;
public class CGBlazor : ICodeGenerator
{
    CodeWriter cw = null;
    bool IsRecord = false;
    string ClassName = "";
    string Namespace = "WFBlazorLib";
    Data Data;
    
    public SourceFile Run(Data data, string nameSpace)
    {
        if (Namespace != nameSpace && nameSpace != "WFLib")  return null; 
        var outputMain = Path.Combine(Config.MainDir, Namespace);
        if (!Directory.Exists(outputMain))
        {
            Log($"Skip CGBlazor! {outputMain} not found");
            return null;
        }
        Data = data;
        IsRecord = data is Record;
        ClassName = data.ClassName();
        cw = new CodeWriter();
        cw.line = "using WFLib;";
        cw.line = "namespace WFBlazorLib;";
        GenEdit();
        GenExt();
        var outputdir = Path.Combine(outputMain, "Generated");
        var fileName = Path.Combine(outputdir, ClassName + "EditCtx.gen.cs");
        var sf = new SourceFile(fileName,cw.ToString(), Namespace);
        sf.AddGeneratedFile(fileName, cw.ToString(), null, null);
        return sf;
    }
    private void  GenExt()
    {
        if (IsRecord) 
        { 
            cw.line = $"public static class {ClassName}EditCtxExt";
            cw.line = "{";
            cw.line = $"public static {ClassName}.Context RecCtx(this {ClassName}EditCtx editCtx)";
            cw.line = "{";
            cw.line = $"return ({ClassName}.Context)editCtx.DataProvider.Ctx;";
            cw.line = "}";
            cw.line = "}";
        }
}
    private void GenEdit()
    {
        if (IsRecord)
        {
            cw.line = $"public class {ClassName}EditCtx : EditRecordContextBase<{ClassName}>, IDisposable";
        }
        else
        {
            cw.line = $"public class {ClassName}EditCtx : EditDataContextBase<{ClassName}>, IDisposable";
        }

        cw.line = "{";

        for (int i = 0; i < Data.FieldCount; i++)
        {
            var fieldName = Data.FieldName(i);
            cw.line = $"public FieldEditCtx<{ClassName}> {fieldName} {{ get; private set; }}";
        }

        cw.line = $"private DataEditSettings<{ClassName}> _DataDef = null;";
        cw.line = $"public override DataEditSettings<{ClassName}> DataDef => _DataDef;";

        cw.line = $"private {ClassName} _OrigData = null;";
        cw.line = $"public override {ClassName} OrigData => _OrigData;";
        cw.line = $"private {ClassName} _Data = null;";
        cw.line = $"public override {ClassName} Data => _Data;";

        if (IsRecord)
        {
            cw.line = $"private RecordProvider<{ClassName}> _DataProvider;";
            cw.line = $"public override RecordProvider<{ClassName}> DataProvider => _DataProvider;";
        }
        else
        {
            cw.line = $"public DataProvider<{ClassName}> _DataProvider;";
            cw.line = $"public override DataProvider<{ClassName}> DataProvider => _DataProvider;";
        }

        GenRent();
        GenPool();
        GenDispose();
        cw.line = "}";

    }
    private void GenPool()
    {
        cw.line = $"private {ClassName}EditCtx() {{ }}";
        cw.line = $"private static {ClassName}EditCtx Create()";
        cw.line = "{";
        cw.line = $"return new {ClassName}EditCtx();";
        cw.line = "}";
        cw.line = $"private static Pool<{ClassName}EditCtx> pool = new(Create);";
        cw.line = $"public static string PoolStats => pool.Stats;";
        cw.line = $"public static void PoolClear() => pool.Clear();";
        cw.line = $"~{ClassName}EditCtx()";
        cw.line = "{";
        cw.line = $"Dispose();";
        cw.line = "}";
    }
    private void GenDispose()
    {
        cw.line = $"public void Dispose()";
        cw.line = "{";
        for (int i = 0; i < Data.FieldCount; i++)
        {
            var fieldName = Data.FieldName(i);
            cw.line = $"{fieldName} = null;";
        }
        //cw.line = $"OnDispose();";
        cw.line = $"_DataProvider.Dispose();";
        cw.line = $"_DataProvider = null;";
        cw.line = $"_DataDef.Dispose();";
        cw.line = $"_DataDef = null;";
        cw.line = $"_OrigData.Dispose();";
        cw.line = $"_OrigData = null;";
        cw.line = $"_Data.Dispose();";
        cw.line = $"_Data = null;";
        cw.line = $"pool.Return(this);";
        cw.line = "}";
    }
    private void GenRent()
    {
        cw.line = $"public static {ClassName}EditCtx Rent(WFAppState appState)";
        cw.line = "{";
        cw.line = $"var ctx = pool.Rent();";
        if (IsRecord)
        {
            cw.line = $"ctx._DataProvider = RecordProvider<{ClassName}>.Rent(appState.UserState.User);";
        }
        else
        {
            cw.line = $"ctx._DataProvider = DataProvider<{ClassName}>.Rent();";
        }
        cw.line = $"ctx._DataDef = DataEditSettings<{ClassName}>.Rent();";
        cw.line = $"ctx._OrigData = DataFactory<{ClassName}>.Rent();";
        cw.line = $"ctx._Data = DataFactory<{ClassName}>.Rent();";
        for (int i = 0; i < Data.FieldCount; i++)
        {
            var fieldName = Data.FieldName(i);
            cw.line = $"ctx.{fieldName} = FieldEditCtx<{ClassName}>.Rent({ClassName}.FID.{fieldName});";
            cw.line = $"ctx.DataDef.Add(ctx.{fieldName});";
        }
        cw.line = "ctx.OnInit(appState);";
        cw.line = "return ctx;";
        cw.line = "}";
    }
}
