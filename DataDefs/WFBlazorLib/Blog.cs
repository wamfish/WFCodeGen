//  Copyright (C) 2023 - Present John Roscoe Hamilton - All Rights Reserved
//  You may use, distribute and modify this code under the terms of the MIT license.
//  See the file License.txt in the root folder for full license details.
namespace WFCodeGen;
public partial class Blog : Record
{
    public string Title;
    public string Html;
    public string Tags;
    public bool IsPublished;
    public DateTime StartDate;
    public DateTime StopDate;
}