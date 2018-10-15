using System.Drawing;

namespace ShapeLibrary
{
    public interface ITransformer
    {
        void Draw(ref Bitmap bitmap, DrawStyle drawStyle);
        void Paint(ref Bitmap bitmap, PaintStyle paintStyle);
        void Rotate(ref Bitmap bitmap, float radian);
        void Scale(ref Bitmap bitmap, int xRate, int yRate);
        void Shift(ref Bitmap bitmap, Point newPosition);
    }
}