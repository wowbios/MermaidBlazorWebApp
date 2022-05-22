using FluentMermaid.Flowchart;
using FluentMermaid.Flowchart.Enum;
using Microsoft.AspNetCore.Mvc;

namespace MermaidBlazorWebApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MermaidController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        var chart = Flowchart.Create(Orientation.RightToLeft);
        var animal = chart.TextNode("Animal", Shape.Hexagon);
        var cat = chart.TextNode("Cat #quot;\" < > #124;ss", Shape.Circle);
        var dog = chart.TextNode("Dog", Shape.Trapezoid);
        
        animal.ArrowFrom(cat, dog);
        cat.LinkTo("Cat #quot;\" < > #124;ss", 1, Link.Circle, dog);
        // cat.DoubleArrow(dog) ?

        return chart.Render();
    }
}