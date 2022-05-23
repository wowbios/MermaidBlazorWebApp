using System.Text;
using FluentMermaid.SequenceDiagram.Actions;
using FluentMermaid.SequenceDiagram.Aggregates;
using FluentMermaid.SequenceDiagram.Enum;
using FluentMermaid.SequenceDiagram.Interfaces;

namespace FluentMermaid.SequenceDiagram;

public sealed class SequenceDiagram : ISequenceDiagram
{
    private readonly List<Member> _members = new();
    private readonly List<IAction> _actions = new();
    
    public IMember AddMember(string name, MemberType type)
    {
        var member = new Member(CreateMemberId(), name, type);
        _members.Add(member);
        return member;
    }

    public void Message(IMember from, IMember to, string text, MessageType type)
    {
        var message = new Message(from, to, text, type);
        _actions.Add(message);
    }

    public IActivation Activate(IMember member)
        => new Activation(member, this);

    public ILoop Loop(string title)
        => new Loop(this, title);

    public void Note(IMember member, NoteLocation location, string text)
        => _actions.Add(new Note(member, location, text));

    public void NoteOver(string text, params IMember[] members)
        => _actions.Add(new NoteOver(members, text));

    public string Render()
    {
        StringBuilder builder = new();
        builder.AppendLine("sequenceDiagram");
        _members.ForEach(m => m.RenderTo(builder));
        _actions.ForEach(a => a.RenderTo(builder));

        return builder.ToString();
    }

    internal void ActivateMember(IMember member)
        => _actions.Add(new Activate(member));
    
    internal void DeactivateMember(IMember member)
        => _actions.Add(new Deactivate(member));

    internal void LoopStart(string text)
        => _actions.Add(new StartLoop(text));

    internal void LoopEnd()
        => _actions.Add(new End());

    private string CreateMemberId() => "member" + _members.Count;
}