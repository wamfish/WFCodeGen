//  Copyright (C) 2023 - Present John Roscoe Hamilton - All Rights Reserved
//  You may use, distribute and modify this code under the terms of the MIT license.
//  See the file License.txt in the root folder for full license details.

namespace WFCodeGen;

public sealed partial class LineEditSettings : Data
{
    public Color SelectedColor = Colors.White;
    public Color UneditableColor = Colors.DarkGray;
    public Color PlaceholderColor = Colors.DarkGray;
    public Color OutlineColor = Colors.DarkGray;
    public Color CaretColor = Colors.White;
    public Color SelectionColor = Gray7;
    public Color ClearBtnColor = Colors.Blue;
    public Color ClearBtnPressedColor = Colors.Green;
    public int MinimumCharWidth = 0;
    public int OutlineSize = 0;
    public int CaretWidth = 3;
    public FontSettings.DataField Font;
    public StyleBoxSettings.DataField NormalStyleBox;
    public StyleBoxSettings.DataField ReadonlyStyleBox;
    public StyleBoxSettings.DataField FocusStyleBox;
    public StyleBoxSettings.DataField NormalStyleBoxNM;
    public StyleBoxSettings.DataField ReadonlyStyleBoxNM;
    public StyleBoxSettings.DataField FocusStyleBoxNM;
    
}
