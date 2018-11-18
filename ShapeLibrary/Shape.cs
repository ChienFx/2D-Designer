using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using IOLibrary;

namespace ShapeLibrary
{
    [Serializable]
    public abstract class Shape: ITransformer, IInputOutput, ICloneable
    {
        public Point mTopLeft;
        public Point mBottomRight;
        public float mAngle;
        protected Border mBorder;
        protected FillPattern mFillPattern;

        public Shape()
        {
            mTopLeft = new Point(0, 0);
            mBottomRight = new Point(0, 0);
            mBorder = new Border();
            mFillPattern = new FillPattern();
            mAngle = 0;
        }

        public Shape(Point topLeft, Point bottomRight)
        {
            mTopLeft = topLeft;
            mBottomRight = bottomRight;
            mBorder = new Border();
            mFillPattern = new FillPattern();
            mAngle = 0;
        }

        public PointF GetCenterOfBoundingBox()
        {
            return new PointF((mTopLeft.X + mBottomRight.X) / (float)2, (mTopLeft.Y + mBottomRight.Y) / (float)2);
        }

        public virtual bool IsSelected(Point mousePosition)
        {
            if (CreateRectangleWithTwoPoint(mTopLeft, mBottomRight).Contains(mousePosition))
                return true;
            return false;
        }

        //ITransformer Implementation
       
        //IInputOutput Implementation
        public abstract bool Load(string path, ulong offset);
        public abstract bool Save(string path, ulong offset);

        public abstract void Draw(Graphics graphics);

        public virtual void ShowBoundingBox(Graphics graphics)
        {
            TransformGraphic(graphics, mAngle);

            Pen pen = new Pen(Color.Black, 1);
            pen.DashPattern = BorderStyle.BORDER_STYLE_1.getValues();
            graphics.DrawRectangle(pen, CreateRectangleWithTwoPoint(mTopLeft, mBottomRight));
        }

        protected Rectangle CreateRectangleWithTwoPoint(Point topLeft, Point bottomRight)
        {
            int x = Math.Min(topLeft.X, bottomRight.X);
            int y = Math.Min(topLeft.Y, bottomRight.Y);
            int width = Math.Abs(bottomRight.X - topLeft.X);
            int height = Math.Abs(bottomRight.Y - topLeft.Y);
            return new Rectangle(x, y, width, height);
        }

        public Size getBoundingSize()
        {
            int x = Math.Min(mTopLeft.X, mBottomRight.X);
            int y = Math.Min(mTopLeft.Y, mBottomRight.Y);
            int width = Math.Abs(mBottomRight.X - mTopLeft.X);
            int height = Math.Abs(mBottomRight.Y - mTopLeft.Y);

            return new Size(width, height);
        }

        public abstract void Fill(Graphics graphics);

        public virtual void Rotate(float angle)
        {
            mAngle += angle;
            if (mAngle > 360)
                mAngle = 0;
            if (mAngle < 0)
                mAngle = 360;
            //Draw(graphics);
        }

        public virtual void Scale(float xRate, float yRate)
        {
            //Point fixedPoint = new Point(mTopLeft.X, (mTopLeft.Y + mBottomRight.Y) / 2);
            mTopLeft = CalculatePointAfterScale(mTopLeft, xRate, yRate, mTopLeft);
            mBottomRight = CalculatePointAfterScale(mBottomRight, xRate, yRate, mTopLeft);
            //Draw(graphics);
        }

        private Point CalculatePointAfterScale(Point p, float Sx, float Sy, Point fixedPoint)
        {
            Point result = new Point();
            result.X = (int)(p.X * Sx + fixedPoint.X * (1 - Sx));
            result.Y = (int)(p.Y * Sy + fixedPoint.Y * (1 - Sy));
            return result;
        }

        public virtual void Shift(int dx, int dy)
        {
            //Calculate new point
            mTopLeft = CalculatePointAfterShift(mTopLeft, dx, dy);
            mBottomRight = CalculatePointAfterShift(mBottomRight, dx, dy);
            //Draw(graphics);
        }

        private Point CalculatePointAfterShift(Point p, int dx, int dy)
        {
            Point result = new Point(p.X, p.Y);
            result.X += dx;
            result.Y += dy;
            return result;
        }

        public void setFillPattern(int index)
        {
            this.mFillPattern.setFillPattern(index);
        }

        public void setFillPattern(Brush brush)
        {
            throw new NotImplementedException();
        }

        protected void TransformGraphic(Graphics graphics, float angle)
        {
            Matrix matrix = new Matrix();
            matrix.RotateAt(angle, GetCenterOfBoundingBox());
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

        public void setFillPattern(FillPattern fillPattern)
        {
            this.mFillPattern.setFillPattern(fillPattern);
        }

        public virtual object Clone()
        {
            throw new NotImplementedException();
        }

        public void setForegroundColor(Color color)
        {
            this.mFillPattern.setForegroundColor(color);
        }

        public void setBackgroundColor(Color color)
        {
            this.mFillPattern.setBackgroundColor(color);
        }

        public Bitmap ExportToImage()
        {
            Size size = this.getBoundingSize();
            Bitmap bm = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            this.Shift(-mTopLeft.X, -mTopLeft.Y);
            this.Fill(g);
            this.Draw(g);
            g.Dispose();
            return bm;
        }
    }
}
