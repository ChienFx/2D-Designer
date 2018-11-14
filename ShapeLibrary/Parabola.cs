﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Parabola : Shape
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
            Point[] points = {mTopLeft, new Point((mTopLeft.X + mBottomRight.X) / 2, mBottomRight.Y), new Point(mBottomRight.X, mTopLeft.Y)};
            graphics.DrawCurve(pen, points);

            TransformGraphic(graphics, -mAngle);
        }

        public override void Fill(Graphics graphics)
        {
            
        }
    }
}