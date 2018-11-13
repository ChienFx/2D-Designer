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
        float mWeight;//độ dày
        BorderStyle mBorderStyle;

        public Border(Color color, float weight, BorderStyle borderStyle )
        {
            mColor = color; mWeight = weight; mBorderStyle = borderStyle;
        }

        public Border()
        {
            mColor = Color.Black;
            mWeight = 2;
            mBorderStyle = BorderStyle.BORDER_STYLE_0;
        }

        public Border(Border border)
        {
            this.mColor = border.mColor;
            this.mBorderStyle = border.mBorderStyle;
            this.mWeight = border.mWeight;
        }

        public Color getColor()
        {
            return this.mColor;
        }

        public float getWeight()
        {
            return this.mWeight;
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

        public void setBorder(float weight)
        {
            this.mWeight = weight;
        }

        public void setBorder(BorderStyle borderStyle)
        {
            this.mBorderStyle = borderStyle;
        }

        public void setBorder(Border border)
        {
            this.mColor = border.mColor;
            this.mWeight = border.mWeight;
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

    public static BorderStyle BORDER_STYLE_0 = new BorderStyle(new float[] { 1 });
    public static BorderStyle BORDER_STYLE_1 = new BorderStyle(new float[] { 8, 8});
    public static BorderStyle BORDER_STYLE_2 = new BorderStyle(new float[] { 1, 3 });
    public static BorderStyle BORDER_STYLE_3 = new BorderStyle(new float[] { 1, 2});
    public static BorderStyle BORDER_STYLE_4 = new BorderStyle(new float[] { 1, 2, 1 });
    public static BorderStyle BORDER_STYLE_5 = new BorderStyle(new float[] { 1, 2, 3 });
    public static BorderStyle BORDER_STYLE_6 = new BorderStyle(new float[] { 1, 2, 3, 4 });
    public static BorderStyle BORDER_STYLE_7 = new BorderStyle(new float[] { 1, 2,1,3 });


    public static int AmountOfBorderStyle = 8;

    private BorderStyle(float[] values)
    {
        this.mValues = values;       
    }

    public float[] getValues()
    {
        return mValues;
    }

    public static BorderStyle getPattern(int index)
    {
        switch (index)
        {
            case 0: return BORDER_STYLE_0; 
            case 1: return BORDER_STYLE_1; 
            case 2: return BORDER_STYLE_2; 
            case 3: return BORDER_STYLE_3; 
            case 4: return BORDER_STYLE_4; 
            case 5: return BORDER_STYLE_5; 
            case 6: return BORDER_STYLE_6; 
            case 7: return BORDER_STYLE_7; 
            default: return BORDER_STYLE_0;
        }
    }
}
