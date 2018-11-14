using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
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

            Pen pen = new Pen(mBorder.getColor(), mBorder.getWeight());
            pen.DashPattern = this.mBorder.getDashValues();

            int x = Math.Min(mTopLeft.X, mBottomRight.X);
            int y = Math.Min(mTopLeft.Y, mBottomRight.Y);
            Rectangle rectangle = new Rectangle(x, y, Math.Abs(mBottomRight.X - mTopLeft.X), Math.Abs(mBottomRight.Y - mTopLeft.Y));

            graphics.DrawEllipse(pen, rectangle);

            TransformGraphic(graphics, -mAngle);
        }

        public override void Fill(Graphics graphics)
        {
            TransformGraphic(graphics, mAngle);

            HatchBrush hatchBrush = new HatchBrush(HatchStyle.SolidDiamond, Color.Red, Color.Blue);

            graphics.FillEllipse(hatchBrush, new Rectangle(mTopLeft.X, mTopLeft.Y, mBottomRight.X, mBottomRight.Y));

            TransformGraphic(graphics, -mAngle);
        }
    }
}
