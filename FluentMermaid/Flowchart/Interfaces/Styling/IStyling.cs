namespace FluentMermaid.Flowchart.Interfaces.Styling;

public interface IStyling : INode
{
    void Set(INode node, string css);

    void Set(INode node, IStylingClass stylingClass);

    IStylingClass AddClass(string css);
}