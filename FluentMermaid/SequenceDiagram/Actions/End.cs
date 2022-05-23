using System.Text;
using FluentMermaid.SequenceDiagram.Interfaces;

namespace FluentMermaid.SequenceDiagram.Actions;

internal record End : IAction
{
    public void RenderTo(StringBuilder builder)
        => builder.AppendLine("end");
}