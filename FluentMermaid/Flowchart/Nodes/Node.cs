using System.Text;
using FluentMermaid.Flowchart.Enum;

namespace FluentMermaid.Flowchart.Nodes;

internal abstract record Node : INode
{
    internal Node(Flowchart chart, string id)
    {
        if (string.IsNullOrWhiteSpace(id))
            throw new ArgumentException("Id should be not empty", nameof(id));

        Chart = chart ?? throw new ArgumentNullException(nameof(chart));
        Id = id;
    }
    
    public Flowchart Chart { get; }
    
    public string Id { get; }

    #region Arrow

    public abstract void RenderTo(StringBuilder builder);

    public INode ArrowTo(INode node)
        => ArrowTo(string.Empty, node);

    public INode ArrowTo(INode node, string text)
        => ArrowTo(text, node);

    public INode ArrowTo(params INode[] nodes)
        => ArrowTo(string.Empty, nodes);

    public INode ArrowTo(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(this, other, Link.Arrow, text);
        
        return this;
    }
    
    public INode ArrowFrom(INode node)
        => ArrowFrom(string.Empty, node);

    public INode ArrowFrom(INode node, string text)
        => ArrowFrom(text, node);

    public INode ArrowFrom(params INode[] nodes)
        => ArrowFrom(string.Empty, nodes);

    public INode ArrowFrom(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(other, this, Link.Arrow, text);
        
        return this;
    }
    
    #endregion
    
    #region Open
    public INode OpenTo(INode node)
        => OpenTo(string.Empty, node);

    public INode OpenTo(INode node, string text)
        => OpenTo(text, node);

    public INode OpenTo(params INode[] nodes)
        => OpenTo(string.Empty, nodes);

    public INode OpenTo(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(this, other, Link.Open, text);
        
        return this;
    }
    
    public INode OpenFrom(INode node)
        => OpenFrom(string.Empty, node);

    public INode OpenFrom(INode node, string text)
        => OpenFrom(text, node);

    public INode OpenFrom(params INode[] nodes)
        => OpenFrom(string.Empty, nodes);

    public INode OpenFrom(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(other, this, Link.Open, text);
        
        return this;
    }
    #endregion
    
    #region Dotted
    public INode DottedTo(INode node)
        => DottedTo(string.Empty, node);

    public INode DottedTo(INode node, string text)
        => DottedTo(text, node);

    public INode DottedTo(params INode[] nodes)
        => DottedTo(string.Empty, nodes);

    public INode DottedTo(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(this, other, Link.Dotted, text);
        
        return this;
    }
    
    public INode DottedFrom(INode node)
        => DottedFrom(string.Empty, node);

    public INode DottedFrom(INode node, string text)
        => DottedFrom(text, node);

    public INode DottedFrom(params INode[] nodes)
        => DottedFrom(string.Empty, nodes);

    public INode DottedFrom(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(other, this, Link.Dotted, text);
        
        return this;
    }
    #endregion
    
    #region Thick
    public INode ThickTo(INode node)
        => ThickTo(string.Empty, node);

    public INode ThickTo(INode node, string text)
        => ThickTo(text, node);

    public INode ThickTo(params INode[] nodes)
        => ThickTo(string.Empty, nodes);

    public INode ThickTo(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(this, other, Link.Thick, text);
        
        return this;
    }
    
    public INode ThickFrom(INode node)
        => ThickFrom(string.Empty, node);

    public INode ThickFrom(INode node, string text)
        => ThickFrom(text, node);

    public INode ThickFrom(params INode[] nodes)
        => ThickFrom(string.Empty, nodes);

    public INode ThickFrom(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(other, this, Link.Thick, text);
        
        return this;
    }
    #endregion
    
    #region Circle
    public INode CircleTo(INode node)
        => CircleTo(string.Empty, node);

    public INode CircleTo(INode node, string text)
        => CircleTo(text, node);

    public INode CircleTo(params INode[] nodes)
        => CircleTo(string.Empty, nodes);

    public INode CircleTo(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(this, other, Link.Circle, text);
        
        return this;
    }
    
    public INode CircleFrom(INode node)
        => CircleFrom(string.Empty, node);

    public INode CircleFrom(INode node, string text)
        => CircleFrom(text, node);

    public INode CircleFrom(params INode[] nodes)
        => CircleFrom(string.Empty, nodes);

    public INode CircleFrom(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(other, this, Link.Circle, text);
        
        return this;
    }
    #endregion
    
    #region Cross
    public INode CrossTo(INode node)
        => CrossTo(string.Empty, node);

    public INode CrossTo(INode node, string text)
        => CrossTo(text, node);

    public INode CrossTo(params INode[] nodes)
        => CrossTo(string.Empty, nodes);

    public INode CrossTo(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(this, other, Link.Cross, text);
        
        return this;
    }
    
    public INode CrossFrom(INode node)
        => CrossFrom(string.Empty, node);

    public INode CrossFrom(INode node, string text)
        => CrossFrom(text, node);

    public INode CrossFrom(params INode[] nodes)
        => CrossFrom(string.Empty, nodes);

    public INode CrossFrom(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(other, this, Link.Cross, text);
        
        return this;
    }
    #endregion
    
    #region CircleDouble
    public INode CircleDoubleTo(INode node)
        => CircleDoubleTo(string.Empty, node);

    public INode CircleDoubleTo(INode node, string text)
        => CircleDoubleTo(text, node);

    public INode CircleDoubleTo(params INode[] nodes)
        => CircleDoubleTo(string.Empty, nodes);

    public INode CircleDoubleTo(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(this, other, Link.CircleDouble, text);
        
        return this;
    }
    
    public INode CircleDoubleFrom(INode node)
        => CircleDoubleFrom(string.Empty, node);

    public INode CircleDoubleFrom(INode node, string text)
        => CircleDoubleFrom(text, node);

    public INode CircleDoubleFrom(params INode[] nodes)
        => CircleDoubleFrom(string.Empty, nodes);

    public INode CircleDoubleFrom(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(other, this, Link.CircleDouble, text);
        
        return this;
    }
    #endregion
    
    #region ArrowDouble
    public INode ArrowDoubleTo(INode node)
        => ArrowDoubleTo(string.Empty, node);

    public INode ArrowDoubleTo(INode node, string text)
        => ArrowDoubleTo(text, node);

    public INode ArrowDoubleTo(params INode[] nodes)
        => ArrowDoubleTo(string.Empty, nodes);

    public INode ArrowDoubleTo(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(this, other, Link.ArrowDouble, text);
        
        return this;
    }
    
    public INode ArrowDoubleFrom(INode node)
        => ArrowDoubleFrom(string.Empty, node);

    public INode ArrowDoubleFrom(INode node, string text)
        => ArrowDoubleFrom(text, node);

    public INode ArrowDoubleFrom(params INode[] nodes)
        => ArrowDoubleFrom(string.Empty, nodes);

    public INode ArrowDoubleFrom(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(other, this, Link.ArrowDouble, text);
        
        return this;
    }
    #endregion
    
    #region CrossDouble
    public INode CrossDoubleTo(INode node)
        => CrossDoubleTo(string.Empty, node);

    public INode CrossDoubleTo(INode node, string text)
        => CrossDoubleTo(text, node);

    public INode CrossDoubleTo(params INode[] nodes)
        => CrossDoubleTo(string.Empty, nodes);

    public INode CrossDoubleTo(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(this, other, Link.CrossDouble, text);
        
        return this;
    }
    
    public INode CrossDoubleFrom(INode node)
        => CrossDoubleFrom(string.Empty, node);

    public INode CrossDoubleFrom(INode node, string text)
        => CrossDoubleFrom(text, node);

    public INode CrossDoubleFrom(params INode[] nodes)
        => CrossDoubleFrom(string.Empty, nodes);

    public INode CrossDoubleFrom(string text, params INode[] nodes)
    {
        foreach (INode other in nodes)
            Chart.Link(other, this, Link.CrossDouble, text);
        
        return this;
    }
    #endregion
    
}