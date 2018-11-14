using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ShapeLibrary
{
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

            TransformGraphic(graphics, -mAngle);
        }

        public override void Fill(Graphics graphics)
        {
            throw new NotImplementedException();
        }
    }
}
