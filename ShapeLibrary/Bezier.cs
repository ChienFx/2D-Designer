using System;
using System.Collections.Generic;
using System.Drawing;

namespace ShapeLibrary
{
    [Serializable]
    public class Bezier : Shape
    {
        List<Point> points;
        public Bezier() : base() { points = new List<Point>();  }
        public Bezier(Point a, Point b) : base(a, b)
        {
            points = new List<Point>();
            points.Add(mTopLeft);
            points.Add(mBottomRight);
        }

        public override bool IsSelected(Point mousePoint)
        {
            return false;
        }

        public Bezier(List<Point> points)
        {
            this.points = points;
        }

        public void AddPoint(Point p)
        {
            points.Add(p);
        }

        public override void Draw(Graphics graphics)
        {
            TransformGraphic(graphics, mAngle);

            Pen pen = mBorder.createPen();

            int i = 0;
            for (; i + 3 < points.Count; i += 3)
                graphics.DrawBezier(pen, points[i], points[i + 1], points[i + 2], points[i + 3]);

            for (; i < points.Count; i++)
                graphics.DrawEllipse(pen, points[i].X - 2, points[i].Y - 2, 4, 4);
        }

        public override void Fill(Graphics graphics)
        {

        }

        public override object Clone()
        {
            Bezier result = new Bezier();

            result.mAngle = mAngle;
            result.mBorder = new Border(mBorder);
            result.mFillPattern = mFillPattern;

            result.points = new List<Point>();
            for (int i = 0; i < points.Count; i++)
                result.points.Add(new Point(points[i].X, points[i].Y));

            return result;
        }

        public override void ShowBoundingBox(Graphics graphics)
        {

        }
    }
}
