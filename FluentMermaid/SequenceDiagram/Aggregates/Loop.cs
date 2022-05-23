using FluentMermaid.SequenceDiagram.Interfaces;

namespace FluentMermaid.SequenceDiagram.Aggregates;

internal record Loop : ILoop
{
    private readonly SequenceDiagram _sequenceDiagram;

    public Loop(
        SequenceDiagram sequenceDiagram,
        string title)
    {
        _sequenceDiagram = sequenceDiagram;
        _sequenceDiagram.LoopStart(title);
        Title = title;
    }
    
    public string Title { get; }
    
    public void Dispose()
        => _sequenceDiagram.LoopEnd();
}