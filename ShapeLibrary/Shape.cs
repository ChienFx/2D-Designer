using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using IOLibrary;

namespace ShapeLibrary
{
    [Serializable]
    public abstract class Shape: ITransformer, IInputOutput
    {
        public Point mTopLeft;
        public Point mBottomRight;
        public int mAngle;
        protected Border mBorder;
        protected FillPattern mFillPattern;
        
        public Shape()
        {
            mTopLeft = new Point(0, 0);
            mBottomRight = new Point(0, 0);
            mBorder = new Border();
            mAngle = 0;
        }

        public Shape(Point topLeft, Point bottomRight)
        {
            mTopLeft = topLeft;
            mBottomRight = bottomRight;
            mBorder = new Border();
            mAngle = 0;
        }

        public PointF GetCenter()
        {
            return new PointF((mTopLeft.X + mBottomRight.X) / (float)2, (mTopLeft.Y + mBottomRight.Y) / (float)2);
        }

        public virtual bool IsSelected(Point mousePosition)
        {
            int x = Math.Min(mTopLeft.X, mBottomRight.X);
            int y = Math.Min(mTopLeft.Y, mBottomRight.Y);

            Rectangle rectangle = new Rectangle(x, y, Math.Abs(mBottomRight.X - mTopLeft.X), Math.Abs(mBottomRight.Y - mTopLeft.Y));
            if (rectangle.Contains(mousePosition))
                return true;
            return false;
        }

        //ITransformer Implementation
       
        //IInputOutput Implementation
        public abstract bool Load(string path, ulong offset);
        public abstract bool Save(string path, ulong offset);

        public abstract void Draw(Graphics graphics);
        public abstract void Fill(Graphics graphics);

        public virtual void Rotate(Graphics graphics, int angle)
        {
            mAngle = angle;
            Draw(graphics);
        }

        public virtual void Scale(Graphics graphics, float xRate, float yRate)
        {
            //Point fixedPoint = new Point(mTopLeft.X, (mTopLeft.Y + mBottomRight.Y) / 2);
            mTopLeft = CalculatePointAfterScale(mTopLeft, xRate, yRate, mTopLeft);
            mBottomRight = CalculatePointAfterScale(mBottomRight, xRate, yRate, mTopLeft);
            Draw(graphics);
        }

        private Point CalculatePointAfterScale(Point p, float Sx, float Sy, Point fixedPoint)
        {
            Point result = new Point();
            result.X = (int)(p.X * Sx + fixedPoint.X * (1 - Sx));
            result.Y = (int)(p.Y * Sy + fixedPoint.Y * (1 - Sy));
            return result;
        }

        public virtual void Shift(Graphics graphics, int dx, int dy)
        {
            //Calculate new point
            mTopLeft = CalculatePointAfterShift(mTopLeft, dx, dy);
            mBottomRight = CalculatePointAfterShift(mBottomRight, dx, dy);

            Draw(graphics);
        }

        private Point CalculatePointAfterShift(Point p, int dx, int dy)
        {
            Point result = new Point(p.X, p.Y);
            result.X += dx;
            result.Y += dy;
            return result;
        }

        protected void TransformGraphic(Graphics graphics, int angle)
        {
            Matrix matrix = new Matrix();
            matrix.RotateAt(angle, GetCenter());
            graphics.Transform = matrix;
        }

        public void setBorder(Color color)
        {
            this.mBorder.setBorder(color);
        }

        public void setBorder(int thickness)
        {
            this.mBorder.setBorder(thickness);
        }

        public void setBorder(BorderStyle borderStyle)
        {
            this.mBorder.setBorder(borderStyle);
        }

        public void setBorder(Border border)
        {
            this.mBorder.setBorder(border);
        }
    }
}
