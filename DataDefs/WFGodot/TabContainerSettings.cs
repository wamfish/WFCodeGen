//  Copyright (C) 2023 - Present John Roscoe Hamilton - All Rights Reserved
//  You may use, distribute and modify this code under the terms of the MIT license.
//  See the file License.txt in the root folder for full license details.
namespace WFCodeGen;
public sealed partial class TabContainerSettings : Data
{
    public FontSettings.DataField Font;
    public Color SelectedFontColor = Colors.White;
    public Color UnselectedFontColor = Colors.LightGray;
    public Color DisabledFontColor = Colors.White;
    public Color FontOutlineColor = Colors.White;
    public Color DropMarkColor = Colors.White;
    public StyleBoxSettings.DataField SelectedStyleBox;
    public StyleBoxSettings.DataField UnselectedStyleBox;
    public StyleBoxSettings.DataField DisabledStyleBox;
    public StyleBoxSettings.DataField PanelStyleBox;
    public StyleBoxSettings.DataField TabBarStyleBox;
    public int TabbarSideMargin = 0;
    
}