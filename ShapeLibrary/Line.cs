using System;
using System.Drawing;

namespace ShapeLibrary
{
    class Line : Shape
    {
        
        public override void Draw(ref Bitmap bitmap, DrawStyle drawStyle)
        {
            throw new NotImplementedException();
        }

        public override void Paint(ref Bitmap bitmap, PaintStyle paintStyle)
        {
            throw new NotImplementedException();
        }

        public override void Rotate(ref Bitmap bitmap, float radian)
        {
            throw new NotImplementedException();
        }

        public override void Scale(ref Bitmap bitmap, int xRate, int yRate)
        {
            throw new NotImplementedException();
        }

        public override void Shift(ref Bitmap bitmap, Point newPosition)
        {
            throw new NotImplementedException();
        }

        public override bool Load(string path, ulong offset)
        {
            throw new NotImplementedException();
        }

        public override bool Save(string path, ulong offset)
        {
            throw new NotImplementedException();
        }

        public override bool CheckShapeContainPoint(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
