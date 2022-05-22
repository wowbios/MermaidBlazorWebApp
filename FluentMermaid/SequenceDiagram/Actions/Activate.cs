using System.Text;
using FluentMermaid.SequenceDiagram.Interfaces;

namespace FluentMermaid.SequenceDiagram.Actions;

internal record Activate(IMember Member) : IAction
{
    public void RenderTo(StringBuilder builder)
    {
        builder
            .Append("activate ")
            .AppendLine(Member.Id);
    }
}