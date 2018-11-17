using System;
using System.Drawing;

namespace ShapeLibrary
{
    [Serializable]
    public class Ellipse : Shape
    {
        public Ellipse() : base() { }
        public Ellipse(Point topLeft, Point bottomRight) : base(topLeft, bottomRight) { }

        public override bool Load(string path, ulong offset)
        {
            throw new NotImplementedException();
        }

        public override bool Save(string path, ulong offset)
        {
            throw new NotImplementedException();
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
