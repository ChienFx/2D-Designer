using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ShapeLibrary
{
    [Serializable]
    public class Line : Shape
    {
        public Line() : base() { }
        public Line(Point topLeft, Point bottomRight) : base(topLeft, bottomRight) { }

        public override bool IsSelected(Point mousePosition)
        {
            if (base.IsSelected(mousePosition))
            {
                int a = mBottomRight.X - mTopLeft.X;
                int b = mBottomRight.Y - mTopLeft.Y;
                int x = mousePosition.X - mTopLeft.X;
                int y = mousePosition.Y - mTopLeft.Y;
                double result = (b * x - a * y) / Math.Sqrt(a * a + b * b);
                return (result <= 10) && (result >= -10);
            }
            return false;
        }

        public override void Draw(Graphics graphics)
        { 
            TransformGraphic(graphics, mAngle);

            graphics.DrawLine(mBorder.createPen(), this.mTopLeft, this.mBottomRight);
        }

        public override void Fill(Graphics graphics)
        {
            
        }

        public override object Clone()
        {
            Line result = new Line();

            result.mAngle = mAngle;
            result.mBorder = new Border(mBorder);
            result.mFillPattern = mFillPattern;
            result.mTopLeft = new Point(mTopLeft.X, mTopLeft.Y);
            result.mBottomRight = new Point(mBottomRight.X, mBottomRight.Y);

            return result;
        }

        public override void ShowBoundingBox(Graphics graphics)
        {
            
        }
    }
}
