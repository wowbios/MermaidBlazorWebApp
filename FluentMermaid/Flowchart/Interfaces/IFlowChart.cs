using System.Text;
using FluentMermaid.Flowchart.Enum;

namespace FluentMermaid.Flowchart.Interfaces;

public interface IFlowChart : IGraph
{
    Orientation Orientation { get; }

    string Render();
}