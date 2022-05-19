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
        var chart = Flowchart.Create(Orientation.TopToBottom);
        var animal = chart.TextNode("Animal", Shape.Hexagon);
        var cat = chart.TextNode("Cat", Shape.Circle);
        var dog = chart.TextNode("Dog", Shape.Trapezoid);
        
        animal.ArrowFrom(cat, dog);
        cat.ArrowTo(dog);
        dog.ArrowTo(cat);
        // cat.DoubleArrow(dog) ?

        return chart.Render();
    }
}