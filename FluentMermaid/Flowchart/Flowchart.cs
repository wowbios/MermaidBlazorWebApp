using System.Text;
using FluentMermaid.Flowchart.Enum;
using FluentMermaid.Flowchart.Extensions;
using FluentMermaid.Flowchart.Nodes;
using FluentMermaid.Flowchart.Render;

namespace FluentMermaid.Flowchart;

public class Flowchart : IRenderTo<StringBuilder>
{
    private Flowchart(Orientation orientation)
    {
        Orientation = orientation;
    }
    
    public Orientation Orientation { get; }

    internal HashSet<INode> Nodes { get; } = new();
    
    internal HashSet<Relation> Relations { get; } = new();

    public static Flowchart Create(Orientation orientation)
        => new(orientation);

    public INode TextNode(string content, Shape shape)
    {
        TextNode textNode = new(this, CreateNodeId(), content, shape);
        Nodes.Add(textNode);
        return textNode;
    }

    public void Link(INode from, INode to, Link link, string text)
    {
        Relation relation = new(from, to, link, text);
        Relations.Add(relation);
    }

    public string Render()
    {
        StringBuilder builder = new();
        RenderTo(builder);
        return builder.ToString();
    }

    private string CreateNodeId() => "id" + Nodes.Count;

    public void RenderTo(StringBuilder builder)
    {
        builder.Append("flowchart ");
        builder.AppendLine(Orientation.Render());

        foreach (INode node in Nodes)
            node.RenderTo(builder);

        foreach (Relation relation in Relations)
            relation.RenderTo(builder);
    }
}
