using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    [Serializable]
    public class Style
    {
        protected Color mForeground;

        public void setForegroundColor(Color color)
        {
            mForeground = color;
        }

    }

    [Serializable]
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

    [Serializable]
    public class FillPattern : Style
    {
        Color mBackground;

        private EBrushType mBrushType;
        public static int mAmount = 11;

        public void setFillPattern(int index)
        {
            mBrushType = (EBrushType)index;
        }

        
        public FillPattern(EBrushType brushType, Color foregroundColor, Color backgroundColor)
        {
            this.mBrushType = brushType;
            mForeground = foregroundColor;
            mBackground = backgroundColor;
        }

        public FillPattern()
        {
            mBackground = Color.Transparent;
            mForeground = MyColor.DEFAULT_SHAPE_FILL_COLOR;
            mBrushType = EBrushType.Solid;
        }

        public FillPattern(Color black)
        {
            mBackground = Color.Transparent;
            mForeground = black;
            mBrushType = EBrushType.Solid;
        }

        public void setBackgroundColor(Color color)
        {
            this.mBackground = color;
        }

        public Brush createBrush()
        {
            return createBrush((int)this.mBrushType);
        }

        public Brush createBrush(int id)
        {
            switch ((EBrushType)id)
            {
                
                case EBrushType.BackwardDiagonal:
                    return new HatchBrush(HatchStyle.BackwardDiagonal, mForeground, mBackground);

                case EBrushType.Cross:
                    return new HatchBrush(HatchStyle.Cross, mForeground, mBackground);

                case EBrushType.DarkDownwardDiagonal:
                    return new HatchBrush(HatchStyle.DarkDownwardDiagonal, mForeground, mBackground);

                case EBrushType.DarkHorizontal:
                    return new HatchBrush(HatchStyle.DarkHorizontal, mForeground, mBackground);

                case EBrushType.DashedDownwardDiagonal:
                    return new HatchBrush(HatchStyle.DashedDownwardDiagonal, mForeground, mBackground);

                case EBrushType.DiagonalBrick:
                    return new HatchBrush(HatchStyle.DiagonalBrick, mForeground, mBackground);

                case EBrushType.DiagonalCross:
                    return new HatchBrush(HatchStyle.DiagonalCross, mForeground, mBackground);

                case EBrushType.Divot:
                    return new HatchBrush(HatchStyle.Divot, mForeground, mBackground);

                case EBrushType.DottedGrid:
                    return new HatchBrush(HatchStyle.DottedGrid, mForeground, mBackground);

                case EBrushType.LargeConfetti:
                    return new HatchBrush(HatchStyle.LargeConfetti, mForeground, mBackground);

                default:
                    return new SolidBrush(mForeground);

            }
        }

        internal void setFillPattern(FillPattern fillPattern)
        {
            mForeground = fillPattern.mForeground;
            mBackground = fillPattern.mBackground;
            mBrushType = fillPattern.mBrushType;
        }
    }
}
public enum EBrushType
{

     Solid = 0,
     BackwardDiagonal = 1,// new HatchBrush(HatchStyle.BackwardDiagonal, Color.Aqua, Color.Beige);
     Cross = 2, // new HatchBrush(HatchStyle.Cross, Color.Aqua, Color.Beige);
     DarkDownwardDiagonal = 3,// new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.Aqua, Color.Beige);
     DarkHorizontal = 4,// new HatchBrush(HatchStyle.DarkHorizontal, Color.Aqua, Color.Beige);
     DashedDownwardDiagonal = 5,// new HatchBrush(HatchStyle.DashedDownwardDiagonal, Color.Aqua, Color.Beige);
     DiagonalBrick = 6,// new HatchBrush(HatchStyle.DiagonalBrick, Color.Aqua, Color.Beige);
     DiagonalCross = 7,// = new HatchBrush(HatchStyle.DiagonalCross, Color.Aqua, Color.Beige);
     Divot = 8,// = new HatchBrush(HatchStyle.Divot, Color.Aqua, Color.Beige);
     DottedGrid = 9,// = new HatchBrush(HatchStyle.DottedGrid, Color.Aqua, Color.Beige);
     LargeConfetti = 10// = new HatchBrush(HatchStyle.LargeConfetti, Color.Aqua, Color.Beige);


    

    //public static int getBrush(int index)
    //{
    //    switch (index)
    //    {
    //        case 0: return Solid;
    //        case 1: return BackwardDiagonal;
    //        case 2: return Cross;
    //        case 3: return DarkDownwardDiagonal;
    //        case 4: return DarkHorizontal;
    //        case 5: return DashedDownwardDiagonal;
    //        case 6: return DiagonalBrick;
    //        case 7: return DiagonalCross;
    //        case 8: return Divot;
    //        case 9: return DottedGrid;
    //        case 10: return LargeConfetti;

    //        default: return Solid;
    //    }
    //}


}

[Serializable]
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
