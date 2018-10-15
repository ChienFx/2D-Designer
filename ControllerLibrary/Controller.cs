using IOLibrary;
using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using Point = ShapeLibrary.Point;

namespace ControllerLibrary
{
    public class Controller:InterfaceIO
    {
        List<Shape> mList;
        int  mIndex;
        PaintStyle mPaintStyle;
        DrawStyle mDrawStyle;
        Bitmap mBitmap;

        public Controller()
        {
            mList = new List<Shape>();
            mIndex = -1;
            mPaintStyle.SetDefault();
            mDrawStyle.SetDefault();
            mBitmap = new Bitmap(FormSize.BITMAP_WIDTH, FormSize.WINDOW_HEIGHT);
        }

        public Shape GetSelectedShape()
        {
            if (mIndex >= 0 && mIndex < mList.Count)
                return mList[mIndex];
            else
                return null;
        }

        public void SendSelectedShapeToBack()
        {
            Shape tmp = GetSelectedShape();
            if (tmp!=null)
            {
                mList.RemoveAt(mIndex);
                mList.Insert(0, tmp);
                mIndex = 0;
            }
        }

        public void SendSelectedShapeToForward()
        {
            Shape tmp = GetSelectedShape();
            if (tmp != null)
            {
                mList.RemoveAt(mIndex);
                mList.Insert(mList.Count,tmp);
                mIndex = 0;
            }
        }


        public Shape GetShapeContainPoint(Point point)
        {
            for (int i = 0; i < mList.Count; i++)
                if (mList[i].CheckShapeContainPoint(point) == true)
                    return mList[i];
            return null;
        }

        public void Draw()
        {
            if (GetSelectedShape() != null)
                GetSelectedShape().Draw(ref mBitmap, mDrawStyle);
        }

        public bool Load(string path, ulong offset)
        {
            throw new NotImplementedException();
        }

        public void Paint()
        {
            throw new NotImplementedException();
        }

        public void Rotate()
        {
            if (GetSelectedShape() != null)
            {
                float radian = 0.4f;
                GetSelectedShape().Rotate(ref mBitmap, radian);
            }
                
        }

        public bool Save(string path, ulong offset)
        {
            throw new NotImplementedException();
        }

        public void Scale()
        {
            if (GetSelectedShape() != null)
            {
                int xRate = 10;
                int yRate = 12;
                GetSelectedShape().Scale(ref mBitmap, xRate, yRate);
            }
                
        }

        public void Shift()
        {
            if (GetSelectedShape() != null)
            {
                Point newPosition = new Point(10, 10);
                GetSelectedShape().Shift(ref mBitmap, newPosition);
            }
        }
    }
}
