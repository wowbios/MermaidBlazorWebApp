using System.Text;

namespace FluentMermaid.Flowchart.Interfaces;

public interface INode : IRenderTo<StringBuilder>
{
    string Id { get; }
}