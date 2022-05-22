using System.Text;
using FluentMermaid.Flowchart.Enum;
using FluentMermaid.Flowchart.Extensions;
using FluentMermaid.Flowchart.Interfaces;

namespace FluentMermaid.Flowchart.Nodes;

internal sealed record TextNode(
    IGraph Graph,
    string Id,
    string Text,
    Shape Shape)
    : Node(Graph, Id)
{
    public override void RenderTo(StringBuilder target)
        => target
            .Append(Id)
            .Append(Shape.RenderStart())
            .Append('"')
            .WriteEscaped(Text)
            .Append('"')
            .AppendLine(Shape.RenderEnd());
}