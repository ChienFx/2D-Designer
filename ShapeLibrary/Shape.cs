using System;
using System.Drawing;
using IOLibrary;

namespace ShapeLibrary
{
    [Serializable]
    public abstract class Shape: ITransformer, IInputOutput
    {
        public Point mTopLeft;
        public Point mBottomRight;
        public float mRadian;
        protected Border mBorder;
        protected FillPattern mFillPattern;
        
        public Shape()
        {
            mBorder = new Border();
        }

        public virtual bool IsSelected(Point mousePosition)
        {
            int x = mousePosition.X;
            int y = mousePosition.Y;
            if (x >= mTopLeft.X
                && x <= mBottomRight.X
                && y >= mTopLeft.Y
                && y <= mBottomRight.Y)
                return true;
            return false;
        }

        //ITransformer Implementation
       
        //IInputOutput Implementation
        public abstract bool Load(string path, ulong offset);
        public abstract bool Save(string path, ulong offset);

        public abstract void Draw(Graphics graphics);
        public abstract void Fill(Graphics graphics);
        public abstract void Rotate(Graphics graphics);
        public abstract void Scale(Graphics graphics, int xRate, int yRate);
        public abstract void Shift(Graphics graphics, Point newPosition);

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
