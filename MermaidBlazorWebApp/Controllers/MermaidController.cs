using FluentMermaid.Flowchart;
using FluentMermaid.Flowchart.Enum;
using FluentMermaid.Flowchart.Nodes;
using Microsoft.AspNetCore.Mvc;

namespace MermaidBlazorWebApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MermaidController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        var chart = FlowChart.Create(Orientation.TopToBottom);
        var cat = chart.TextNode("Cat", Shape.Circle);
        var dog = chart.TextNode("Dog", Shape.Trapezoid);
        
        var places = chart.SubGraph("Places", Orientation.LeftToRight);
        var house = places.TextNode("house", Shape.Cylinder);
        var outside = places.TextNode("outside", Shape.Cylinder);

        var rooms = places.SubGraph("Rooms", Orientation.TopToBottom);
        var kitchen = rooms.TextNode("Kitchen", Shape.RoundEdges);
        var bedroom = rooms.TextNode("Bedroom", Shape.RoundEdges);

        places.Link(rooms, house, Link.Arrow, "in");
        chart.Link(dog, bedroom, Link.Cross, "NOT ALLOWED");
        chart.Link(dog, outside, Link.Open, "prefers");
        
        chart.Link(cat, kitchen, Link.Open, "prefers");
        chart.Link(cat, bedroom, Link.Open, "ALLOWED");
        
        chart.Interaction.OnClick(cat, "alert", "CAT TOOLTIP");
        chart.Interaction.OnClickCall(dog, "alert(1)", "DOG TOolTop");
        chart.Interaction.Hyperlink(kitchen, new Uri("https://github.com"), "to git", HyperlinkTarget.Blank);
        
        return chart.Render();
    }
}