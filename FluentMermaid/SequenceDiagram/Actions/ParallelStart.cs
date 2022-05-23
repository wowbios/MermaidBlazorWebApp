using System.Text;
using FluentMermaid.SequenceDiagram.Interfaces;

namespace FluentMermaid.SequenceDiagram.Actions;

internal record ParallelStart(string? Title, bool IsFirst) : IAction
{
    public void RenderTo(StringBuilder builder)
    {
        builder
            .Append(IsFirst ? "par " : "and ")
            .AppendLine(Title);
    }
}