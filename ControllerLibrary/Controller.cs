using IOLibrary;
using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using Point = ShapeLibrary.Point;

namespace ControllerLibrary
{
    public class Controller:IInputOutput//, ITransformer
    {
        List<Shape> mShapes;
        List<Group> mGroups;
        int mSelectedShapeIndex;
        int mSelectedGroupIndex;

        FillPattern fillPattern;
        BorderStyle borderStyle;

        Bitmap mBitmap;

        public Controller()
        {
            mShapes = new List<Shape>();
            mGroups = new List<Group>();
            mSelectedShapeIndex = -1;
            mSelectedGroupIndex = -1;

            fillPattern.SetDefault();
            borderStyle.SetDefault();

            mBitmap = new Bitmap(FormSize.BITMAP_WIDTH, FormSize.WINDOW_HEIGHT);
        }


        public Shape GetSelectedShape()
        {
            if (mSelectedShapeIndex >= 0 && mSelectedShapeIndex < mShapes.Count)
                return mShapes[mSelectedShapeIndex];
            else
                return null;
        }
        public Group GetSelectedGroup()
        {
            if (mSelectedGroupIndex >= 0 && mSelectedGroupIndex < mGroups.Count)
                return mGroups[mSelectedGroupIndex];
            else
                return null;
        }


        //Send selected shape/group to back
        public void SendObjectToBack()
        {
           
        }
        //Send selected shape/group to forward
        public void SendObjectToForward()
        {
            
        }

        //Send selected shape/group to backward
        public void SendObjectToBackward()
        {
        
        }

        //Send selected shape/group to front
        public void SendObjectToFront()
        {
            
        }

        


        //Find with shape or group is selected by mouse click
        public void DetectWhichObjectIsSelected(Point point)
        {
         
        }

        //Draw all shapes
        public void DrawAll()
        {

        }

        //Delete selected shape/group
        public void DeleteSelectedObject()
        {

        }

        //Change selected object's border style (redraw)
        public void ChangeObjectBorderStyle()
        {

        }

        //Fill the shape (no group) with the given pattern
        public void fillShape()
        {

        }

        //Rotate the selected shape/group
        public void RotateObject(float radian)
        {

        }

        //Scale the selected shape/group
        public void ScaleObject(int xRatio, int yRatio)
        {

        }

        //Shift the selected shape/group
        public void ShiftObject(Point newPoint)
        {

        }

        //Undo the last step
        public void Undo()
        {

        }

        //Redo the last step
        public void Redo()
        {

        }

        //Zoom the monitor with ratio in range of 0-1 (default is 0.5)
        public void Zoom(float ratio)
        {

        }






        //---------------------------------------------------
        //                IO Implementations
        public bool Load(string path, ulong offset)
        {
            throw new NotImplementedException();
        }

        public bool Save(string path, ulong offset)
        {
            throw new NotImplementedException();
        }

        public bool SaveAs(string newName, string path, ulong offset)
        {
            throw new NotImplementedException();
        }

        public bool CopyBitmapToClipboard()
        {
            throw new NotImplementedException();
        }

        public Bitmap ExportToBitmap()
        {
            throw new NotImplementedException();
        }



    }
}
