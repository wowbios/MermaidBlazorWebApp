using FluentMermaid.Flowchart.Enum;

namespace FluentMermaid.Flowchart.Interfaces;

public interface IFlowChart : IGraph
{
    Orientation Orientation { get; }
    
    IInteraction Interaction { get; }

    string Render();
}