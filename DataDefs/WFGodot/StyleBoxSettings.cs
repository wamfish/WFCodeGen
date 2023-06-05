//  Copyright (C) 2023 - Present John Roscoe Hamilton - All Rights Reserved
//  You may use, distribute and modify this code under the terms of the MIT license.
//  See the file License.txt in the root folder for full license details.
namespace WFCodeGen;
//this class is meant to be used as a DataField
//ovveride the init with the OnInit event
public partial class StyleBoxSettings : Data
{
    public Color BackgroundColor = Blue5;
    public Color BorderColor = Transparent;
    public StyleBoxMargin.DataField Margin;
    [X] public StyleBoxFlat StyleBox => GetStyleBox?.Invoke();
    private Func<StyleBoxFlat> GetStyleBox;
}