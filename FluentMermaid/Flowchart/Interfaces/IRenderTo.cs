namespace FluentMermaid.Flowchart.Interfaces;

public interface IRenderTo<in TTarget>
{
    void RenderTo(TTarget target);
}