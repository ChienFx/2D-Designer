using System;
using System.Drawing;

namespace ShapeLibrary
{
    [Serializable]
    public class Char : Shape
    {
        string text;
        Font font;
        Char() : base() { }

        public Char(Point topLeft, string text)
        {
            mTopLeft = topLeft;
            font = new Font("Arial", 16);
            this.text = text;

            SizeF size = new SizeF();
            Bitmap fakeBmp = new Bitmap(1, 1);
            using (Graphics g = Graphics.FromImage(fakeBmp))
            {
                size = g.MeasureString(text, font);
            }
            mBottomRight = new Point(mTopLeft.X + (int)Math.Round(size.Width, 0), mTopLeft.Y + (int)Math.Round(size.Height, 0));
        }

        public override void Scale(float xRate, float yRate)
        {
            
        }

        public override void Draw(Graphics graphics)
        {
            TransformGraphic(graphics, mAngle);

            graphics.DrawString(text, font, mFillPattern.createBrush(), mTopLeft);
        }

        public override void Fill(Graphics graphics)
        {
            
        }

        public override object Clone()
        {
            Char _char = new Char();
            _char.text = (string)text.Clone();
            _char.font = (Font)font.Clone();
            _char.mTopLeft = new Point(mTopLeft.X, mTopLeft.Y);
            _char.mBottomRight = new Point(mBottomRight.X, mBottomRight.Y);

            return _char;
        }
    }
}
