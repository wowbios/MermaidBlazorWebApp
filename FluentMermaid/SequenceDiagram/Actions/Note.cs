using System.Text;
using FluentMermaid.SequenceDiagram.Enum;
using FluentMermaid.SequenceDiagram.Extensions;
using FluentMermaid.SequenceDiagram.Interfaces;

namespace FluentMermaid.SequenceDiagram.Actions;

internal record Note(
    IMember Member,
    NoteLocation Location,
    string Text
    ) : IAction
{
    public void RenderTo(StringBuilder builder)
    {
        builder
            .Append("Note ")
            .Append(Location.Render())
            .Append(' ')
            .Append(Member.Id)
            .Append(':')
            .AppendLine(Text);
    }
}