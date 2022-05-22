﻿using System.Text;
using FluentMermaid.Flowchart.Interfaces.Styling;

namespace FluentMermaid.Flowchart.Nodes.Styling;

public record StylingClass(
    string Id,
    string Style)
    : IStylingClass
{
    public void RenderTo(StringBuilder builder)
    {
        builder.Append("classDef ")
            .Append(Id)
            .Append(' ')
            .Append(Style)
            .AppendLine(";");
    }
}