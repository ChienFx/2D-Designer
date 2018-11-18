using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Triangle : Shape
    {
        Point a;

        public Triangle() : base() { a = new Point(0, 0);  }
        public Triangle(Point a, Point b, Point c) : base(b, c) { this.a = a; }
        public Triangle(Point topLeft, Point bottomRight) : base(topLeft, bottomRight)
        {
            a = new Point((topLeft.X + bottomRight.X) / 2, topLeft.Y);
        }


        public override bool IsSelected(Point mousePosition)
        {
            Point b = new Point(mTopLeft.X, mBottomRight.Y);
            Point c = mBottomRight;

            return Acreage(a, b, mousePosition) + Acreage(a, c, mousePosition) + Acreage(b, c, mousePosition) - Acreage(a, b, c) <= 0.5; 
        }

        private double Acreage(Point a, Point b, Point c)
        {
            double x = Distance(a, b);
            double y = Distance(a, c);
            double z = Distance(b, c);
            double q = (x + y + z) / 2;
            return Math.Sqrt(q * (q - x) * (q - y) * (q - z));
        }

        private double Distance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        public override void Draw(Graphics graphics)
        {
            TransformGraphic(graphics, mAngle);

            Point[] points = {a,  new Point(mTopLeft.X, mBottomRight.Y), mBottomRight };
            graphics.DrawPolygon(mBorder.createPen(), points);
        }

        public override void Fill(Graphics graphics)
        {
            TransformGraphic(graphics, mAngle);

            Point[] points = { new Point(mTopLeft.X, mBottomRight.Y), a, mBottomRight };
            graphics.FillPolygon(mFillPattern.createBrush(), points);
        }

        public override void ShowBoundingBox(Graphics graphics)
        {
            base.ShowBoundingBox(graphics);
        }

        public override object Clone()
        {
            Triangle result = new Triangle();

            result.mAngle = mAngle;
            result.mBorder = new Border(mBorder);
            result.mFillPattern = mFillPattern;
            result.mTopLeft = new Point(mTopLeft.X, mTopLeft.Y);
            result.mBottomRight = new Point(mBottomRight.X, mBottomRight.Y);
            result.a = new Point(a.X, a.Y);

            return result;
        }

        public override void Scale(float xRate, float yRate)
        {
            base.Scale(xRate, yRate);
            a = CalculatePointAfterScale(a, xRate, yRate, mTopLeft);
        }

        public override void Shift(int dx, int dy)
        {
            base.Shift(dx, dy);
            a = CalculatePointAfterShift(a, dx, dy);
        }

    }
}
