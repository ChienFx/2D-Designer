using System.Drawing;

namespace ShapeLibrary
{
    public interface ITransformer
    {
        void Draw(Graphics graphics);
        void Fill(Graphics graphics);
        void Rotate(Graphics graphics, int angle);
        void Scale(Graphics graphics, float xRate, float yRate);
        void Shift(Graphics graphics, int dx, int dy);
    }
}