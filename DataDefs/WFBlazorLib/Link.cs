//  Copyright (C) 2023 - Present John Roscoe Hamilton - All Rights Reserved
//  You may use, distribute and modify this code under the terms of the MIT license.
//  See the file License.txt in the root folder for full license details.
namespace WFCodeGen;
public enum LinkType : byte { None, YouTube }
public partial class Link  : Record
{
    public string Title; 
    public string Desc;
    public RecID<LinkChannel>  ChannelID;
    public string Url;
    public string VideoRef;
    public string Tags;
}