using System.Text;
using FluentMermaid.SequenceDiagram.Interfaces;

namespace FluentMermaid.SequenceDiagram.Actions;

internal record OptStart(string? Title) : IAction
{
    public void RenderTo(StringBuilder builder)
    {
        builder
            .Append("opt ")
            .AppendLine(Title);
    }
}