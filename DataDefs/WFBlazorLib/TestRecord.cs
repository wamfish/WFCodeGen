//  Copyright (C) 2023 - Present John Roscoe Hamilton - All Rights Reserved
//  You may use, distribute and modify this code under the terms of the MIT license.
//  See the file License.txt in the root folder for full license details.

namespace WFCodeGen;

public sealed partial class TestData : Data
{
    public int DataInt { get; set; }
    public string DataString { get; set; }
}
public sealed partial class TestRecord : Record
{
    public TestRecord()
    {
        FieldInit();
    }
    static bool firstPass = true;
    void FieldInit()
    {
        if (!firstPass) return;
        firstPass = true;
        FieldLabelSet(FID.DateTimeFld, "DateTime Fld");
    }
    public string StringFld { get; set; }
    public int IntFld { get; set; }
    public uint UIntFld { get; set; }
    public Color ColorFld { get; set; }
    public DateTime DateTimeFld { get; set; }
    public TestData.DataField DataFld { get; set; }
    public byte ByteFld { get; set; }
    public bool BoolFld { get; set; } = false;
    public short ShortFld { get; set; }
    public ushort UShortFld { get; set; }
    public long LongFld { get; set; }
    public ulong ULongFld { get; set; }
    public float FloatFld { get; set; }
    public double DoubleFld { get; set; }
    public decimal DecimalFld { get; set; }
    public Vector2 Vector2Fld { get; set; }
    public Vector3 Vector3Fld { get; set; }
    public Quaternion QuaternionFld { get; set; }
    public Vector2I Vector2IFld;
    public Vector3I Vector3IFld;
    public Vector4I Vector4IFld { get; set; }


}