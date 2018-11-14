using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Style
    {
        protected Color mForeground;

        public void setForegroundColor(Color color)
        {
            mForeground = color;
        }

    }

    public class Border : Style
    {
        float mWeight;//độ dày
        BorderStyle mBorderStyle;

        public Border(Color foreground, float weight, BorderStyle borderStyle )
        {
            mForeground = foreground; mWeight = weight; mBorderStyle = borderStyle;
        }

        public Border()
        {
            mForeground = MyColor.DEFUALT_SHAPE_BORDER_COLOR;
            mWeight = 2;
            mBorderStyle = BorderStyle.BORDER_STYLE_0;
        }

        public Pen createPen()
        {
            Pen pen = new Pen(this.mForeground, this.mWeight);
            pen.DashPattern = this.getDashValues();
            return pen;
        }

        public Border(Border border)
        {
            this.mForeground = border.mForeground;
            this.mBorderStyle = border.mBorderStyle;
            this.mWeight = border.mWeight;
        }

        public Color getColor()
        {
            return this.mForeground;
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
            this.mForeground = color;
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
            this.mForeground = border.mForeground;
            this.mWeight = border.mWeight;
            this.mBorderStyle = border.mBorderStyle;
        }
    }

    public class FillPattern : Style
    {
        Color mBackground;
        Brush mBrush;

        public void setFillPattern(Brush brush)
        {
            this.mBrush = brush;
        }



        public FillPattern(Brush brush, Color foregroundColor, Color backgroundColor)
        {
            mBrush = brush;
            mForeground = foregroundColor;
            mBackground = backgroundColor;
        }

        public FillPattern()
        {
            mBackground = Color.Transparent;
            mForeground = MyColor.DEFAULT_SHAPE_FILL_COLOR;
            mBrush = new SolidBrush(mForeground);
        }

        public void setBackgroundColor(Color color)
        {
            this.mBackground = color;
        }

        public void setBrush(Brush brush)
        {
            this.mBrush = brush;
        }

        public Brush getBrush()
        {
            return mBrush;
        }

    }
}
public class BrushStyle
{
    public static Brush Solid = new SolidBrush(Color.Aqua);
    public static Brush BackwardDiagonal = new HatchBrush(HatchStyle.BackwardDiagonal, Color.Aqua, Color.Beige);
    public static Brush Cross = new HatchBrush(HatchStyle.Cross, Color.Aqua, Color.Beige);
    public static Brush DarkDownwardDiagonal = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.Aqua, Color.Beige);
    public static Brush DarkHorizontal = new HatchBrush(HatchStyle.DarkHorizontal, Color.Aqua, Color.Beige);
    public static Brush DashedDownwardDiagonal = new HatchBrush(HatchStyle.DashedDownwardDiagonal, Color.Aqua, Color.Beige);
    public static Brush DiagonalBrick = new HatchBrush(HatchStyle.DiagonalBrick, Color.Aqua, Color.Beige);
    public static Brush DiagonalCross = new HatchBrush(HatchStyle.DiagonalCross, Color.Aqua, Color.Beige);
    public static Brush Divot = new HatchBrush(HatchStyle.Divot, Color.Aqua, Color.Beige);
    public static Brush DottedGrid = new HatchBrush(HatchStyle.DottedGrid, Color.Aqua, Color.Beige);
    public static Brush LargeConfetti = new HatchBrush(HatchStyle.LargeConfetti, Color.Aqua, Color.Beige);


    public static int amount = 11;

    public static Brush getBrush(int index)
    {
        switch (index)
        {
            case 0: return Solid;
            case 1: return BackwardDiagonal;
            case 2: return Cross;
            case 3: return DarkDownwardDiagonal;
            case 4: return DarkHorizontal;
            case 5: return DashedDownwardDiagonal;
            case 6: return DiagonalBrick;
            case 7: return DiagonalCross;
            case 8: return Divot;
            case 9: return DottedGrid;
            case 10: return LargeConfetti;

            default: return Solid;
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
    public static BorderStyle BORDER_STYLE_7 = new BorderStyle(new float[] { 1, 2, 1, 3 });


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
