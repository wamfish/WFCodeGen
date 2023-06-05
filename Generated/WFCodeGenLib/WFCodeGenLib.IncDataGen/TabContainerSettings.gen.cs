﻿/// <auto-generated/>
using WFLib;
using Godot;
using System;
namespace WFCodeGen;
public partial class TabContainerSettings : Data
{
	protected override void OnBaseConstruct()
	{
		Init();
	}
	public override int FieldCount => 12;
	public TabContainerSettings Rent()=>DataFactory<TabContainerSettings>.Rent();
	~TabContainerSettings() => Dispose();
	public override void Dispose()
	{
		DataFactory<TabContainerSettings>.Return(this);
		base.Dispose();
	}
	public override bool IsRecord => false;
	public partial class DataField : DataField<TabContainerSettings>
	{
		public DataField(int field)
		{
			Field=field;
		}
		public FontSettings.DataField Font => Data.Font;
		public Godot.Color SelectedFontColor => Data.SelectedFontColor;
		public Godot.Color UnselectedFontColor => Data.UnselectedFontColor;
		public Godot.Color DisabledFontColor => Data.DisabledFontColor;
		public Godot.Color FontOutlineColor => Data.FontOutlineColor;
		public Godot.Color DropMarkColor => Data.DropMarkColor;
		public StyleBoxSettings.DataField SelectedStyleBox => Data.SelectedStyleBox;
		public StyleBoxSettings.DataField UnselectedStyleBox => Data.UnselectedStyleBox;
		public StyleBoxSettings.DataField DisabledStyleBox => Data.DisabledStyleBox;
		public StyleBoxSettings.DataField PanelStyleBox => Data.PanelStyleBox;
		public StyleBoxSettings.DataField TabBarStyleBox => Data.TabBarStyleBox;
		public int TabbarSideMargin => Data.TabbarSideMargin;
	}
	public override void Clear()
	{
		if (Font == null)
		{
			Font = new(0);
		}
		Font.Clear();
		SelectedFontColor = Godot.Colors.Black;
		UnselectedFontColor = Godot.Colors.Black;
		DisabledFontColor = Godot.Colors.Black;
		FontOutlineColor = Godot.Colors.Black;
		DropMarkColor = Godot.Colors.Black;
		if (SelectedStyleBox == null)
		{
			SelectedStyleBox = new(6);
		}
		SelectedStyleBox.Clear();
		if (UnselectedStyleBox == null)
		{
			UnselectedStyleBox = new(7);
		}
		UnselectedStyleBox.Clear();
		if (DisabledStyleBox == null)
		{
			DisabledStyleBox = new(8);
		}
		DisabledStyleBox.Clear();
		if (PanelStyleBox == null)
		{
			PanelStyleBox = new(9);
		}
		PanelStyleBox.Clear();
		if (TabBarStyleBox == null)
		{
			TabBarStyleBox = new(10);
		}
		TabBarStyleBox.Clear();
		TabbarSideMargin = 0;
		OnClear();
	}
	public override void Init()
	{
		if (Font == null) 
		{
			Font = new(0);
		}
		Font.Init();
		SelectedFontColor = Colors.White;
		UnselectedFontColor = Colors.LightGray;
		DisabledFontColor = Colors.White;
		FontOutlineColor = Colors.White;
		DropMarkColor = Colors.White;
		if (SelectedStyleBox == null) 
		{
			SelectedStyleBox = new(6);
		}
		SelectedStyleBox.Init();
		if (UnselectedStyleBox == null) 
		{
			UnselectedStyleBox = new(7);
		}
		UnselectedStyleBox.Init();
		if (DisabledStyleBox == null) 
		{
			DisabledStyleBox = new(8);
		}
		DisabledStyleBox.Init();
		if (PanelStyleBox == null) 
		{
			PanelStyleBox = new(9);
		}
		PanelStyleBox.Init();
		if (TabBarStyleBox == null) 
		{
			TabBarStyleBox = new(10);
		}
		TabBarStyleBox.Init();
		TabbarSideMargin = 0;
		OnInitialize();
	}
	public override void CopyTo(Data toData)
	{
		if (!(toData is TabContainerSettings to)) return;
		to.Clear();
		Font.CopyTo(to.Font);
		to.SelectedFontColor = SelectedFontColor;
		to.UnselectedFontColor = UnselectedFontColor;
		to.DisabledFontColor = DisabledFontColor;
		to.FontOutlineColor = FontOutlineColor;
		to.DropMarkColor = DropMarkColor;
		SelectedStyleBox.CopyTo(to.SelectedStyleBox);
		UnselectedStyleBox.CopyTo(to.UnselectedStyleBox);
		DisabledStyleBox.CopyTo(to.DisabledStyleBox);
		PanelStyleBox.CopyTo(to.PanelStyleBox);
		TabBarStyleBox.CopyTo(to.TabBarStyleBox);
		to.TabbarSideMargin = TabbarSideMargin;
	}
	public override void FieldCopyTo(Data toData, int field)
	{
		if (!(toData is TabContainerSettings to)) return;
		switch(field)
		{
			case 0:Font.CopyTo(to.Font); return;
			case 1:to.SelectedFontColor = SelectedFontColor; return;
			case 2:to.UnselectedFontColor = UnselectedFontColor; return;
			case 3:to.DisabledFontColor = DisabledFontColor; return;
			case 4:to.FontOutlineColor = FontOutlineColor; return;
			case 5:to.DropMarkColor = DropMarkColor; return;
			case 6:SelectedStyleBox.CopyTo(to.SelectedStyleBox); return;
			case 7:UnselectedStyleBox.CopyTo(to.UnselectedStyleBox); return;
			case 8:DisabledStyleBox.CopyTo(to.DisabledStyleBox); return;
			case 9:PanelStyleBox.CopyTo(to.PanelStyleBox); return;
			case 10:TabBarStyleBox.CopyTo(to.TabBarStyleBox); return;
			case 11:to.TabbarSideMargin = TabbarSideMargin; return;
		}
	}
	public override void WriteToBuf(SerializationBuffer sb, bool append=false)
	{
		if (!append) sb.Clear();
		if (!Font.IsDefault())
		{
			sb.WriteSize(0);
			Font.WriteToBuf(sb);
		}
		if (SelectedFontColor != Colors.Black)
		{
			sb.WriteSize(1);
			sb.Write(SelectedFontColor);
		}
		if (UnselectedFontColor != Colors.Black)
		{
			sb.WriteSize(2);
			sb.Write(UnselectedFontColor);
		}
		if (DisabledFontColor != Colors.Black)
		{
			sb.WriteSize(3);
			sb.Write(DisabledFontColor);
		}
		if (FontOutlineColor != Colors.Black)
		{
			sb.WriteSize(4);
			sb.Write(FontOutlineColor);
		}
		if (DropMarkColor != Colors.Black)
		{
			sb.WriteSize(5);
			sb.Write(DropMarkColor);
		}
		if (!SelectedStyleBox.IsDefault())
		{
			sb.WriteSize(6);
			SelectedStyleBox.WriteToBuf(sb);
		}
		if (!UnselectedStyleBox.IsDefault())
		{
			sb.WriteSize(7);
			UnselectedStyleBox.WriteToBuf(sb);
		}
		if (!DisabledStyleBox.IsDefault())
		{
			sb.WriteSize(8);
			DisabledStyleBox.WriteToBuf(sb);
		}
		if (!PanelStyleBox.IsDefault())
		{
			sb.WriteSize(9);
			PanelStyleBox.WriteToBuf(sb);
		}
		if (!TabBarStyleBox.IsDefault())
		{
			sb.WriteSize(10);
			TabBarStyleBox.WriteToBuf(sb);
		}
		if (TabbarSideMargin != default)
		{
			sb.WriteSize(11);
			sb.Write(TabbarSideMargin);
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
			Font.ReadFromBuf(sb);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 1)
		{
			sb.Read(out SelectedFontColor);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 2)
		{
			sb.Read(out UnselectedFontColor);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 3)
		{
			sb.Read(out DisabledFontColor);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 4)
		{
			sb.Read(out FontOutlineColor);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 5)
		{
			sb.Read(out DropMarkColor);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 6)
		{
			SelectedStyleBox.ReadFromBuf(sb);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 7)
		{
			UnselectedStyleBox.ReadFromBuf(sb);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 8)
		{
			DisabledStyleBox.ReadFromBuf(sb);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 9)
		{
			PanelStyleBox.ReadFromBuf(sb);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 10)
		{
			TabBarStyleBox.ReadFromBuf(sb);
			fieldIndex = sb.ReadSize();
			if (fieldIndex > maxField) return;
		}
		if (fieldIndex == 11)
		{
			sb.Read(out TabbarSideMargin);
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
			Font.ReadFromBuf(sb);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 1)
		{
			sb.Read(out SelectedFontColor);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 2)
		{
			sb.Read(out UnselectedFontColor);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 3)
		{
			sb.Read(out DisabledFontColor);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 4)
		{
			sb.Read(out FontOutlineColor);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 5)
		{
			sb.Read(out DropMarkColor);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 6)
		{
			SelectedStyleBox.ReadFromBuf(sb);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 7)
		{
			UnselectedStyleBox.ReadFromBuf(sb);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 8)
		{
			DisabledStyleBox.ReadFromBuf(sb);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 9)
		{
			PanelStyleBox.ReadFromBuf(sb);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 10)
		{
			TabBarStyleBox.ReadFromBuf(sb);
			fieldIndex = sb.ReadSize();
		}
		if (fieldIndex == 11)
		{
			sb.Read(out TabbarSideMargin);
			fieldIndex = sb.ReadSize();
		}
		OnLoad();
	}
	public override bool FieldIsDefault(int field)
	{
		switch(field)
		{
			case 0:return Font.IsDefault();
			case 1:return SelectedFontColor == Colors.Black;
			case 2:return UnselectedFontColor == Colors.Black;
			case 3:return DisabledFontColor == Colors.Black;
			case 4:return FontOutlineColor == Colors.Black;
			case 5:return DropMarkColor == Colors.Black;
			case 6:return SelectedStyleBox.IsDefault();
			case 7:return UnselectedStyleBox.IsDefault();
			case 8:return DisabledStyleBox.IsDefault();
			case 9:return PanelStyleBox.IsDefault();
			case 10:return TabBarStyleBox.IsDefault();
			case 11:return TabbarSideMargin == default;
		}
		return false;
	}
	public override bool FieldIsEqual(Data toFld, int field)
	{
		if (!(toFld is TabContainerSettings to)) return false;
		switch(field)
		{
			case 0:return Font.IsEqualTo(to.Font);
			case 1:return SelectedFontColor == to.SelectedFontColor;
			case 2:return UnselectedFontColor == to.UnselectedFontColor;
			case 3:return DisabledFontColor == to.DisabledFontColor;
			case 4:return FontOutlineColor == to.FontOutlineColor;
			case 5:return DropMarkColor == to.DropMarkColor;
			case 6:return SelectedStyleBox.IsEqualTo(to.SelectedStyleBox);
			case 7:return UnselectedStyleBox.IsEqualTo(to.UnselectedStyleBox);
			case 8:return DisabledStyleBox.IsEqualTo(to.DisabledStyleBox);
			case 9:return PanelStyleBox.IsEqualTo(to.PanelStyleBox);
			case 10:return TabBarStyleBox.IsEqualTo(to.TabBarStyleBox);
			case 11:return TabbarSideMargin == to.TabbarSideMargin;
		}
		return false;
	}
	public override string FieldAsString(int field)
	{
		switch(field)
		{
			case 0:return Font.AsString();
			case 1:return SelectedFontColor.AsString();
			case 2:return UnselectedFontColor.AsString();
			case 3:return DisabledFontColor.AsString();
			case 4:return FontOutlineColor.AsString();
			case 5:return DropMarkColor.AsString();
			case 6:return SelectedStyleBox.AsString();
			case 7:return UnselectedStyleBox.AsString();
			case 8:return DisabledStyleBox.AsString();
			case 9:return PanelStyleBox.AsString();
			case 10:return TabBarStyleBox.AsString();
			case 11:return TabbarSideMargin.AsString();
		}
		return string.Empty;
	}
	public override void FieldFromString(string str, int field)
	{
		switch(field)
		{
			case 0:Font.FromString(str); return;
			case 1:SelectedFontColor = str.AsColor(); return;
			case 2:UnselectedFontColor = str.AsColor(); return;
			case 3:DisabledFontColor = str.AsColor(); return;
			case 4:FontOutlineColor = str.AsColor(); return;
			case 5:DropMarkColor = str.AsColor(); return;
			case 6:SelectedStyleBox.FromString(str); return;
			case 7:UnselectedStyleBox.FromString(str); return;
			case 8:DisabledStyleBox.FromString(str); return;
			case 9:PanelStyleBox.FromString(str); return;
			case 10:TabBarStyleBox.FromString(str); return;
			case 11:TabbarSideMargin = str.AsInt(); return;
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
			case 0:return; // DataField as key is not supported
			case 1:sb.Write(SelectedFontColor); return;
			case 2:sb.Write(UnselectedFontColor); return;
			case 3:sb.Write(DisabledFontColor); return;
			case 4:sb.Write(FontOutlineColor); return;
			case 5:sb.Write(DropMarkColor); return;
			case 6:return; // DataField as key is not supported
			case 7:return; // DataField as key is not supported
			case 8:return; // DataField as key is not supported
			case 9:return; // DataField as key is not supported
			case 10:return; // DataField as key is not supported
			case 11:sb.Write(TabbarSideMargin); return;
		}
	}
	/// <summary>
	/// Returns the field as an object.
	/// </summary>
	public override Object FieldAsObject(int field)
	{
		switch(field)
		{
			case 0:return (Object)Font;
			case 1:return (Object)SelectedFontColor;
			case 2:return (Object)UnselectedFontColor;
			case 3:return (Object)DisabledFontColor;
			case 4:return (Object)FontOutlineColor;
			case 5:return (Object)DropMarkColor;
			case 6:return (Object)SelectedStyleBox;
			case 7:return (Object)UnselectedStyleBox;
			case 8:return (Object)DisabledStyleBox;
			case 9:return (Object)PanelStyleBox;
			case 10:return (Object)TabBarStyleBox;
			case 11:return (Object)TabbarSideMargin;
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
			case 0:Font = (FontSettings.DataField) o; return;
			case 1:SelectedFontColor = (Color) o; return;
			case 2:UnselectedFontColor = (Color) o; return;
			case 3:DisabledFontColor = (Color) o; return;
			case 4:FontOutlineColor = (Color) o; return;
			case 5:DropMarkColor = (Color) o; return;
			case 6:SelectedStyleBox = (StyleBoxSettings.DataField) o; return;
			case 7:UnselectedStyleBox = (StyleBoxSettings.DataField) o; return;
			case 8:DisabledStyleBox = (StyleBoxSettings.DataField) o; return;
			case 9:PanelStyleBox = (StyleBoxSettings.DataField) o; return;
			case 10:TabBarStyleBox = (StyleBoxSettings.DataField) o; return;
			case 11:TabbarSideMargin = (int) o; return;
		}
	}
	/// <summary>
	/// Returns the field Type.
	/// </summary>
	public override Type FieldType(int field)
	{
		switch(field)
		{
			case 0:return Font.GetType();
			case 1:return SelectedFontColor.GetType();
			case 2:return UnselectedFontColor.GetType();
			case 3:return DisabledFontColor.GetType();
			case 4:return FontOutlineColor.GetType();
			case 5:return DropMarkColor.GetType();
			case 6:return SelectedStyleBox.GetType();
			case 7:return UnselectedStyleBox.GetType();
			case 8:return DisabledStyleBox.GetType();
			case 9:return PanelStyleBox.GetType();
			case 10:return TabBarStyleBox.GetType();
			case 11:return TabbarSideMargin.GetType();
		}
		return null;
	}
	public partial class Context : DataContext<TabContainerSettings>
	{
		protected override void OnBaseConstruct()
		{
			Data = DataFactory<TabContainerSettings>.Rent();
		}
		public static Context Rent() => (Context) DataContextFactory<TabContainerSettings>.Rent();
		public override void Dispose()
		{
			DataContextFactory<TabContainerSettings>.Return(this);
		}
	}
	public static class FID
	{
		public const int Font = 0;
		public const int SelectedFontColor = 1;
		public const int UnselectedFontColor = 2;
		public const int DisabledFontColor = 3;
		public const int FontOutlineColor = 4;
		public const int DropMarkColor = 5;
		public const int SelectedStyleBox = 6;
		public const int UnselectedStyleBox = 7;
		public const int DisabledStyleBox = 8;
		public const int PanelStyleBox = 9;
		public const int TabBarStyleBox = 10;
		public const int TabbarSideMargin = 11;
	}
	static object[] Min = { (int) 0,(int) 0,(int) 0,(int) 0,(int) 0,(int) 0,(int) 0,(int) 0,(int) 0,(int) 0,(int) 0,(int) -2147483648, };
	static object[] Max = { (int) 0,(int) 0,(int) 0,(int) 0,(int) 0,(int) 0,(int) 0,(int) 0,(int) 0,(int) 0,(int) 0,(int) 2147483647, };
	static string[] FieldLabels =
	{
		"Font",
		"Selected Font Color",
		"Unselected Font Color",
		"Disabled Font Color",
		"Font Outline Color",
		"Drop Mark Color",
		"Selected Style Box",
		"Unselected Style Box",
		"Disabled Style Box",
		"Panel Style Box",
		"Tab Bar Style Box",
		"Tabbar Side Margin",
	};
	static string[] ColumnLabels =
	{
		"Font",
		"Selected Font Color",
		"Unselected Font Color",
		"Disabled Font Color",
		"Font Outline Color",
		"Drop Mark Color",
		"Selected Style Box",
		"Unselected Style Box",
		"Disabled Style Box",
		"Panel Style Box",
		"Tab Bar Style Box",
		"Tabbar Side Margin",
	};
	static Dictionary<string, int> FieldIdLookup = new()
	{
		{ "Font", 0 },
		{ "SelectedFontColor", 1 },
		{ "UnselectedFontColor", 2 },
		{ "DisabledFontColor", 3 },
		{ "FontOutlineColor", 4 },
		{ "DropMarkColor", 5 },
		{ "SelectedStyleBox", 6 },
		{ "UnselectedStyleBox", 7 },
		{ "DisabledStyleBox", 8 },
		{ "PanelStyleBox", 9 },
		{ "TabBarStyleBox", 10 },
		{ "TabbarSideMargin", 11 },
	};
	static string[] FieldNames =
	{
		"Font",
		"SelectedFontColor",
		"UnselectedFontColor",
		"DisabledFontColor",
		"FontOutlineColor",
		"DropMarkColor",
		"SelectedStyleBox",
		"UnselectedStyleBox",
		"DisabledStyleBox",
		"PanelStyleBox",
		"TabBarStyleBox",
		"TabbarSideMargin",
	};
	static string[] TypeNames =
	{
		"DataField",
		"Color",
		"Color",
		"Color",
		"Color",
		"Color",
		"DataField",
		"DataField",
		"DataField",
		"DataField",
		"DataField",
		"int",
	};
	public override string[] StaticTypeNames => TypeNames;
	static List<ValidationFunc>[] ValidationFuncs = new List<ValidationFunc>[12];
	public override List<ValidationFunc>[] StaticValidationFuncs => ValidationFuncs;
	public partial class Util : DataUtil<TabContainerSettings>
	{
	}
}
