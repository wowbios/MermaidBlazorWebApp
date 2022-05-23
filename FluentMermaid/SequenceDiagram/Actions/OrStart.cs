using System.Text;
using FluentMermaid.SequenceDiagram.Interfaces;

namespace FluentMermaid.SequenceDiagram.Actions;

internal record OrStart(string? Title) : IAction
{
    public void RenderTo(StringBuilder builder)
    {
        builder
            .Append("else ")
            .AppendLine(Title);
    }
}