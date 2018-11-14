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

            int x = Math.Min(mTopLeft.X, mBottomRight.X);
            int y = Math.Min(mTopLeft.Y, mBottomRight.Y);
            Rectangle rectangle = new Rectangle(x, y, Math.Abs(mBottomRight.X - mTopLeft.X), Math.Abs(mBottomRight.Y - mTopLeft.Y));

            graphics.DrawEllipse(mBorder.createPen(), rectangle);

            TransformGraphic(graphics, -mAngle);
        }

        public override void Fill(Graphics graphics)
        {
            TransformGraphic(graphics, mAngle);

            int x = Math.Min(mTopLeft.X, mBottomRight.X);
            int y = Math.Min(mTopLeft.Y, mBottomRight.Y);
            Rectangle rectangle = new Rectangle(x, y, Math.Abs(mBottomRight.X - mTopLeft.X), Math.Abs(mBottomRight.Y - mTopLeft.Y));


            Brush brush = this.mFillPattern.getBrush();
            graphics.FillEllipse(brush, rectangle);

            TransformGraphic(graphics, -mAngle);
        }
    }
}
