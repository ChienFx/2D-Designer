using System;
using System.Drawing;

namespace ShapeLibrary
{
    public class Line : Shape
    {
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
            Pen pen = new Pen(mBorder.getColor(), mBorder.getWeight());
            pen.DashPattern = this.mBorder.getDashValues();
            graphics.DrawLine(pen, this.mTopLeft, this.mBottomRight);
        }

        public override void Fill(Graphics graphics)
        {
            throw new NotImplementedException();
        }

        public override void Rotate(Graphics graphics)
        {
            throw new NotImplementedException();
        }

        public override void Scale(Graphics graphics, int xRate, int yRate)
        {
            throw new NotImplementedException();
        }

        public override void Shift(Graphics graphics, Point newPosition)
        {
            throw new NotImplementedException();
        }
    }
}
