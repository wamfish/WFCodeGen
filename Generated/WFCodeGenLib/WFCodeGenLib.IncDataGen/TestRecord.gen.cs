﻿/// <auto-generated/>
using WFLib;
using Godot;
using System;
namespace WFCodeGen;
public partial class TestRecord : Record
{
	protected override void OnBaseConstruct()
	{
		Init();
	}
	public override int FieldCount => 25;
	public TestRecord Rent()=>RecordFactory<TestRecord>.Rent();
	public override void InitContextFactory()
	{
		Context.InitContextFactory();
	}
	~TestRecord() => Dispose();
	public override void Dispose()
	{
		RecordFactory<TestRecord>.Return(this);
		base.Dispose();
	}
	public override bool IsRecord => true;
	public override void Clear()
	{
		StatusCode = 0;
		ID = 0;
		Timestamp = DateTime.MinValue;
		EditByID = 0;
		StringFld = string.Empty;
		IntFld = 0;
		UIntFld = 0;
		ColorFld = Godot.Colors.Black;
		DateTimeFld = DateTime.MinValue;
		if (DataFld == null)
		{
			DataFld = new(9);
		}
		DataFld.Clear();
		ByteFld = 0;
		BoolFld = false;
		ShortFld = 0;
		UShortFld = 0;
		LongFld = 0;
		ULongFld = 0;
		FloatFld = 0;
		DoubleFld = 0;
		DecimalFld = 0;
		Vector2Fld = Vector2.Zero;
		Vector3Fld = Vector3.Zero;
		QuaternionFld = Quaternion.Identity;
		Vector2IFld = Vector2I.Zero;
		Vector3IFld = Vector3I.Zero;
		Vector4IFld = Vector4I.Zero;
		OnClear();
	}
	public override void Init()
	{
		StatusCode = 0;
		ID = 0;
		Timestamp = DateTime.MinValue;
		EditByID = 0;
		StringFld = string.Empty;
		IntFld = 0;
		UIntFld = 0;
		ColorFld = Godot.Colors.Black;
		DateTimeFld = DateTime.MinValue;
		if (DataFld == null) 
		{
			DataFld = new(9);
		}
		DataFld.Init();
		ByteFld = 0;
		BoolFld = false;
		ShortFld = 0;
		UShortFld = 0;
		LongFld = 0;
		ULongFld = 0;
		FloatFld = 0;
		DoubleFld = 0;
		DecimalFld = 0;
		Vector2Fld = Vector2.Zero;
		Vector3Fld = Vector3.Zero;
		QuaternionFld = Quaternion.Identity;
		Vector2IFld = Vector2I.Zero;
		Vector3IFld = Vector3I.Zero;
		Vector4IFld = Vector4I.Zero;
		OnInitialize();
	}
	public override void CopyTo(Data toData)
	{
		if (!(toData is TestRecord to)) return;
		to.Clear();
		to.StatusCode = StatusCode;
		to.ID = ID;
		to.Timestamp = Timestamp;
		to.EditByID = EditByID;
		to.StringFld = StringFld;
		to.IntFld = IntFld;
		to.UIntFld = UIntFld;
		to.ColorFld = ColorFld;
		to.DateTimeFld = DateTimeFld;
		DataFld.CopyTo(to.DataFld);
		to.ByteFld = ByteFld;
		to.BoolFld = BoolFld;
		to.ShortFld = ShortFld;
		to.UShortFld = UShortFld;
		to.LongFld = LongFld;
		to.ULongFld = ULongFld;
		to.FloatFld = FloatFld;
		to.DoubleFld = DoubleFld;
		to.DecimalFld = DecimalFld;
		to.Vector2Fld = Vector2Fld;
		to.Vector3Fld = Vector3Fld;
		to.QuaternionFld = QuaternionFld;
		to.Vector2IFld = Vector2IFld;
		to.Vector3IFld = Vector3IFld;
		to.Vector4IFld = Vector4IFld;
	}
	public override void FieldCopyTo(Data toData, int field)
	{
		if (!(toData is TestRecord to)) return;
		switch(field)
		{
			case 0:to.StatusCode = StatusCode; return;
			case 1:to.ID = ID; return;
			case 2:to.Timestamp = Timestamp; return;
			case 3:to.EditByID = EditByID; return;
			case 4:to.StringFld = StringFld; return;
			case 5:to.IntFld = IntFld; return;
			case 6:to.UIntFld = UIntFld; return;
			case 7:to.ColorFld = ColorFld; return;
			case 8:to.DateTimeFld = DateTimeFld; return;
			case 9:DataFld.CopyTo(to.DataFld); return;
			case 10:to.ByteFld = ByteFld; return;
			case 11:to.BoolFld = BoolFld; return;
			case 12:to.ShortFld = ShortFld; return;
			case 13:to.UShortFld = UShortFld; return;
			case 14:to.LongFld = LongFld; return;
			case 15:to.ULongFld = ULongFld; return;
			case 16:to.FloatFld = FloatFld; return;
			case 17:to.DoubleFld = DoubleFld; return;
			case 18:to.DecimalFld = DecimalFld; return;
			case 19:to.Vector2Fld = Vector2Fld; return;
			case 20:to.Vector3Fld = Vector3Fld; return;
			case 21:to.QuaternionFld = QuaternionFld; return;
			case 22:to.Vector2IFld = Vector2IFld; return;
			case 23:to.Vector3IFld = Vector3IFld; return;
			case 24:to.Vector4IFld = Vector4IFld; return;
		}
	}
	public override void WriteToBuf(SerializationBuffer sb, bool append=false)
	{
		if (!append) sb.Clear();
		sb.Write(StatusCode);
		sb.Write(ID);
		sb.Write(Timestamp);
		sb.Write(EditByID);
		if (StringFld != default)
		{
			sb.WriteSize(4);
			sb.Write(StringFld);
		}
		if (IntFld != default)
		{
			sb.WriteSize(5);
			sb.Write(IntFld);
		}
		if (UIntFld != default)
		{
			sb.WriteSize(6);
			sb.Write(UIntFld);
		}
		if (ColorFld != Colors.Black)
		{
			sb.WriteSize(7);
			sb.Write(ColorFld);
		}
		if (DateTimeFld != default)
		{
			sb.WriteSize(8);
			sb.Write(DateTimeFld);
		}
		if (!DataFld.IsDefault())
		{
			sb.WriteSize(9);
			DataFld.WriteToBuf(sb);
		}
		if (ByteFld != default)
		{
			sb.WriteSize(10);
			sb.Write(ByteFld);
		}
		if (BoolFld != default)
		{
			sb.WriteSize(11);
			sb.Write(BoolFld);
		}
		if (ShortFld != default)
		{
			sb.WriteSize(12);
			sb.Write(ShortFld);
		}
		if (UShortFld != default)
		{
			sb.WriteSize(13);
			sb.Write(UShortFld);
		}
		if (LongFld != default)
		{
			sb.WriteSize(14);
			sb.Write(LongFld);
		}
		if (ULongFld != default)
		{
			sb.WriteSize(15);
			sb.Write(ULongFld);
		}
		if (FloatFld != default)
		{
			sb.WriteSize(16);
			sb.Write(FloatFld);
		}
		if (DoubleFld != default)
		{
			sb.WriteSize(17);
			sb.Write(DoubleFld);
		}
		if (DecimalFld != default)
		{
			sb.WriteSize(18);
			sb.Write(DecimalFld);
		}
		if (Vector2Fld != default)
		{
			sb.WriteSize(19);
			sb.Write(Vector2Fld);
		}
		if (Vector3Fld != default)
		{
			sb.WriteSize(20);
			sb.Write(Vector3Fld);
		}
		if (QuaternionFld != Quaternion.Identity)
		{
			sb.WriteSize(21);
			sb.Write(QuaternionFld);
		}
		if (Vector2IFld != default)
		{
			sb.WriteSize(22);
			sb.Write(Vector2IFld);
		}
		if (Vector3IFld != default)
		{
			sb.WriteSize(23);
			sb.Write(Vector3IFld);
		}
		if (Vector4IFld != default)
		{
			sb.WriteSize(24);
			sb.Write(Vector4IFld);
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
			StringFld = sb.ReadString();
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 5)
		{
			IntFld = sb.ReadInt();
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 6)
		{
			UIntFld = sb.ReadUInt();
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 7)
		{
			ColorFld = sb.ReadColor();
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 8)
		{
			DateTimeFld = sb.ReadDateTime();
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 9)
		{
			DataFld.ReadFromBuf(sb);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 10)
		{
			ByteFld = sb.ReadByte();
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 11)
		{
			BoolFld = sb.ReadBool();
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 12)
		{
			ShortFld = sb.ReadShort();
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 13)
		{
			UShortFld = sb.ReadUShort();
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 14)
		{
			LongFld = sb.ReadLong();
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 15)
		{
			ULongFld = sb.ReadULong();
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 16)
		{
			FloatFld = sb.ReadFloat();
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 17)
		{
			DoubleFld = sb.ReadDouble();
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 18)
		{
			DecimalFld = sb.ReadDecimal();
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 19)
		{
			Vector2Fld = sb.ReadVector2();
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 20)
		{
			Vector3Fld = sb.ReadVector3();
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 21)
		{
			QuaternionFld = sb.ReadQuaternion();
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 22)
		{
			sb.Read(out Vector2IFld);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 23)
		{
			sb.Read(out Vector3IFld);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 24)
		{
			Vector4IFld = sb.ReadVector4I();
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
			StringFld = sb.ReadString();
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 5)
		{
			IntFld = sb.ReadInt();
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 6)
		{
			UIntFld = sb.ReadUInt();
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 7)
		{
			ColorFld = sb.ReadColor();
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 8)
		{
			DateTimeFld = sb.ReadDateTime();
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 9)
		{
			DataFld.ReadFromBuf(sb);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 10)
		{
			ByteFld = sb.ReadByte();
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 11)
		{
			BoolFld = sb.ReadBool();
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 12)
		{
			ShortFld = sb.ReadShort();
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 13)
		{
			UShortFld = sb.ReadUShort();
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 14)
		{
			LongFld = sb.ReadLong();
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 15)
		{
			ULongFld = sb.ReadULong();
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 16)
		{
			FloatFld = sb.ReadFloat();
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 17)
		{
			DoubleFld = sb.ReadDouble();
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 18)
		{
			DecimalFld = sb.ReadDecimal();
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 19)
		{
			Vector2Fld = sb.ReadVector2();
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 20)
		{
			Vector3Fld = sb.ReadVector3();
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 21)
		{
			QuaternionFld = sb.ReadQuaternion();
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 22)
		{
			sb.Read(out Vector2IFld);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 23)
		{
			sb.Read(out Vector3IFld);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 24)
		{
			Vector4IFld = sb.ReadVector4I();
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
			case 4:return StringFld == string.Empty;
			case 5:return IntFld == default;
			case 6:return UIntFld == default;
			case 7:return ColorFld == Colors.Black;
			case 8:return DateTimeFld == default;
			case 9:return DataFld.IsDefault();
			case 10:return ByteFld == default;
			case 11:return BoolFld == default;
			case 12:return ShortFld == default;
			case 13:return UShortFld == default;
			case 14:return LongFld == default;
			case 15:return ULongFld == default;
			case 16:return FloatFld == default;
			case 17:return DoubleFld == default;
			case 18:return DecimalFld == default;
			case 19:return Vector2Fld == default;
			case 20:return Vector3Fld == default;
			case 21:return QuaternionFld == Quaternion.Identity;
			case 22:return Vector2IFld == default;
			case 23:return Vector3IFld == default;
			case 24:return Vector4IFld == default;
		}
		return false;
	}
	public override bool FieldIsEqual(Data toFld, int field)
	{
		if (!(toFld is TestRecord to)) return false;
		switch(field)
		{
			case 0:return StatusCode == to.StatusCode;
			case 1:return ID == to.ID;
			case 2:return Timestamp == to.Timestamp;
			case 3:return EditByID == to.EditByID;
			case 4:return StringFld == to.StringFld;
			case 5:return IntFld == to.IntFld;
			case 6:return UIntFld == to.UIntFld;
			case 7:return ColorFld == to.ColorFld;
			case 8:return DateTimeFld == to.DateTimeFld;
			case 9:return DataFld.IsEqualTo(to.DataFld);
			case 10:return ByteFld == to.ByteFld;
			case 11:return BoolFld == to.BoolFld;
			case 12:return ShortFld == to.ShortFld;
			case 13:return UShortFld == to.UShortFld;
			case 14:return LongFld == to.LongFld;
			case 15:return ULongFld == to.ULongFld;
			case 16:return FloatFld == to.FloatFld;
			case 17:return DoubleFld == to.DoubleFld;
			case 18:return DecimalFld == to.DecimalFld;
			case 19:return Vector2Fld == to.Vector2Fld;
			case 20:return Vector3Fld == to.Vector3Fld;
			case 21:return QuaternionFld == to.QuaternionFld;
			case 22:return Vector2IFld == to.Vector2IFld;
			case 23:return Vector3IFld == to.Vector3IFld;
			case 24:return Vector4IFld == to.Vector4IFld;
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
			case 4:return StringFld;
			case 5:return IntFld.AsString();
			case 6:return UIntFld.AsString();
			case 7:return ColorFld.AsString();
			case 8:return DateTimeFld.AsString();
			case 9:return DataFld.AsString();
			case 10:return ByteFld.AsString();
			case 11:return BoolFld.AsString();
			case 12:return ShortFld.AsString();
			case 13:return UShortFld.AsString();
			case 14:return LongFld.AsString();
			case 15:return ULongFld.AsString();
			case 16:return FloatFld.AsString();
			case 17:return DoubleFld.AsString();
			case 18:return DecimalFld.AsString();
			case 19:return Vector2Fld.AsString();
			case 20:return Vector3Fld.AsString();
			case 21:return QuaternionFld.AsString();
			case 22:return Vector2IFld.AsString();
			case 23:return Vector3IFld.AsString();
			case 24:return Vector4IFld.AsString();
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
			case 4:StringFld = str; return;
			case 5:IntFld = str.AsInt(); return;
			case 6:UIntFld = str.AsUInt(); return;
			case 7:ColorFld = str.AsColor(); return;
			case 8:DateTimeFld = str.AsDateTime(); return;
			case 9:DataFld.FromString(str); return;
			case 10:ByteFld = str.AsByte(); return;
			case 11:BoolFld = str.AsBool(); return;
			case 12:ShortFld = str.AsShort(); return;
			case 13:UShortFld = str.AsUShort(); return;
			case 14:LongFld = str.AsLong(); return;
			case 15:ULongFld = str.AsULong(); return;
			case 16:FloatFld = str.AsFloat(); return;
			case 17:DoubleFld = str.AsDouble(); return;
			case 18:DecimalFld = str.AsDecimal(); return;
			case 19:Vector2Fld = str.AsVector2(); return;
			case 20:Vector3Fld = str.AsVector3(); return;
			case 21:QuaternionFld = str.AsQuaternion(); return;
			case 22:Vector2IFld = str.AsVector2I(); return;
			case 23:Vector3IFld = str.AsVector3I(); return;
			case 24:Vector4IFld = str.AsVector4I(); return;
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
			case 4:StringFld.AsKey(sb, maxSize); return;
			case 5:sb.Write(IntFld); return;
			case 6:sb.Write(UIntFld); return;
			case 7:sb.Write(ColorFld); return;
			case 8:sb.Write(DateTimeFld); return;
			case 9:return; // DataField as key is not supported
			case 10:sb.Write(ByteFld); return;
			case 11:sb.Write(BoolFld); return;
			case 12:sb.Write(ShortFld); return;
			case 13:sb.Write(UShortFld); return;
			case 14:sb.Write(LongFld); return;
			case 15:sb.Write(ULongFld); return;
			case 16:sb.Write(FloatFld); return;
			case 17:sb.Write(DoubleFld); return;
			case 18:sb.Write(DecimalFld); return;
			case 19:sb.Write(Vector2Fld); return;
			case 20:sb.Write(Vector3Fld); return;
			case 21:sb.Write(QuaternionFld); return;
			case 22:sb.Write(Vector2IFld); return;
			case 23:sb.Write(Vector3IFld); return;
			case 24:sb.Write(Vector4IFld); return;
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
			case 4:return (Object)StringFld;
			case 5:return (Object)IntFld;
			case 6:return (Object)UIntFld;
			case 7:return (Object)ColorFld;
			case 8:return (Object)DateTimeFld;
			case 9:return (Object)DataFld;
			case 10:return (Object)ByteFld;
			case 11:return (Object)BoolFld;
			case 12:return (Object)ShortFld;
			case 13:return (Object)UShortFld;
			case 14:return (Object)LongFld;
			case 15:return (Object)ULongFld;
			case 16:return (Object)FloatFld;
			case 17:return (Object)DoubleFld;
			case 18:return (Object)DecimalFld;
			case 19:return (Object)Vector2Fld;
			case 20:return (Object)Vector3Fld;
			case 21:return (Object)QuaternionFld;
			case 22:return (Object)Vector2IFld;
			case 23:return (Object)Vector3IFld;
			case 24:return (Object)Vector4IFld;
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
			case 4:StringFld = (string) o; return;
			case 5:IntFld = (int) o; return;
			case 6:UIntFld = (uint) o; return;
			case 7:ColorFld = (Color) o; return;
			case 8:DateTimeFld = (DateTime) o; return;
			case 9:DataFld = (TestData.DataField) o; return;
			case 10:ByteFld = (byte) o; return;
			case 11:BoolFld = (bool) o; return;
			case 12:ShortFld = (short) o; return;
			case 13:UShortFld = (ushort) o; return;
			case 14:LongFld = (long) o; return;
			case 15:ULongFld = (ulong) o; return;
			case 16:FloatFld = (float) o; return;
			case 17:DoubleFld = (double) o; return;
			case 18:DecimalFld = (decimal) o; return;
			case 19:Vector2Fld = (Vector2) o; return;
			case 20:Vector3Fld = (Vector3) o; return;
			case 21:QuaternionFld = (Quaternion) o; return;
			case 22:Vector2IFld = (Vector2I) o; return;
			case 23:Vector3IFld = (Vector3I) o; return;
			case 24:Vector4IFld = (Vector4I) o; return;
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
			case 4:return StringFld.GetType();
			case 5:return IntFld.GetType();
			case 6:return UIntFld.GetType();
			case 7:return ColorFld.GetType();
			case 8:return DateTimeFld.GetType();
			case 9:return DataFld.GetType();
			case 10:return ByteFld.GetType();
			case 11:return BoolFld.GetType();
			case 12:return ShortFld.GetType();
			case 13:return UShortFld.GetType();
			case 14:return LongFld.GetType();
			case 15:return ULongFld.GetType();
			case 16:return FloatFld.GetType();
			case 17:return DoubleFld.GetType();
			case 18:return DecimalFld.GetType();
			case 19:return Vector2Fld.GetType();
			case 20:return Vector3Fld.GetType();
			case 21:return QuaternionFld.GetType();
			case 22:return Vector2IFld.GetType();
			case 23:return Vector3IFld.GetType();
			case 24:return Vector4IFld.GetType();
		}
		return null;
	}
	public partial class Context : RecordContext<TestRecord>
	{
		protected override void OnBaseConstruct()
		{
			table = TableFactory<Table,TestRecord>.Rent();
		}
		internal static void InitContextFactory() => RecordContextFactory<TestRecord>.SetCreateMethod(()=>new Context(),_setEditById);
		static Context()
		{
			InitContextFactory();
		}
		public static Context Rent(int EditByID=-2) => (Context) RecordContextFactory<TestRecord>.Rent(EditByID);
		public override Table Table => (Table) table;
		public override void Dispose()
		{
			RecordContextFactory<TestRecord>.Return(this);
		}
	}
	public static class FID
	{
		public const int StatusCode = 0;
		public const int ID = 1;
		public const int Timestamp = 2;
		public const int EditByID = 3;
		public const int StringFld = 4;
		public const int IntFld = 5;
		public const int UIntFld = 6;
		public const int ColorFld = 7;
		public const int DateTimeFld = 8;
		public const int DataFld = 9;
		public const int ByteFld = 10;
		public const int BoolFld = 11;
		public const int ShortFld = 12;
		public const int UShortFld = 13;
		public const int LongFld = 14;
		public const int ULongFld = 15;
		public const int FloatFld = 16;
		public const int DoubleFld = 17;
		public const int DecimalFld = 18;
		public const int Vector2Fld = 19;
		public const int Vector3Fld = 20;
		public const int QuaternionFld = 21;
		public const int Vector2IFld = 22;
		public const int Vector3IFld = 23;
		public const int Vector4IFld = 24;
	}
	static object[] Min = { (byte) 0,(int) -2147483648,(long) 0,(int) -2147483648,(int) 0,(int) -2147483648,(uint) 0,(int) 0,(long) 0,(int) 0,(byte) 0,(int) 0,(short) -32768,(ushort) 0,(long) -9223372036854775808,(ulong) 0,(float) -16777217,(double) -9007199254740992,(decimal) -9007199254740992,(float) -16777217,(float) -16777217,(float) -16777217,(int) -2147483648,(int) -2147483648,(int) -2147483648, };
	static object[] Max = { (byte) 255,(int) 2147483647,(long) 3155378975999999999,(int) 2147483647,(int) 0,(int) 2147483647,(uint) 4294967295,(int) 0,(long) 3155378975999999999,(int) 0,(byte) 255,(int) 0,(short) 32767,(ushort) 65535,(long) 9223372036854775807,(ulong) 18446744073709551615,(float) 16777217,(double) 9007199254740992,(decimal) 9007199254740992,(float) 16777217,(float) 16777217,(float) 16777217,(int) 2147483647,(int) 2147483647,(int) 2147483647, };
	static string[] FieldLabels =
	{
		"Status Code",
		"ID",
		"Timestamp",
		"Edit By ID",
		"String Fld",
		"Int Fld",
		"U Int Fld",
		"Color Fld",
		"Date Time Fld",
		"Data Fld",
		"Byte Fld",
		"Bool Fld",
		"Short Fld",
		"U Short Fld",
		"Long Fld",
		"U Long Fld",
		"Float Fld",
		"Double Fld",
		"Decimal Fld",
		"Vector2 Fld",
		"Vector3 Fld",
		"Quaternion Fld",
		"Vector2I Fld",
		"Vector3I Fld",
		"Vector4I Fld",
	};
	static string[] ColumnLabels =
	{
		"Status Code",
		"ID",
		"Timestamp",
		"Edit By ID",
		"String Fld",
		"Int Fld",
		"U Int Fld",
		"Color Fld",
		"Date Time Fld",
		"Data Fld",
		"Byte Fld",
		"Bool Fld",
		"Short Fld",
		"U Short Fld",
		"Long Fld",
		"U Long Fld",
		"Float Fld",
		"Double Fld",
		"Decimal Fld",
		"Vector2 Fld",
		"Vector3 Fld",
		"Quaternion Fld",
		"Vector2I Fld",
		"Vector3I Fld",
		"Vector4I Fld",
	};
	static Dictionary<string, int> FieldIdLookup = new()
	{
		{ "StatusCode", 0 },
		{ "ID", 1 },
		{ "Timestamp", 2 },
		{ "EditByID", 3 },
		{ "StringFld", 4 },
		{ "IntFld", 5 },
		{ "UIntFld", 6 },
		{ "ColorFld", 7 },
		{ "DateTimeFld", 8 },
		{ "DataFld", 9 },
		{ "ByteFld", 10 },
		{ "BoolFld", 11 },
		{ "ShortFld", 12 },
		{ "UShortFld", 13 },
		{ "LongFld", 14 },
		{ "ULongFld", 15 },
		{ "FloatFld", 16 },
		{ "DoubleFld", 17 },
		{ "DecimalFld", 18 },
		{ "Vector2Fld", 19 },
		{ "Vector3Fld", 20 },
		{ "QuaternionFld", 21 },
		{ "Vector2IFld", 22 },
		{ "Vector3IFld", 23 },
		{ "Vector4IFld", 24 },
	};
	static string[] FieldNames =
	{
		"StatusCode",
		"ID",
		"Timestamp",
		"EditByID",
		"StringFld",
		"IntFld",
		"UIntFld",
		"ColorFld",
		"DateTimeFld",
		"DataFld",
		"ByteFld",
		"BoolFld",
		"ShortFld",
		"UShortFld",
		"LongFld",
		"ULongFld",
		"FloatFld",
		"DoubleFld",
		"DecimalFld",
		"Vector2Fld",
		"Vector3Fld",
		"QuaternionFld",
		"Vector2IFld",
		"Vector3IFld",
		"Vector4IFld",
	};
	static string[] TypeNames =
	{
		"byte",
		"int",
		"DateTime",
		"int",
		"string",
		"int",
		"uint",
		"Color",
		"DateTime",
		"DataField",
		"byte",
		"bool",
		"short",
		"ushort",
		"long",
		"ulong",
		"float",
		"double",
		"decimal",
		"Vector2",
		"Vector3",
		"Quaternion",
		"Vector2I",
		"Vector3I",
		"Vector4I",
	};
	public override string[] StaticTypeNames => TypeNames;
	static List<ValidationFunc>[] ValidationFuncs = new List<ValidationFunc>[25];
	public override List<ValidationFunc>[] StaticValidationFuncs => ValidationFuncs;
	public partial class Util : RecordUtil<TestRecord>
	{
	}
	public partial class Table : Table<TestRecord>
	{
	}
}
