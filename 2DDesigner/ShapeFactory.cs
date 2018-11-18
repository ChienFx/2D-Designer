using System;
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
        RECTANGLE
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
                default:
                    return new Line(topLeft, bottomRight);
            }
        }
    }
}