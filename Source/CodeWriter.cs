//  Copyright (C) 2023 - Present John Roscoe Hamilton - All Rights Reserved
//  You may use, distribute and modify this code under the terms of the MIT license.
//  See the file License.txt in the root folder for full license details.

using System.Text;
using System.Text.RegularExpressions;

namespace WFCodeGen;

/// <summary>
/// Helper class for generating source code.
/// </summary>
public class CodeWriter
{
    int indentCount = 0;
    List<string> lines = new List<string>();
    string appendText = "";
    public string line
    {
        set
        {
            Add(value);
        }
    }
    public void Add(string value)
    {
        AddLines(appendText + value);
        appendText = "";
    }
    private void AddLine(string value)
    {
        int curIndentCount = indentCount;
        if (value == "}" || value == "};" || value == "},")
        {
            indentCount--;
            curIndentCount--;
        }
        if (value == "{")
        {
            indentCount++;
        }
        if (curIndentCount > 0)
        {
            string tabText = new string('\t', curIndentCount) + "";
            lines.Add(tabText + value);
        }
        else
        {
            lines.Add(value);
        }
    }

    public void AddLines(string linesAsString)
    {
        var result = GetLines(linesAsString);
        foreach (string line in result)
        {
            AddLine(line);
        }
    }
    public string[] GetLines(string linesAsString)
    {
        return Regex.Split(linesAsString, "\r\n|\r|\n");
    }
    public string append
    {
        set
        {
            appendText += value;
        }
    }
    public List<string> Lines
    {
        get
        {
            if (appendText.Length > 0)
                lines.Add(appendText);
            return lines;
        }
    }
    public void Clear()
    {
        lines.Clear();
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (string line in Lines)
        {
            sb.AppendLine(line);
        }
        return sb.ToString();
    }
}