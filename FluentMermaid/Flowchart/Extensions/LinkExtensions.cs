using FluentMermaid.Flowchart.Enum;

namespace FluentMermaid.Flowchart.Extensions;

public static class LinkExtensions
{
    public static string Render(this Link link)
        => link switch
        {
            Link.Arrow => "-->",
            Link.Open => "---",
            Link.Dotted => "-.->",
            Link.Thick => "==>",
            Link.Circle => "--o",
            Link.Cross => "--x",
            Link.CircleDouble => "o--o",
            Link.ArrowDouble => "<-->",
            Link.CrossDouble => "x--x",
            _ => throw new ArgumentOutOfRangeException(nameof(link), link, null)
        };
}