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
            Pen pen = new Pen(mBorder.getColor(), mBorder.getWeight());
            pen.DashPattern = this.mBorder.getDashValues();
            graphics.DrawLine(pen, this.mTopLeft, this.mBottomRight);
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
    }
}
