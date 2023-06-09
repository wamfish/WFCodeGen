﻿/// <auto-generated/>
using WFLib;
using Godot;
using System;
namespace WFCodeGen;
public partial class StyleBoxSettings : Data
{
	protected override void OnBaseConstruct()
	{
		Init();
	}
	public override int FieldCount => 3;
	public StyleBoxSettings Rent()=>DataFactory<StyleBoxSettings>.Rent();
	~StyleBoxSettings() => Dispose();
	public override void Dispose()
	{
		DataFactory<StyleBoxSettings>.Return(this);
		base.Dispose();
	}
	public override bool IsRecord => false;
	public partial class DataField : DataField<StyleBoxSettings>
	{
		public DataField(int field)
		{
			Field=field;
		}
		public Godot.Color BackgroundColor => Data.BackgroundColor;
		public Godot.Color BorderColor => Data.BorderColor;
		public StyleBoxMargin.DataField Margin => Data.Margin;
		public Godot.StyleBoxFlat StyleBox => Data.StyleBox;
	}
	public override void Clear()
	{
		BackgroundColor = Godot.Colors.Black;
		BorderColor = Godot.Colors.Black;
		if (Margin == null)
		{
			Margin = new(2);
		}
		Margin.Clear();
		OnClear();
	}
	public override void Init()
	{
		BackgroundColor = Blue5;
		BorderColor = Transparent;
		if (Margin == null) 
		{
			Margin = new(2);
		}
		Margin.Init();
		OnInitialize();
	}
	public override void CopyTo(Data toData)
	{
		if (!(toData is StyleBoxSettings to)) return;
		to.Clear();
		to.BackgroundColor = BackgroundColor;
		to.BorderColor = BorderColor;
		Margin.CopyTo(to.Margin);
	}
	public override void FieldCopyTo(Data toData, int field)
	{
		if (!(toData is StyleBoxSettings to)) return;
		switch(field)
		{
			case 0:to.BackgroundColor = BackgroundColor; return;
			case 1:to.BorderColor = BorderColor; return;
			case 2:Margin.CopyTo(to.Margin); return;
		}
	}
	public override void WriteToBuf(SerializationBuffer sb, bool append=false)
	{
		if (!append) sb.Clear();
		if (BackgroundColor != Colors.Black)
		{
			sb.WriteSize(0);
			sb.Write(BackgroundColor);
		}
		if (BorderColor != Colors.Black)
		{
			sb.WriteSize(1);
			sb.Write(BorderColor);
		}
		if (!Margin.IsDefault())
		{
			sb.WriteSize(2);
			Margin.WriteToBuf(sb);
		}
		sb.WriteSize(-1);
	}
	/// <summary>
	/// ReadFromBuf loads the data from the buffer into the object. 
	/// maxField is used by Table.Filter to only load the fields that are needed.
	/// </summary>
	public override void ReadFromBuf(SerializationBuffer sb, int maxField)
	{
		Clear();
		int fieldIndex;
		fieldIndex = sb.ReadSize();
		if (fieldIndex > maxField) return; 
		if (fieldIndex == 0)
		{
			sb.Read(out BackgroundColor);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 1)
		{
			sb.Read(out BorderColor);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 2)
		{
			Margin.ReadFromBuf(sb);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		// no need to do OnLoad we are in a filter
	}
	/// <summary>
	/// ReadFromBuf loads the data from the buffer into the object. 
	/// </summary>
	public override void ReadFromBuf(SerializationBuffer sb)
	{
		Clear();
		int fieldIndex;
		fieldIndex = sb.ReadSize();
		if (fieldIndex == 0)
		{
			sb.Read(out BackgroundColor);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 1)
		{
			sb.Read(out BorderColor);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 2)
		{
			Margin.ReadFromBuf(sb);
			fieldIndex = sb.ReadSize();
		}
		OnLoad();
	}
	public override bool FieldIsDefault(int field)
	{
		switch(field)
		{
			case 0:return BackgroundColor == Colors.Black;
			case 1:return BorderColor == Colors.Black;
			case 2:return Margin.IsDefault();
		}
		return false;
	}
	public override bool FieldIsEqual(Data toFld, int field)
	{
		if (!(toFld is StyleBoxSettings to)) return false;
		switch(field)
		{
			case 0:return BackgroundColor == to.BackgroundColor;
			case 1:return BorderColor == to.BorderColor;
			case 2:return Margin.IsEqualTo(to.Margin);
		}
		return false;
	}
	public override string FieldAsString(int field)
	{
		switch(field)
		{
			case 0:return BackgroundColor.AsString();
			case 1:return BorderColor.AsString();
			case 2:return Margin.AsString();
		}
		return string.Empty;
	}
	public override void FieldFromString(string str, int field)
	{
		switch(field)
		{
			case 0:BackgroundColor = str.AsColor(); return;
			case 1:BorderColor = str.AsColor(); return;
			case 2:Margin.FromString(str); return;
		}
		return;
	}
	public override string FieldName(int field)
	{
		if (field < 0 || field >= FieldCount) return string.Empty;
		return FieldNames[field];
	}
	public override string FieldLabel(int field)
	{
		if (field < 0 || field >= FieldCount) return string.Empty;
		return FieldLabels[field];
	}
	public override void FieldLabelSet(int field, string label)
	{
		if (field < 0 || field >= FieldCount) return;
		FieldLabels[field] = label;
	}
	public override string FieldColumnLabel(int field)
	{
		if (field < 0 || field >= FieldCount) return string.Empty;
		return ColumnLabels[field];
	}
	public override void FieldColumnLabelSet(int field, string label)
	{
		if (field < 0 || field >= FieldCount) return;
		ColumnLabels[field] = label;
	}
	public override void FieldMinSet(int field, object min)
	{
		if (field < 0 || field >= FieldCount) return;
		Min[field] = min;
	}
	public override object FieldMin(int field)
	{
		if (field < 0 || field >= FieldCount) return 0;
		return Min[field];
	}
	public override void FieldMaxSet(int field, object max)
	{
		if (field < 0 || field >= FieldCount) return;
		Max[field] = max;
	}
	public override object FieldMax(int field)
	{
		if (field < 0 || field >= FieldCount) return 0;
		return Max[field];
	}
	public override int FieldIdFromName(string name)
	{
		if (FieldIdLookup.TryGetValue(name, out int id)) return id;
		return -1;
	}
	/// <summary>
	/// Writes to sb the field formated as a key.
	/// maxSize is used for strings only.
	/// </summary>
	public override void FieldAsKey(int field, SerializationBuffer sb, int maxSize)
	{
		switch(field)
		{
			case 0:sb.Write(BackgroundColor); return;
			case 1:sb.Write(BorderColor); return;
			case 2:return; // DataField as key is not supported
		}
	}
	/// <summary>
	/// Returns the field as an object.
	/// </summary>
	public override Object FieldAsObject(int field)
	{
		switch(field)
		{
			case 0:return (Object)BackgroundColor;
			case 1:return (Object)BorderColor;
			case 2:return (Object)Margin;
		}
		return null;
	}
	/// <summary>
	/// Sets the field to an object.
	/// </summary>
	public override void FieldFromObject(Object o,  int field)
	{
		switch(field)
		{
			case 0:BackgroundColor = (Color) o; return;
			case 1:BorderColor = (Color) o; return;
			case 2:Margin = (StyleBoxMargin.DataField) o; return;
		}
	}
	/// <summary>
	/// Returns the field Type.
	/// </summary>
	public override Type FieldType(int field)
	{
		switch(field)
		{
			case 0:return BackgroundColor.GetType();
			case 1:return BorderColor.GetType();
			case 2:return Margin.GetType();
		}
		return null;
	}
	public partial class Context : DataContext<StyleBoxSettings>
	{
		protected override void OnBaseConstruct()
		{
			Data = DataFactory<StyleBoxSettings>.Rent();
		}
		public static Context Rent() => (Context) DataContextFactory<StyleBoxSettings>.Rent();
		public override void Dispose()
		{
			DataContextFactory<StyleBoxSettings>.Return(this);
		}
	}
	public static class FID
	{
		public const int BackgroundColor = 0;
		public const int BorderColor = 1;
		public const int Margin = 2;
	}
	static object[] Min = { (int) 0,(int) 0,(int) 0, };
	static object[] Max = { (int) 0,(int) 0,(int) 0, };
	static string[] FieldLabels =
	{
		"Background Color",
		"Border Color",
		"Margin",
	};
	static string[] ColumnLabels =
	{
		"Background Color",
		"Border Color",
		"Margin",
	};
	static Dictionary<string, int> FieldIdLookup = new()
	{
		{ "BackgroundColor", 0 },
		{ "BorderColor", 1 },
		{ "Margin", 2 },
	};
	static string[] FieldNames =
	{
		"BackgroundColor",
		"BorderColor",
		"Margin",
	};
	static string[] TypeNames =
	{
		"Color",
		"Color",
		"DataField",
	};
	public override string[] StaticTypeNames => TypeNames;
	static List<ValidationFunc>[] ValidationFuncs = new List<ValidationFunc>[3];
	public override List<ValidationFunc>[] StaticValidationFuncs => ValidationFuncs;
	static Func<Data,string>[] HtmlHelpers = new Func<Data,string>[3];
	public override Func<Data,string>[] StaticHtmlHelpers => HtmlHelpers;
	public partial class Util : DataUtil<StyleBoxSettings>
	{
	}
}
