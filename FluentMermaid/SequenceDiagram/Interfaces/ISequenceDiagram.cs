using System.Text;
using FluentMermaid.SequenceDiagram.Enum;

namespace FluentMermaid.SequenceDiagram.Interfaces;

public interface ISequenceDiagram
{
    IMember AddMember(string name, MemberType type);

    void Message(IMember from, IMember to, string text, MessageType type);

    IActivation Activate(IMember member);

    ILoop Loop(string title);

    void Note(IMember member, NoteLocation location, string text);

    void NoteOver(string text, params IMember[] members);

    string Render();
}