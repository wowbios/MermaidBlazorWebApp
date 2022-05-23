using System.Collections.Immutable;
using System.Text;
using FluentMermaid.SequenceDiagram.Interfaces;

namespace FluentMermaid.SequenceDiagram.Actions;

internal record AltStart(string? Title) : IAction
{
    public void RenderTo(StringBuilder builder)
    {
        builder
            .Append("alt ")
            .AppendLine(Title);
    }
}