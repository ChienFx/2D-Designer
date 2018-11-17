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

            int x = Math.Min(mTopLeft.X, mBottomRight.X);
            int y = Math.Min(mTopLeft.Y, mBottomRight.Y);
            Rectangle rectangle = new Rectangle(x, y, Math.Abs(mBottomRight.X - mTopLeft.X), Math.Abs(mBottomRight.Y - mTopLeft.Y));

            graphics.DrawEllipse(mBorder.createPen(), rectangle);
        }

        public override void Fill(Graphics graphics)
        {
            TransformGraphic(graphics, mAngle);

            int x = Math.Min(mTopLeft.X, mBottomRight.X);
            int y = Math.Min(mTopLeft.Y, mBottomRight.Y);
            Rectangle rectangle = new Rectangle(x, y, Math.Abs(mBottomRight.X - mTopLeft.X), Math.Abs(mBottomRight.Y - mTopLeft.Y));

            Brush brush = mFillPattern.createBrush();
            graphics.FillEllipse(brush, rectangle);
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
