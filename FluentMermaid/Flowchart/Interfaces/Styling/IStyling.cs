namespace FluentMermaid.Flowchart.Interfaces.Styling;

public interface IStyling : INode
{
    void Set(INode node, string css);

    void SetClass(INode node, IStylingClass stylingClass);

    void SetClass(INode node, string className);

    IStylingClass AddClass(string css);
}