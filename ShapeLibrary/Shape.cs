using System;
using System.Drawing;
using IOLibrary;

namespace ShapeLibrary
{
    public abstract class Shape: ITransformer, InterfaceIO
    {
        public Point mTopLeft;
        public Point mBottomRight;
        public float mRadian;


        public abstract bool Load(string path, ulong offset);
        public abstract bool Save(string path, ulong offset);
        public abstract void Draw(ref Bitmap bitmap, DrawStyle drawStyle);
        public abstract void Paint(ref Bitmap bitmap, PaintStyle paintStyle);
        public abstract void Rotate(ref Bitmap bitmap, float radian);
        public abstract void Scale(ref Bitmap bitmap, int xRate, int yRate);
        public abstract bool CheckShapeContainPoint(Point point);
        public abstract void Shift(ref Bitmap bitmap, Point newPosition);
    }
}
