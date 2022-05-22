using FluentMermaid.SequenceDiagram.Interfaces;

namespace FluentMermaid.SequenceDiagram.Aggregates;

internal record Activation : IActivation
{
    public Activation(
        IMember member,
        SequenceDiagram sequenceDiagram)
    {
        Member = member;
        SequenceDiagram = sequenceDiagram;

        SequenceDiagram.ActivateMember(member);
    }

    public IMember Member { get; }

    public SequenceDiagram SequenceDiagram { get; }
    
    public void Dispose()
    {
        SequenceDiagram.DeactivateMember(Member);
    }
}