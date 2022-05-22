using System.Text;
using FluentMermaid.SequenceDiagram.Enum;
using FluentMermaid.SequenceDiagram.Extensions;
using FluentMermaid.SequenceDiagram.Interfaces;

namespace FluentMermaid.SequenceDiagram.Actions;

internal record Message(
    IMember From,
    IMember To,
    string Text,
    MessageType Type
) : IAction
{
    public void RenderTo(StringBuilder builder)
    {
        builder
            .Append(From.Id)
            .Append(Type.Render())
            .Append(To.Id)
            .Append(": ")
            .AppendLine(Text);
    }
}