﻿using System;
using System.Drawing;
using ShapeLibrary;

namespace _2DDesigner
{
    enum ShapeType
    {
        DEFAULT,
        LINE,
        ELLIPSE,
        PARABOLA,
        TRIANGLE,
        RECTANGLE,
        SQUARE,
        CIRCLE,
        CHAR,
        BEZIER
    }

    internal class ShapeFactory
    {
        internal static Shape CreateShape(ShapeType shapeType, Point topLeft, Point bottomRight)
        {
            switch (shapeType)
            {
                case ShapeType.LINE:
                    return new Line(topLeft, bottomRight);
                case ShapeType.ELLIPSE:
                    return new Ellipse(topLeft, bottomRight);
                case ShapeType.PARABOLA:
                    return new Parabola(topLeft, bottomRight);
                case ShapeType.TRIANGLE:
                    return new Triangle(topLeft, bottomRight);
                case ShapeType.RECTANGLE:
                    return new Rect(topLeft, bottomRight);
                case ShapeType.SQUARE:
                    bottomRight.Y = topLeft.Y + (bottomRight.X - topLeft.X); 
                    return new Rect(topLeft, bottomRight);
                case ShapeType.CIRCLE:
                    bottomRight.Y = topLeft.Y + (bottomRight.X - topLeft.X);
                    return new Ellipse(topLeft, bottomRight);
                case ShapeType.BEZIER:
                    return new Bezier(topLeft, bottomRight);
                default:
                    return new Line(topLeft, bottomRight);
            }
        }
    }
}