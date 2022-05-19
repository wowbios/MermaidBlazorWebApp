using System.Text;
using FluentMermaid.Flowchart.Enum;
using FluentMermaid.Flowchart.Extensions;

namespace FluentMermaid.Flowchart.Nodes;

internal record TextNode(
    Flowchart Chart,
    string Id,
    string Text,
    Shape Shape)
    : Node(Chart, Id)
{
    public override void RenderTo(StringBuilder target)
        => target
            .Append(Id)
            .Append(Shape.RenderStart())
            .Append(Text)
            .AppendLine(Shape.RenderEnd());
}