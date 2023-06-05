//  Copyright (C) 2023 - Present John Roscoe Hamilton - All Rights Reserved
//  You may use, distribute and modify this code under the terms of the MIT license.
//  See the file License.txt in the root folder for full license details.

//  ToDo: This is a good start to wrapping Godot's theme
//  classes, and making it more friendly to procedural 
//  themeing. Much more work is need to make this truly
//  useful. 
namespace WFCodeGen;
public sealed partial class UITheme : Record
{
    public FontSettings.DataField WindowFont;
    public StyleBoxSettings.DataField WindowStyleBox;
    public FontSettings.DataField TitleBarFont;
    public StyleBoxSettings.DataField TitleBarStyleBox;
    public FontSettings.DataField ActionItemFont;
    public StyleBoxSettings.DataField ActionItemStyleBox;
    public StyleBoxSettings.DataField ActionBarStyleBox;
    public StyleBoxSettings.DataField DockStyleBox;
    public StyleBoxSettings.DataField DockableStyleBox;
    public StyleBoxSettings.DataField ContentStyleBox;
    public StyleBoxSettings.DataField VertDockSliderStyleBox;
    public StyleBoxSettings.DataField HorztDockSliderStyleBox;
    public StyleBoxSettings.DataField EmptyStyleBox;
    public ButtonSettings.DataField Button;
    public LabelSettings.DataField Label;
    public LineEditSettings.DataField LineEdit;
    public ScrollbarSettings.DataField Scrollbar;
    public TabContainerSettings.DataField TabContainer;
    public CheckBoxSettings.DataField CheckBox;
}

