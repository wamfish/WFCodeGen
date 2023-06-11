﻿/// <auto-generated/>
using WFLib;
using Godot;
using System;
namespace WFCodeGen;
public partial class WindowConfigRecord : Record
{
	protected override void OnBaseConstruct()
	{
		Init();
	}
	public override int FieldCount => 7;
	public WindowConfigRecord Rent()=>RecordFactory<WindowConfigRecord>.Rent();
	public override void InitContextFactory()
	{
		Context.InitContextFactory();
	}
	~WindowConfigRecord() => Dispose();
	public override void Dispose()
	{
		RecordFactory<WindowConfigRecord>.Return(this);
		base.Dispose();
	}
	public override bool IsRecord => true;
	public override void Clear()
	{
		StatusCode = 0;
		ID = 0;
		Timestamp = DateTime.MinValue;
		EditByID = 0;
		WindowName = string.Empty;
		Position = Vector2.Zero;
		Size = Vector2.Zero;
		OnClear();
	}
	public override void Init()
	{
		StatusCode = 0;
		ID = 0;
		Timestamp = DateTime.MinValue;
		EditByID = 0;
		WindowName = string.Empty;
		Position = Vector2.Zero;
		Size = new(400, 600);
		OnInitialize();
	}
	public override void CopyTo(Data toData)
	{
		if (!(toData is WindowConfigRecord to)) return;
		to.Clear();
		to.StatusCode = StatusCode;
		to.ID = ID;
		to.Timestamp = Timestamp;
		to.EditByID = EditByID;
		to.WindowName = WindowName;
		to.Position = Position;
		to.Size = Size;
	}
	public override void FieldCopyTo(Data toData, int field)
	{
		if (!(toData is WindowConfigRecord to)) return;
		switch(field)
		{
			case 0:to.StatusCode = StatusCode; return;
			case 1:to.ID = ID; return;
			case 2:to.Timestamp = Timestamp; return;
			case 3:to.EditByID = EditByID; return;
			case 4:to.WindowName = WindowName; return;
			case 5:to.Position = Position; return;
			case 6:to.Size = Size; return;
		}
	}
	public override void WriteToBuf(SerializationBuffer sb, bool append=false)
	{
		if (!append) sb.Clear();
		sb.Write(StatusCode);
		sb.Write(ID);
		sb.Write(Timestamp);
		sb.Write(EditByID);
		if (WindowName != default)
		{
			sb.WriteSize(4);
			sb.Write(WindowName);
		}
		if (Position != default)
		{
			sb.WriteSize(5);
			sb.Write(Position);
		}
		if (Size != default)
		{
			sb.WriteSize(6);
			sb.Write(Size);
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
			sb.Read(out WindowName);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 5)
		{
			sb.Read(out Position);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 6)
		{
			sb.Read(out Size);
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
			sb.Read(out WindowName);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 5)
		{
			sb.Read(out Position);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 6)
		{
			sb.Read(out Size);
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
			case 4:return WindowName == string.Empty;
			case 5:return Position == default;
			case 6:return Size == default;
		}
		return false;
	}
	public override bool FieldIsEqual(Data toFld, int field)
	{
		if (!(toFld is WindowConfigRecord to)) return false;
		switch(field)
		{
			case 0:return StatusCode == to.StatusCode;
			case 1:return ID == to.ID;
			case 2:return Timestamp == to.Timestamp;
			case 3:return EditByID == to.EditByID;
			case 4:return WindowName == to.WindowName;
			case 5:return Position == to.Position;
			case 6:return Size == to.Size;
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
			case 4:return WindowName;
			case 5:return Position.AsString();
			case 6:return Size.AsString();
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
			case 4:WindowName = str; return;
			case 5:Position = str.AsVector2(); return;
			case 6:Size = str.AsVector2(); return;
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
			case 4:WindowName.AsKey(sb, maxSize); return;
			case 5:sb.Write(Position); return;
			case 6:sb.Write(Size); return;
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
			case 4:return (Object)WindowName;
			case 5:return (Object)Position;
			case 6:return (Object)Size;
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
			case 4:WindowName = (string) o; return;
			case 5:Position = (Vector2) o; return;
			case 6:Size = (Vector2) o; return;
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
			case 4:return WindowName.GetType();
			case 5:return Position.GetType();
			case 6:return Size.GetType();
		}
		return null;
	}
	public partial class Context : RecordContext<WindowConfigRecord>
	{
		protected override void OnBaseConstruct()
		{
			table = TableFactory<Table,WindowConfigRecord>.Rent();
		}
		internal static void InitContextFactory() => RecordContextFactory<WindowConfigRecord>.SetCreateMethod(()=>new Context(),_setEditById);
		static Context()
		{
			InitContextFactory();
		}
		public static Context Rent(int EditByID=-2) => (Context) RecordContextFactory<WindowConfigRecord>.Rent(EditByID);
		public override Table Table => (Table) table;
		public override void Dispose()
		{
			RecordContextFactory<WindowConfigRecord>.Return(this);
		}
		public Status ReadByWindowNameKey(WindowConfigRecord data)
		{
			return Table.WindowNameKey.Read(data,EditByID);
		}
	}
	public static class FID
	{
		public const int StatusCode = 0;
		public const int ID = 1;
		public const int Timestamp = 2;
		public const int EditByID = 3;
		public const int WindowName = 4;
		public const int Position = 5;
		public const int Size = 6;
	}
	static object[] Min = { (byte) 0,(int) -2147483648,(long) 0,(int) -2147483648,(int) 0,(float) -16777217,(float) -16777217, };
	static object[] Max = { (byte) 255,(int) 2147483647,(long) 3155378975999999999,(int) 2147483647,(int) 0,(float) 16777217,(float) 16777217, };
	static string[] FieldLabels =
	{
		"Status Code",
		"ID",
		"Timestamp",
		"Edit By ID",
		"Window Name",
		"Position",
		"Size",
	};
	static string[] ColumnLabels =
	{
		"Status Code",
		"ID",
		"Timestamp",
		"Edit By ID",
		"Window Name",
		"Position",
		"Size",
	};
	static Dictionary<string, int> FieldIdLookup = new()
	{
		{ "StatusCode", 0 },
		{ "ID", 1 },
		{ "Timestamp", 2 },
		{ "EditByID", 3 },
		{ "WindowName", 4 },
		{ "Position", 5 },
		{ "Size", 6 },
	};
	static string[] FieldNames =
	{
		"StatusCode",
		"ID",
		"Timestamp",
		"EditByID",
		"WindowName",
		"Position",
		"Size",
	};
	static string[] TypeNames =
	{
		"byte",
		"int",
		"DateTime",
		"int",
		"string",
		"Vector2",
		"Vector2",
	};
	public override string[] StaticTypeNames => TypeNames;
	static List<ValidationFunc>[] ValidationFuncs = new List<ValidationFunc>[7];
	public override List<ValidationFunc>[] StaticValidationFuncs => ValidationFuncs;
	static Func<Data,string>[] HtmlHelpers = new Func<Data,string>[7];
	public override Func<Data,string>[] StaticHtmlHelpers => HtmlHelpers;
	public partial class Util : RecordUtil<WindowConfigRecord>
	{
		public static Status ReadByWindowNameKey(WindowConfigRecord data,int EditByID=-2)
		{
			var context = (Context) RentContext(EditByID);
			var status = context.ReadByWindowNameKey(data);
			return status;
		}
	}
	public partial class Table : Table<WindowConfigRecord>
	{
		public readonly Key WindowNameKey;
		public Table()
		{
			WindowNameKey = new Key(this,FID.WindowName);
		}
	}
}
