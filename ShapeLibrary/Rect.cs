using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Rect : Shape
    {
        public Rect() : base() { }
        public Rect(Point topLeft, Point bottomRight) : base(topLeft, bottomRight) { }

        public override void Draw(Graphics graphics)
        {
            TransformGraphic(graphics, mAngle);

            graphics.DrawRectangle(mBorder.createPen(), CreateRectangleWithTwoPoint(mTopLeft, mBottomRight));
        }

        public override void Fill(Graphics graphics)
        {
            TransformGraphic(graphics, mAngle);

            graphics.FillRectangle(mFillPattern.createBrush(), CreateRectangleWithTwoPoint(mTopLeft, mBottomRight));
        }

        public override object Clone()
        {
            Rect result = new Rect();

            result.mAngle = mAngle;
            result.mBorder = new Border(mBorder);
            result.mFillPattern = mFillPattern;
            result.mTopLeft = new Point(mTopLeft.X, mTopLeft.Y);
            result.mBottomRight = new Point(mBottomRight.X, mBottomRight.Y);

            return result;
        }
    }
}
