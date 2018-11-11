using System.Drawing;

namespace ShapeLibrary
{
    public interface ITransformer
    {
        void Draw(BorderStyle borderStyle);
        void Fill(FillPattern fillPattern);
        void Rotate(float radian);
        void Scale(int xRate, int yRate);
        void Shift(Point newPosition);
    }
}