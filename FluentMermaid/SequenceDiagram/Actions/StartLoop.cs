using System.Text;
using FluentMermaid.SequenceDiagram.Interfaces;

namespace FluentMermaid.SequenceDiagram.Actions;

internal record StartLoop(string Title) : IAction
{
    public void RenderTo(StringBuilder builder)
    {
        builder
            .Append("loop ")
            .AppendLine(Title);
    }
}