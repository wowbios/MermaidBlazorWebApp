using System.Text;
using FluentMermaid.SequenceDiagram.Enum;
using FluentMermaid.SequenceDiagram.Extensions;
using FluentMermaid.SequenceDiagram.Interfaces;

namespace FluentMermaid.SequenceDiagram;

internal record Member(
    string Id,
    string Name,
    MemberType Type) : IMember
{
    public void RenderTo(StringBuilder builder)
    {
        builder.Append(Type.Render())
            .Append(' ')
            .Append(Id)
            .Append(" as ")
            .AppendLine(Name);
    }
}