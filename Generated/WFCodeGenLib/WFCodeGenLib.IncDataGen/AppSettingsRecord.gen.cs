﻿/// <auto-generated/>
using WFLib;
using Godot;
using System;
namespace WFCodeGen;
public partial class AppSettingsRecord : Record
{
	protected override void OnBaseConstruct()
	{
		Init();
	}
	public override int FieldCount => 11;
	public AppSettingsRecord Rent()=>RecordFactory<AppSettingsRecord>.Rent();
	public override void InitContextFactory()
	{
		Context.InitContextFactory();
	}
	~AppSettingsRecord() => Dispose();
	public override void Dispose()
	{
		RecordFactory<AppSettingsRecord>.Return(this);
		base.Dispose();
	}
	public override bool IsRecord => true;
	public override void Clear()
	{
		StatusCode = 0;
		ID = 0;
		Timestamp = DateTime.MinValue;
		EditByID = 0;
		MasterVolume = 0;
		MusicVolume = 0;
		SFXVolume = 0;
		UIVolume = 0;
		ShowFPS = false;
		ShowMPH = false;
		ShowToolbar = false;
		OnClear();
	}
	public override void Init()
	{
		StatusCode = 0;
		ID = 0;
		Timestamp = DateTime.MinValue;
		EditByID = 0;
		MasterVolume = 1f;
		MusicVolume = 1f;
		SFXVolume = 1f;
		UIVolume = 1f;
		ShowFPS = true;
		ShowMPH = true;
		ShowToolbar = true;
		OnInitialize();
	}
	public override void CopyTo(Data toData)
	{
		if (!(toData is AppSettingsRecord to)) return;
		to.Clear();
		to.StatusCode = StatusCode;
		to.ID = ID;
		to.Timestamp = Timestamp;
		to.EditByID = EditByID;
		to.MasterVolume = MasterVolume;
		to.MusicVolume = MusicVolume;
		to.SFXVolume = SFXVolume;
		to.UIVolume = UIVolume;
		to.ShowFPS = ShowFPS;
		to.ShowMPH = ShowMPH;
		to.ShowToolbar = ShowToolbar;
	}
	public override void FieldCopyTo(Data toData, int field)
	{
		if (!(toData is AppSettingsRecord to)) return;
		switch(field)
		{
			case 0:to.StatusCode = StatusCode; return;
			case 1:to.ID = ID; return;
			case 2:to.Timestamp = Timestamp; return;
			case 3:to.EditByID = EditByID; return;
			case 4:to.MasterVolume = MasterVolume; return;
			case 5:to.MusicVolume = MusicVolume; return;
			case 6:to.SFXVolume = SFXVolume; return;
			case 7:to.UIVolume = UIVolume; return;
			case 8:to.ShowFPS = ShowFPS; return;
			case 9:to.ShowMPH = ShowMPH; return;
			case 10:to.ShowToolbar = ShowToolbar; return;
		}
	}
	public override void WriteToBuf(SerializationBuffer sb, bool append=false)
	{
		if (!append) sb.Clear();
		sb.Write(StatusCode);
		sb.Write(ID);
		sb.Write(Timestamp);
		sb.Write(EditByID);
		if (MasterVolume != default)
		{
			sb.WriteSize(4);
			sb.Write(MasterVolume);
		}
		if (MusicVolume != default)
		{
			sb.WriteSize(5);
			sb.Write(MusicVolume);
		}
		if (SFXVolume != default)
		{
			sb.WriteSize(6);
			sb.Write(SFXVolume);
		}
		if (UIVolume != default)
		{
			sb.WriteSize(7);
			sb.Write(UIVolume);
		}
		if (ShowFPS != default)
		{
			sb.WriteSize(8);
			sb.Write(ShowFPS);
		}
		if (ShowMPH != default)
		{
			sb.WriteSize(9);
			sb.Write(ShowMPH);
		}
		if (ShowToolbar != default)
		{
			sb.WriteSize(10);
			sb.Write(ShowToolbar);
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
			sb.Read(out MasterVolume);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 5)
		{
			sb.Read(out MusicVolume);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 6)
		{
			sb.Read(out SFXVolume);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 7)
		{
			sb.Read(out UIVolume);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 8)
		{
			sb.Read(out ShowFPS);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 9)
		{
			sb.Read(out ShowMPH);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 10)
		{
			sb.Read(out ShowToolbar);
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
			sb.Read(out MasterVolume);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 5)
		{
			sb.Read(out MusicVolume);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 6)
		{
			sb.Read(out SFXVolume);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 7)
		{
			sb.Read(out UIVolume);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 8)
		{
			sb.Read(out ShowFPS);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 9)
		{
			sb.Read(out ShowMPH);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 10)
		{
			sb.Read(out ShowToolbar);
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
			case 4:return MasterVolume == default;
			case 5:return MusicVolume == default;
			case 6:return SFXVolume == default;
			case 7:return UIVolume == default;
			case 8:return ShowFPS == default;
			case 9:return ShowMPH == default;
			case 10:return ShowToolbar == default;
		}
		return false;
	}
	public override bool FieldIsEqual(Data toFld, int field)
	{
		if (!(toFld is AppSettingsRecord to)) return false;
		switch(field)
		{
			case 0:return StatusCode == to.StatusCode;
			case 1:return ID == to.ID;
			case 2:return Timestamp == to.Timestamp;
			case 3:return EditByID == to.EditByID;
			case 4:return MasterVolume == to.MasterVolume;
			case 5:return MusicVolume == to.MusicVolume;
			case 6:return SFXVolume == to.SFXVolume;
			case 7:return UIVolume == to.UIVolume;
			case 8:return ShowFPS == to.ShowFPS;
			case 9:return ShowMPH == to.ShowMPH;
			case 10:return ShowToolbar == to.ShowToolbar;
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
			case 4:return MasterVolume.AsString();
			case 5:return MusicVolume.AsString();
			case 6:return SFXVolume.AsString();
			case 7:return UIVolume.AsString();
			case 8:return ShowFPS.AsString();
			case 9:return ShowMPH.AsString();
			case 10:return ShowToolbar.AsString();
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
			case 4:MasterVolume = str.AsFloat(); return;
			case 5:MusicVolume = str.AsFloat(); return;
			case 6:SFXVolume = str.AsFloat(); return;
			case 7:UIVolume = str.AsFloat(); return;
			case 8:ShowFPS = str.AsBool(); return;
			case 9:ShowMPH = str.AsBool(); return;
			case 10:ShowToolbar = str.AsBool(); return;
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
			case 4:sb.Write(MasterVolume); return;
			case 5:sb.Write(MusicVolume); return;
			case 6:sb.Write(SFXVolume); return;
			case 7:sb.Write(UIVolume); return;
			case 8:sb.Write(ShowFPS); return;
			case 9:sb.Write(ShowMPH); return;
			case 10:sb.Write(ShowToolbar); return;
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
			case 4:return (Object)MasterVolume;
			case 5:return (Object)MusicVolume;
			case 6:return (Object)SFXVolume;
			case 7:return (Object)UIVolume;
			case 8:return (Object)ShowFPS;
			case 9:return (Object)ShowMPH;
			case 10:return (Object)ShowToolbar;
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
			case 4:MasterVolume = (float) o; return;
			case 5:MusicVolume = (float) o; return;
			case 6:SFXVolume = (float) o; return;
			case 7:UIVolume = (float) o; return;
			case 8:ShowFPS = (bool) o; return;
			case 9:ShowMPH = (bool) o; return;
			case 10:ShowToolbar = (bool) o; return;
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
			case 4:return MasterVolume.GetType();
			case 5:return MusicVolume.GetType();
			case 6:return SFXVolume.GetType();
			case 7:return UIVolume.GetType();
			case 8:return ShowFPS.GetType();
			case 9:return ShowMPH.GetType();
			case 10:return ShowToolbar.GetType();
		}
		return null;
	}
	public partial class Context : RecordContext<AppSettingsRecord>
	{
		protected override void OnBaseConstruct()
		{
			table = TableFactory<Table,AppSettingsRecord>.Rent();
		}
		internal static void InitContextFactory() => RecordContextFactory<AppSettingsRecord>.SetCreateMethod(()=>new Context(),_setEditById);
		static Context()
		{
			InitContextFactory();
		}
		public static Context Rent(int EditByID=-2) => (Context) RecordContextFactory<AppSettingsRecord>.Rent(EditByID);
		public override Table Table => (Table) table;
		public override void Dispose()
		{
			RecordContextFactory<AppSettingsRecord>.Return(this);
		}
	}
	public static class FID
	{
		public const int StatusCode = 0;
		public const int ID = 1;
		public const int Timestamp = 2;
		public const int EditByID = 3;
		public const int MasterVolume = 4;
		public const int MusicVolume = 5;
		public const int SFXVolume = 6;
		public const int UIVolume = 7;
		public const int ShowFPS = 8;
		public const int ShowMPH = 9;
		public const int ShowToolbar = 10;
	}
	static object[] Min = { (byte) 0,(int) -2147483648,(long) 0,(int) -2147483648,(float) -16777217,(float) -16777217,(float) -16777217,(float) -16777217,(int) 0,(int) 0,(int) 0, };
	static object[] Max = { (byte) 255,(int) 2147483647,(long) 3155378975999999999,(int) 2147483647,(float) 16777217,(float) 16777217,(float) 16777217,(float) 16777217,(int) 0,(int) 0,(int) 0, };
	static string[] FieldLabels =
	{
		"Status Code",
		"ID",
		"Timestamp",
		"Edit By ID",
		"Master Volume",
		"Music Volume",
		"SFX Volume",
		"UI Volume",
		"Show FPS",
		"Show MPH",
		"Show Toolbar",
	};
	static string[] ColumnLabels =
	{
		"Status Code",
		"ID",
		"Timestamp",
		"Edit By ID",
		"Master Volume",
		"Music Volume",
		"SFX Volume",
		"UI Volume",
		"Show FPS",
		"Show MPH",
		"Show Toolbar",
	};
	static Dictionary<string, int> FieldIdLookup = new()
	{
		{ "StatusCode", 0 },
		{ "ID", 1 },
		{ "Timestamp", 2 },
		{ "EditByID", 3 },
		{ "MasterVolume", 4 },
		{ "MusicVolume", 5 },
		{ "SFXVolume", 6 },
		{ "UIVolume", 7 },
		{ "ShowFPS", 8 },
		{ "ShowMPH", 9 },
		{ "ShowToolbar", 10 },
	};
	static string[] FieldNames =
	{
		"StatusCode",
		"ID",
		"Timestamp",
		"EditByID",
		"MasterVolume",
		"MusicVolume",
		"SFXVolume",
		"UIVolume",
		"ShowFPS",
		"ShowMPH",
		"ShowToolbar",
	};
	static string[] TypeNames =
	{
		"byte",
		"int",
		"DateTime",
		"int",
		"float",
		"float",
		"float",
		"float",
		"bool",
		"bool",
		"bool",
	};
	public override string[] StaticTypeNames => TypeNames;
	static List<ValidationFunc>[] ValidationFuncs = new List<ValidationFunc>[11];
	public override List<ValidationFunc>[] StaticValidationFuncs => ValidationFuncs;
	static Func<Data,string>[] HtmlHelpers = new Func<Data,string>[11];
	public override Func<Data,string>[] StaticHtmlHelpers => HtmlHelpers;
	public partial class Util : RecordUtil<AppSettingsRecord>
	{
	}
	public partial class Table : Table<AppSettingsRecord>
	{
	}
}
