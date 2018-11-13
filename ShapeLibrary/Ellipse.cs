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
            graphics.DrawEllipse(pen, new Rectangle(mTopLeft.X, mTopLeft.Y, mBottomRight.X, mBottomRight.Y));

            TransformGraphic(graphics, -mAngle);
        }

        public override void Fill(Graphics graphics)
        {
            TransformGraphic(graphics, mAngle);

            graphics.FillEllipse(Brushes.Red, new Rectangle(mTopLeft.X, mTopLeft.Y, mBottomRight.X, mBottomRight.Y));

            TransformGraphic(graphics, -mAngle);
        }
    }
}
