using FluentMermaid.Flowchart.Enum;

namespace FluentMermaid.Flowchart.Interfaces;

public interface IFlowChart : IGraph
{
    Orientation Orientation { get; }

    void CallbackFunction(INode node, string functionName);

    void CallbackFunctionCall(INode node, string functionCall);

    string Render();
}