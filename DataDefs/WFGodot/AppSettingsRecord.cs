//  Copyright (C) 2023 - Present John Roscoe Hamilton - All Rights Reserved
//  You may use, distribute and modify this code under the terms of the MIT license.
//  See the file License.txt in the root folder for full license details.

using System.ComponentModel.DataAnnotations;
namespace WFCodeGen;
public sealed partial class AppSettingsRecord : Record
{
    [Range(0, 1)]
    public float MasterVolume = 1f;
    [Range(0, 1)]
    public float MusicVolume = 1f;
    [Range(0, 1)]
    public float SFXVolume = 1f;
    [Range(0, 1)]
    public float UIVolume = 1f;
    public bool ShowFPS = true;
    public bool ShowMPH = true;
    public bool ShowToolbar = true;
}
