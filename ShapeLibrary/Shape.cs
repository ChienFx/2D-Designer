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

        public virtual bool IsSelected(Point mousePosition)
        {
            int x = mousePosition.getX();
            int y = mousePosition.getY();
            if (x >= mTopLeft.getX()
                && x <= mBottomRight.getX()
                && y >= mTopLeft.getY()
                && y <= mBottomRight.getY())
                return true;
            return false;
        }

        //ITransformer Implementation
        public abstract void Draw(BorderStyle borderStyle);
        public abstract void Fill(FillPattern fillPattern);
        public abstract void Rotate(float radian);
        public abstract void Scale(int xRate, int yRate);
        public abstract void Shift(Point newPosition);

        //IInputOutput Implementation
        public abstract bool Load(string path, ulong offset);
        public abstract bool Save(string path, ulong offset);
    }
}
