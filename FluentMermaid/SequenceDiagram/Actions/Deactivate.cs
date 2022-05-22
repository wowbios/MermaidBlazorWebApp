using System.Text;
using FluentMermaid.SequenceDiagram.Interfaces;

namespace FluentMermaid.SequenceDiagram.Actions;

internal record Deactivate(IMember Member) : IAction
{
    public void RenderTo(StringBuilder builder)
    {
        builder
            .Append("deactivate ")
            .AppendLine(Member.Id);
    }
}