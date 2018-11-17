using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ControllerLibrary
{
    [Serializable]
    class SerializeProp
    {
        List<Shape> mShapes;
        List<Group> mGroups;

        int mSelectedShapeIndex;
        int mSelectedGroupIndex;

        FillPattern mFillPattern;

        Border mBorder;
        Bitmap mBitmap;

        public List<Shape> shapes
        {
            get { return mShapes; }
            set { mShapes = value; }
        }

        public List<Group> groups
        {
            get { return mGroups; }
            set { mGroups = value; }
        }

        public int selectedShapeIndex
        {
            get { return mSelectedShapeIndex; }
            set { mSelectedShapeIndex = value; }
        }

        public int selectedGroupIndex
        {
            get { return mSelectedGroupIndex; }
            set { mSelectedGroupIndex = value; }
        }

        public Border border
        {
            get { return mBorder; }
            set { mBorder = value; }
        }

        public FillPattern fillPattern
        {
            get { return mFillPattern; }
            set { mFillPattern = value; }
        }

        public Bitmap bitmap
        {
            get { return mBitmap; }
            set { mBitmap = value; }
        }

    }
}
