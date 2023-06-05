//  Copyright (C) 2023 - Present John Roscoe Hamilton - All Rights Reserved
//  You may use, distribute and modify this code under the terms of the MIT license.
//  See the file License.txt in the root folder for full license details.

namespace WFCodeGen;
public partial class ButtonSettings : Data
{
    public int ButtonHSeperation = 5;
    public FontSettings.DataField Font;
    public Color NormalFontColor = Colors.Black;
    public Color FocusFontColor = Colors.Black;
    public Color HoverFontColor = Colors.White;
    public Color PressedFontColor = Colors.Green;
    public Color DisabledFontColor = Colors.Gray;
    public StyleBoxSettings.DataField NormalStyleBox;
    public StyleBoxSettings.DataField FocusStyleBox;
    public StyleBoxSettings.DataField HoverStyleBox;
    public StyleBoxSettings.DataField PressedStyleBox;
    public StyleBoxSettings.DataField DisabledStyleBox;
}
