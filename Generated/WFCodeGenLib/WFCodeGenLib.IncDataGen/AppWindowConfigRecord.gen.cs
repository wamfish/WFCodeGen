﻿/// <auto-generated/>
using WFLib;
using Godot;
using System;
namespace WFCodeGen;
public partial class AppWindowConfigRecord : Record
{
	protected override void OnBaseConstruct()
	{
		Init();
	}
	public override int FieldCount => 8;
	public AppWindowConfigRecord Rent()=>RecordFactory<AppWindowConfigRecord>.Rent();
	public override void InitContextFactory()
	{
		Context.InitContextFactory();
	}
	~AppWindowConfigRecord() => Dispose();
	public override void Dispose()
	{
		RecordFactory<AppWindowConfigRecord>.Return(this);
		base.Dispose();
	}
	public override bool IsRecord => true;
	public override void Clear()
	{
		StatusCode = 0;
		ID = 0;
		Timestamp = DateTime.MinValue;
		EditByID = 0;
		LastScreenIndex = 0;
		LastWindowMode = 0;
		LastWindowSize = Vector2I.Zero;
		LastWindowPos = Vector2I.Zero;
		OnClear();
	}
	public override void Init()
	{
		StatusCode = 0;
		ID = 0;
		Timestamp = DateTime.MinValue;
		EditByID = 0;
		LastScreenIndex = 0;
		LastWindowMode = (int)DisplayServer.WindowMode.Windowed;
		LastWindowSize = new(400, 600);
		LastWindowPos = new(0, 0);
		OnInitialize();
	}
	public override void CopyTo(Data toData)
	{
		if (!(toData is AppWindowConfigRecord to)) return;
		to.Clear();
		to.StatusCode = StatusCode;
		to.ID = ID;
		to.Timestamp = Timestamp;
		to.EditByID = EditByID;
		to.LastScreenIndex = LastScreenIndex;
		to.LastWindowMode = LastWindowMode;
		to.LastWindowSize = LastWindowSize;
		to.LastWindowPos = LastWindowPos;
	}
	public override void FieldCopyTo(Data toData, int field)
	{
		if (!(toData is AppWindowConfigRecord to)) return;
		switch(field)
		{
			case 0:to.StatusCode = StatusCode; return;
			case 1:to.ID = ID; return;
			case 2:to.Timestamp = Timestamp; return;
			case 3:to.EditByID = EditByID; return;
			case 4:to.LastScreenIndex = LastScreenIndex; return;
			case 5:to.LastWindowMode = LastWindowMode; return;
			case 6:to.LastWindowSize = LastWindowSize; return;
			case 7:to.LastWindowPos = LastWindowPos; return;
		}
	}
	public override void WriteToBuf(SerializationBuffer sb, bool append=false)
	{
		if (!append) sb.Clear();
		sb.Write(StatusCode);
		sb.Write(ID);
		sb.Write(Timestamp);
		sb.Write(EditByID);
		if (LastScreenIndex != default)
		{
			sb.WriteSize(4);
			sb.Write(LastScreenIndex);
		}
		if (LastWindowMode != default)
		{
			sb.WriteSize(5);
			sb.Write(LastWindowMode);
		}
		if (LastWindowSize != default)
		{
			sb.WriteSize(6);
			sb.Write(LastWindowSize);
		}
		if (LastWindowPos != default)
		{
			sb.WriteSize(7);
			sb.Write(LastWindowPos);
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
		StatusCode = sb.ReadByte();
		ID = sb.ReadInt();
		if (maxField < 2) return; // no need to do OnLoad we are in a filter
		Timestamp = sb.ReadDateTime();
		if (maxField < 3) return; // no need to do OnLoad we are in a filter
		EditByID = sb.ReadInt();
		fieldIndex = sb.ReadSize();
		if (fieldIndex > maxField) return; 
		if (fieldIndex == 4)
		{
			sb.Read(out LastScreenIndex);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 5)
		{
			sb.Read(out LastWindowMode);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 6)
		{
			sb.Read(out LastWindowSize);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 7)
		{
			sb.Read(out LastWindowPos);
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
		StatusCode = sb.ReadByte();
		ID = sb.ReadInt();
		Timestamp = sb.ReadDateTime();
		EditByID = sb.ReadInt();
		fieldIndex = sb.ReadSize();
		if (fieldIndex == 4)
		{
			sb.Read(out LastScreenIndex);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 5)
		{
			sb.Read(out LastWindowMode);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 6)
		{
			sb.Read(out LastWindowSize);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 7)
		{
			sb.Read(out LastWindowPos);
			fieldIndex = sb.ReadSize();
		}
		OnLoad();
	}
	public override bool FieldIsDefault(int field)
	{
		switch(field)
		{
			case 0:return StatusCode == default;
			case 1:return ID == default;
			case 2:return Timestamp == default;
			case 3:return EditByID == default;
			case 4:return LastScreenIndex == default;
			case 5:return LastWindowMode == default;
			case 6:return LastWindowSize == default;
			case 7:return LastWindowPos == default;
		}
		return false;
	}
	public override bool FieldIsEqual(Data toFld, int field)
	{
		if (!(toFld is AppWindowConfigRecord to)) return false;
		switch(field)
		{
			case 0:return StatusCode == to.StatusCode;
			case 1:return ID == to.ID;
			case 2:return Timestamp == to.Timestamp;
			case 3:return EditByID == to.EditByID;
			case 4:return LastScreenIndex == to.LastScreenIndex;
			case 5:return LastWindowMode == to.LastWindowMode;
			case 6:return LastWindowSize == to.LastWindowSize;
			case 7:return LastWindowPos == to.LastWindowPos;
		}
		return false;
	}
	public override string FieldAsString(int field)
	{
		switch(field)
		{
			case 0:return StatusCode.AsString();
			case 1:return ID.AsString();
			case 2:return Timestamp.AsString();
			case 3:return EditByID.AsString();
			case 4:return LastScreenIndex.AsString();
			case 5:return LastWindowMode.AsString();
			case 6:return LastWindowSize.AsString();
			case 7:return LastWindowPos.AsString();
		}
		return string.Empty;
	}
	public override void FieldFromString(string str, int field)
	{
		switch(field)
		{
			case 0:StatusCode = str.AsByte(); return;
			case 1:ID = str.AsInt(); return;
			case 2:Timestamp = str.AsDateTime(); return;
			case 3:EditByID = str.AsInt(); return;
			case 4:LastScreenIndex = str.AsInt(); return;
			case 5:LastWindowMode = str.AsInt(); return;
			case 6:LastWindowSize = str.AsVector2I(); return;
			case 7:LastWindowPos = str.AsVector2I(); return;
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
			case 0:sb.Write(StatusCode); return;
			case 1:sb.Write(ID); return;
			case 2:sb.Write(Timestamp); return;
			case 3:sb.Write(EditByID); return;
			case 4:sb.Write(LastScreenIndex); return;
			case 5:sb.Write(LastWindowMode); return;
			case 6:sb.Write(LastWindowSize); return;
			case 7:sb.Write(LastWindowPos); return;
		}
	}
	/// <summary>
	/// Returns the field as an object.
	/// </summary>
	public override Object FieldAsObject(int field)
	{
		switch(field)
		{
			case 0:return (Object)StatusCode;
			case 1:return (Object)ID;
			case 2:return (Object)Timestamp;
			case 3:return (Object)EditByID;
			case 4:return (Object)LastScreenIndex;
			case 5:return (Object)LastWindowMode;
			case 6:return (Object)LastWindowSize;
			case 7:return (Object)LastWindowPos;
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
			case 0:StatusCode = (byte) o; return;
			case 1:ID = (int) o; return;
			case 2:Timestamp = (DateTime) o; return;
			case 3:EditByID = (int) o; return;
			case 4:LastScreenIndex = (int) o; return;
			case 5:LastWindowMode = (int) o; return;
			case 6:LastWindowSize = (Vector2I) o; return;
			case 7:LastWindowPos = (Vector2I) o; return;
		}
	}
	/// <summary>
	/// Returns the field Type.
	/// </summary>
	public override Type FieldType(int field)
	{
		switch(field)
		{
			case 0:return StatusCode.GetType();
			case 1:return ID.GetType();
			case 2:return Timestamp.GetType();
			case 3:return EditByID.GetType();
			case 4:return LastScreenIndex.GetType();
			case 5:return LastWindowMode.GetType();
			case 6:return LastWindowSize.GetType();
			case 7:return LastWindowPos.GetType();
		}
		return null;
	}
	public partial class Context : RecordContext<AppWindowConfigRecord>
	{
		protected override void OnBaseConstruct()
		{
			table = TableFactory<Table,AppWindowConfigRecord>.Rent();
		}
		internal static void InitContextFactory() => RecordContextFactory<AppWindowConfigRecord>.SetCreateMethod(()=>new Context(),_setEditById);
		static Context()
		{
			InitContextFactory();
		}
		public static Context Rent(int EditByID=-2) => (Context) RecordContextFactory<AppWindowConfigRecord>.Rent(EditByID);
		public override Table Table => (Table) table;
		public override void Dispose()
		{
			RecordContextFactory<AppWindowConfigRecord>.Return(this);
		}
	}
	public static class FID
	{
		public const int StatusCode = 0;
		public const int ID = 1;
		public const int Timestamp = 2;
		public const int EditByID = 3;
		public const int LastScreenIndex = 4;
		public const int LastWindowMode = 5;
		public const int LastWindowSize = 6;
		public const int LastWindowPos = 7;
	}
	static object[] Min = { (byte) 0,(int) -2147483648,(long) 0,(int) -2147483648,(int) -2147483648,(int) -2147483648,(int) -2147483648,(int) -2147483648, };
	static object[] Max = { (byte) 255,(int) 2147483647,(long) 3155378975999999999,(int) 2147483647,(int) 2147483647,(int) 2147483647,(int) 2147483647,(int) 2147483647, };
	static string[] FieldLabels =
	{
		"Status Code",
		"ID",
		"Timestamp",
		"Edit By ID",
		"Last Screen Index",
		"Last Window Mode",
		"Last Window Size",
		"Last Window Pos",
	};
	static string[] ColumnLabels =
	{
		"Status Code",
		"ID",
		"Timestamp",
		"Edit By ID",
		"Last Screen Index",
		"Last Window Mode",
		"Last Window Size",
		"Last Window Pos",
	};
	static Dictionary<string, int> FieldIdLookup = new()
	{
		{ "StatusCode", 0 },
		{ "ID", 1 },
		{ "Timestamp", 2 },
		{ "EditByID", 3 },
		{ "LastScreenIndex", 4 },
		{ "LastWindowMode", 5 },
		{ "LastWindowSize", 6 },
		{ "LastWindowPos", 7 },
	};
	static string[] FieldNames =
	{
		"StatusCode",
		"ID",
		"Timestamp",
		"EditByID",
		"LastScreenIndex",
		"LastWindowMode",
		"LastWindowSize",
		"LastWindowPos",
	};
	static string[] TypeNames =
	{
		"byte",
		"int",
		"DateTime",
		"int",
		"int",
		"int",
		"Vector2I",
		"Vector2I",
	};
	public override string[] StaticTypeNames => TypeNames;
	static List<ValidationFunc>[] ValidationFuncs = new List<ValidationFunc>[8];
	public override List<ValidationFunc>[] StaticValidationFuncs => ValidationFuncs;
	static Func<Data,string>[] HtmlHelpers = new Func<Data,string>[8];
	public override Func<Data,string>[] StaticHtmlHelpers => HtmlHelpers;
	public partial class Util : RecordUtil<AppWindowConfigRecord>
	{
	}
	public partial class Table : Table<AppWindowConfigRecord>
	{
	}
}
