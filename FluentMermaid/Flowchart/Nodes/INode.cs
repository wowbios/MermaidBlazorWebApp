﻿using System.Text;
using FluentMermaid.Flowchart.Enum;
using FluentMermaid.Flowchart.Render;

namespace FluentMermaid.Flowchart.Nodes;

public interface INode : IRenderTo<StringBuilder>
{
    string Id { get; }

    INode LinkTo(
        string text = "",
        int length = 1,
        Link linkType = Link.Arrow,
        params INode[] nodes);

    INode LinkFrom(
        string text = "",
        int length = 1,
        Link linkType = Link.Arrow,
        params INode[] nodes);

    INode ArrowTo(INode node);
    INode ArrowTo(INode node, string text);
    INode ArrowTo(params INode[] nodes);
    INode ArrowTo(string text, params INode[] nodes);
    INode ArrowFrom(INode node);
    INode ArrowFrom(INode node, string text);
    INode ArrowFrom(params INode[] nodes);
    INode ArrowFrom(string text, params INode[] nodes);
    INode OpenTo(INode node);
    INode OpenTo(INode node, string text);
    INode OpenTo(params INode[] nodes);
    INode OpenTo(string text, params INode[] nodes);
    INode OpenFrom(INode node);
    INode OpenFrom(INode node, string text);
    INode OpenFrom(params INode[] nodes);
    INode OpenFrom(string text, params INode[] nodes);
    INode DottedTo(INode node);
    INode DottedTo(INode node, string text);
    INode DottedTo(params INode[] nodes);
    INode DottedTo(string text, params INode[] nodes);
    INode DottedFrom(INode node);
    INode DottedFrom(INode node, string text);
    INode DottedFrom(params INode[] nodes);
    INode DottedFrom(string text, params INode[] nodes);
    INode ThickTo(INode node);
    INode ThickTo(INode node, string text);
    INode ThickTo(params INode[] nodes);
    INode ThickTo(string text, params INode[] nodes);
    INode ThickFrom(INode node);
    INode ThickFrom(INode node, string text);
    INode ThickFrom(params INode[] nodes);
    INode ThickFrom(string text, params INode[] nodes);
    INode CircleTo(INode node);
    INode CircleTo(INode node, string text);
    INode CircleTo(params INode[] nodes);
    INode CircleTo(string text, params INode[] nodes);
    INode CircleFrom(INode node);
    INode CircleFrom(INode node, string text);
    INode CircleFrom(params INode[] nodes);
    INode CircleFrom(string text, params INode[] nodes);
    INode CrossTo(INode node);
    INode CrossTo(INode node, string text);
    INode CrossTo(params INode[] nodes);
    INode CrossTo(string text, params INode[] nodes);
    INode CrossFrom(INode node);
    INode CrossFrom(INode node, string text);
    INode CrossFrom(params INode[] nodes);
    INode CrossFrom(string text, params INode[] nodes);
    INode CircleDoubleTo(INode node);
    INode CircleDoubleTo(INode node, string text);
    INode CircleDoubleTo(params INode[] nodes);
    INode CircleDoubleTo(string text, params INode[] nodes);
    INode CircleDoubleFrom(INode node);
    INode CircleDoubleFrom(INode node, string text);
    INode CircleDoubleFrom(params INode[] nodes);
    INode CircleDoubleFrom(string text, params INode[] nodes);
    INode ArrowDoubleTo(INode node);
    INode ArrowDoubleTo(INode node, string text);
    INode ArrowDoubleTo(params INode[] nodes);
    INode ArrowDoubleTo(string text, params INode[] nodes);
    INode ArrowDoubleFrom(INode node);
    INode ArrowDoubleFrom(INode node, string text);
    INode ArrowDoubleFrom(params INode[] nodes);
    INode ArrowDoubleFrom(string text, params INode[] nodes);
    INode CrossDoubleTo(INode node);
    INode CrossDoubleTo(INode node, string text);
    INode CrossDoubleTo(params INode[] nodes);
    INode CrossDoubleTo(string text, params INode[] nodes);
    INode CrossDoubleFrom(INode node);
    INode CrossDoubleFrom(INode node, string text);
    INode CrossDoubleFrom(params INode[] nodes);
    INode CrossDoubleFrom(string text, params INode[] nodes);
}