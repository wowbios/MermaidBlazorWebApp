using System.Drawing;
using FluentMermaid.Flowchart;
using FluentMermaid.Flowchart.Enum;
using FluentMermaid.Flowchart.Nodes;
using FluentMermaid.SequenceDiagram;
using FluentMermaid.SequenceDiagram.Enum;
using FluentMermaid.SequenceDiagram.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MermaidBlazorWebApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MermaidController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return CreateSeqDiag();
    }

    private static string CreateSeqDiag()
    {
        var d = new SequenceDiagram();
        var alice = d.AddMember("Alice", MemberType.Actor);
        var bob = d.AddMember("Bob", MemberType.Participant);

        d.Rect(Color.Aqua, _ =>
            d.Message(alice, bob, "hi", MessageType.Solid));
            
        return d.Render();
    }

    private static string CreateFlowChart()
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
        
        chart.Styling.Set(cat, "fill: #bff");

        var myClass = chart.Styling.AddClass("color:#bff");
        chart.Styling.DefaultStyle = "color:pink,background-color:black";
        chart.Styling.SetClass(kitchen, myClass);
        chart.Styling.SetClass(outside, myClass);
        
        return chart.Render();
    }
}