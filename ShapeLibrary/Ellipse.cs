using System;
using System.Drawing;

namespace ShapeLibrary
{
    [Serializable]
    public class Ellipse : Shape
    {
        public Ellipse() : base() { }
        public Ellipse(Point topLeft, Point bottomRight) : base(topLeft, bottomRight) { }

        public override bool IsSelected(Point mousePosition)
        {
            PointF center = GetCenterOfBoundingBox();
            double a = Math.Abs(center.X - mTopLeft.X);
            double b = Math.Abs(center.Y - mTopLeft.Y);
            double x = mousePosition.X - center.X;
            double y = mousePosition.Y - center.Y;
            double result = Math.Pow(x / a, 2) + Math.Pow(y / b, 2) - 1;
            return result <= 0;
        }

        public override void Draw(Graphics graphics)
        {
            TransformGraphic(graphics, mAngle);

            graphics.DrawEllipse(mBorder.createPen(), CreateRectangleWithTwoPoint(mTopLeft, mBottomRight));
        }

        public override void Fill(Graphics graphics)
        {
            TransformGraphic(graphics, mAngle);

            Brush brush = mFillPattern.createBrush();
            graphics.FillEllipse(brush, CreateRectangleWithTwoPoint(mTopLeft, mBottomRight));
        }

        public override object Clone()
        {
            Ellipse result = new Ellipse();

            result.mAngle = mAngle;
            result.mBorder = new Border(mBorder);
            result.mFillPattern = mFillPattern;
            result.mTopLeft = new Point(mTopLeft.X, mTopLeft.Y);
            result.mBottomRight = new Point(mBottomRight.X, mBottomRight.Y);

            return result;
        }
    }
}
