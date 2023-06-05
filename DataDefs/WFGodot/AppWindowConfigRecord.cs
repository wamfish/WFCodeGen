//  Copyright (C) 2023 - Present John Roscoe Hamilton - All Rights Reserved
//  You may use, distribute and modify this code under the terms of the MIT license.
//  See the file License.txt in the root folder for full license details.

namespace WFCodeGen;
public sealed partial class AppWindowConfigRecord : Record
{
    public int LastScreenIndex = 0;
    public int LastWindowMode = (int)DisplayServer.WindowMode.Windowed;
    public Vector2I LastWindowSize = new(400, 600);
    public Vector2I LastWindowPos = new(0, 0);
}
