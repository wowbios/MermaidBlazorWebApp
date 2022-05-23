using System.Text;
using FluentMermaid.Flowchart.Extensions;
using FluentMermaid.SequenceDiagram.Interfaces;

namespace FluentMermaid.SequenceDiagram;

internal class MemberLink : IRenderTo<StringBuilder>
{
    public MemberLink(IMember member, string label, Uri url)
    {
        if (string.IsNullOrWhiteSpace(label))
            throw new ArgumentException("Label should not be null or empty", nameof(label));
        
        Member = member;
        Label = label;
        Url = url;
    }

    public void RenderTo(StringBuilder builder)
    {
        builder
            .Append('\"')
            .WriteEscaped(Label)
            .Append("\": \"")
            .Append(Url)
            .Append('\"');
    }

    public IMember Member { get; }
    public string Label { get; }
    public Uri Url { get; }
}