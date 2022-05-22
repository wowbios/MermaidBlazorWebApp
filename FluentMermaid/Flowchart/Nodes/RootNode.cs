﻿using System.Text;
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

    public INode TextNode(string content, Shape shape)
    {
        TextNode textNode = new(this, CreateNodeId(), content, shape);
        Nodes.Add(textNode);
        return textNode;
    }

    public ISubGraph SubGraph(string title)
    {
        var subgraph = new SubGraphNode(CreateNodeId(), title);
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

    public string Render()
    {
        StringBuilder builder = new();
        builder.Append("flowchart ");
        builder.AppendLine(Orientation.Render());

        foreach (INode node in Nodes)
            node.RenderTo(builder);

        foreach (Relation relation in Relations)
            relation.RenderTo(builder);
        return builder.ToString();
    }

    private string CreateNodeId() => "id" + Nodes.Count;
}
