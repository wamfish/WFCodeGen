//  Copyright (C) 2023 - Present John Roscoe Hamilton - All Rights Reserved
//  You may use, distribute and modify this code under the terms of the MIT license.
//  See the file License.txt in the root folder for full license details.

namespace WFCodeGen;
public partial class WindowConfigRecord : Record
{
[K] public string WindowName;
    public Vector2 Position = Vector2.Zero;
    public Vector2 Size = new(400, 600);
}