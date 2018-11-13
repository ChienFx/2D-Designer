using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Style
    {
        protected Color mColor;
    }

    public class Border : Style
    {
        float mThickness;//độ dày
        BorderStyle mBorderStyle;

        public Border(Color color, float thickness, BorderStyle borderStyle )
        {
            mColor = color; mThickness = thickness; mBorderStyle = borderStyle;
        }

        public Border()
        {
            mColor = Color.Black;
            mThickness = 1;
            mBorderStyle = BorderStyle.BORDER_SOLID;
        }

        public Border(Border border)
        {
            this.mColor = border.mColor;
            this.mBorderStyle = border.mBorderStyle;
            this.mThickness = border.mThickness;
        }

        public Color getColor()
        {
            return this.mColor;
        }

        public float getThickness()
        {
            return this.mThickness;
        }

        public BorderStyle getBorderStyle()
        {
            return this.mBorderStyle;
        }

        public float[] getDashValues()
        {
            return mBorderStyle.getValues();
        }


        public void setBorder(Color color)
        {
            this.mColor = color;
        }

        public void setBorder(float thickness)
        {
            this.mThickness = thickness;
        }

        public void setBorder(BorderStyle borderStyle)
        {
            this.mBorderStyle = borderStyle;
        }

        public void setBorder(Border border)
        {
            this.mColor = border.mColor;
            this.mThickness = border.mThickness;
            this.mBorderStyle = border.mBorderStyle;
        }
    }

    public class FillPattern : Style
    {
        public void SetDefault()
        {
            throw new NotImplementedException();
        }
    }
}

public class BorderStyle
{
    float[] mValues;
    public static BorderStyle BORDER_STYLE_1 = new BorderStyle(new float[]{ 1, 1} );
    public static BorderStyle BORDER_STYLE_2 = new BorderStyle(new float[] { 1, 2, 3, 2, 1 });
    public static BorderStyle BORDER_SOLID = new BorderStyle(new float[] { 1 });

    private BorderStyle(float[] values)
    {
        this.mValues = values;       
    }

    public float[] getValues()
    {
        return mValues;
    }

}
