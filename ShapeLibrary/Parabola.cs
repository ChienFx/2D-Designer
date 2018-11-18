using System;
using System.Drawing;

namespace ShapeLibrary
{
    [Serializable]
    public class Parabola : Shape
    {
        public Parabola() : base() { }
        public Parabola(Point topLeft, Point bottomRight) : base(topLeft, bottomRight) { }

        public override void Draw(Graphics graphics)
        {
            TransformGraphic(graphics, mAngle);

            Pen pen = new Pen(mBorder.getColor(), mBorder.getWeight());
            pen.DashPattern = this.mBorder.getDashValues();
            Point[] points = {mTopLeft, new Point((mTopLeft.X + mBottomRight.X) / 2, mBottomRight.Y), new Point(mBottomRight.X, mTopLeft.Y)};
            graphics.DrawCurve(pen, points);
        }

        public override void Fill(Graphics graphics)
        {
            
        }

        public override object Clone()
        {
            Parabola result = new Parabola();

            result.mAngle = mAngle;
            result.mBorder = new Border(mBorder);
            result.mFillPattern = mFillPattern;
            result.mTopLeft = new Point(mTopLeft.X, mTopLeft.Y);
            result.mBottomRight = new Point(mBottomRight.X, mBottomRight.Y);

            return result;
        }
    }
}
