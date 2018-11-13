using System.Drawing;

namespace ShapeLibrary
{
    public interface ITransformer
    {
        void Draw(Graphics graphics);
        void Fill(Graphics graphics);
        void Rotate(Graphics graphics);
        void Scale(Graphics graphics, int xRate, int yRate);
        void Shift(Graphics graphics, Point newPosition);
    }
}