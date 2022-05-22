using System.Text;
using FluentMermaid.Flowchart.Enum;
using FluentMermaid.Flowchart.Extensions;
using FluentMermaid.Flowchart.Interfaces;

namespace FluentMermaid.Flowchart.Nodes;

internal class RootNode : IFlowChart
{
    internal RootNode(Orientation orientation)
    {
        Orientation = orientation;
    }
    
    public Orientation Orientation { get; }

    private HashSet<INode> Nodes { get; } = new();

    private HashSet<Relation> Relations { get; } = new();

    private List<(string id, bool isCall, string func)> Callbacks { get; } = new();

    public INode TextNode(string content, Shape shape)
    {
        TextNode textNode = new(this, CreateNodeId(), content, shape);
        Nodes.Add(textNode);
        return textNode;
    }

    public ISubGraph SubGraph(string title, Orientation orientation)
    {
        var subgraph = new SubGraphNode(CreateNodeId(), title, orientation);
        Nodes.Add(subgraph);
        return subgraph;
    }

    public void Link(
        INode from,
        INode to,
        Link link,
        string text,
        int length = 1)
    {
        if (length < 1)
            throw new ArgumentException("Link length should be more or equal 1", nameof(length));

        Relation relation = new(from, to, link, text, length);
        Relations.Add(relation);
    }

    public void CallbackFunction(INode node, string functionName)
    {
        if (string.IsNullOrWhiteSpace(functionName))
            throw new ArgumentException("Function name should not be null or empty", nameof(functionName));

        Callbacks.Add((node.Id, false, functionName));
    }

    public void CallbackFunctionCall(INode node, string functionCall)
    {
        if (string.IsNullOrWhiteSpace(functionCall))
            throw new ArgumentException("Function call should not be null or empty", nameof(functionCall));
        
        Callbacks.Add((node.Id, true, functionCall));
    }

    public string Render()
    {
        StringBuilder builder = new();
        builder.Append("flowchart ");
        builder.AppendLine(Orientation.Render());

        foreach (INode node in Nodes)
            node.RenderTo(builder);

        foreach (Relation relation in Relations)
            relation.RenderTo(builder);

        foreach ((string id, bool isCall, string func) in Callbacks)
        {
            builder.Append("click ")
                .Append(id)
                .Append(' ');
            if (isCall)
                builder.Append("call ");
            
            builder.AppendLine(func);
        }
        
        return builder.ToString();
    }

    private string CreateNodeId() => "id" + Nodes.Count;
}
