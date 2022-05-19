namespace FluentMermaid.Flowchart.Render;

public interface IRenderTo<in TTarget>
{
    void RenderTo(TTarget target);
}