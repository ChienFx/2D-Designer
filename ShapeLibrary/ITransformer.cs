using System.Drawing;

namespace ShapeLibrary
{
    public interface ITransformer
    {
        void Draw(Graphics graphics);
        void ShowBoundingBox(Graphics graphics);
        void Fill(Graphics graphics);
        void Rotate(float angle);
        void Scale(float xRate, float yRate);
        void Shift(int dx, int dy);
    }
}