using System.Text;
using FluentMermaid.Flowchart.Enum;
using FluentMermaid.Flowchart.Extensions;
using FluentMermaid.Flowchart.Nodes;
using FluentMermaid.Flowchart.Render;

namespace FluentMermaid.Flowchart;

internal record Relation : IRenderTo<StringBuilder>
{
    internal Relation(
        INode @from,
        INode to,
        Link link,
        string text)
    {
        From = @from;
        To = to;
        Text = text;
        Link = link;
    }

    public INode From { get; }
    
    public INode To { get; }
    
    public Link Link { get; }
    
    public string Text { get; }
    
    public void RenderTo(StringBuilder builder)
    {
        builder.Append(From.Id)
            .Append(' ')
            .Append(Link.Render())
            .Append(' ');

        if (!string.IsNullOrEmpty(Text))
        {
            builder
                .Append('|')
                .Append(Text)
                .Append('|')
                .Append(' ');
        }
        builder.AppendLine(To.Id);
    }
}