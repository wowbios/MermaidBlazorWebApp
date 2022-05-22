using System.Text;
using FluentMermaid.SequenceDiagram.Enum;
using FluentMermaid.SequenceDiagram.Extensions;
using FluentMermaid.SequenceDiagram.Interfaces;

namespace FluentMermaid.SequenceDiagram.Actions;

internal record NoteOver(
    IMember[] Members,
    string Text
) : IAction
{
    public void RenderTo(StringBuilder builder)
    {
        builder
            .Append("Note ")
            .Append(NoteLocation.Over.Render())
            .Append(' ')
            .AppendJoin(',', Members.Select(m => m.Id))
            .Append(':')
            .AppendLine(Text);
    }
}