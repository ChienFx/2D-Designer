using IOLibrary;
using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ControllerLibrary
{
    public class Controller:IInputOutput//, ITransformer
    {
        List<Shape> mShapes;
        List<Group> mGroups;
        int mSelectedShapeIndex;
        int mSelectedGroupIndex;

        FillPattern fillPattern;
        Border border;

        Bitmap bitmap;

        public Controller(int width, int height)
        {
            mShapes = new List<Shape>();
            mGroups = new List<Group>();
            mSelectedShapeIndex = -1;
            mSelectedGroupIndex = -1;
            
            border = new Border();
            fillPattern = new FillPattern();
 
            bitmap = new Bitmap(width, height);
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

        public void setBorder(Color color)
        {
            Shape ins = GetSelectedShape();
            if (ins != null)
                ins.setBorder(color);
            else
                this.border.setBorder(color);
        }

        public void setBorder(int weight)
        {
            Shape ins = GetSelectedShape();
            if (ins != null)
                ins.setBorder(weight);
            else
                this.border.setBorder(weight);
        }

        public void setBorder(BorderStyle borderStyle)
        {
            Shape ins = GetSelectedShape();
            if (ins != null)
                ins.setBorder(borderStyle);
            else
                this.border.setBorder(borderStyle);
        }

        public void setFillPattern(int index)
        {
            Shape ins = GetSelectedShape();
            if (ins != null)
                ins.setFillPattern(index);
            else
                this.fillPattern.setFillPattern(index);
        }

       

        //Send selected shape/group to back
        public void SendObjectToBack()
        {
            if (mSelectedShapeIndex <= 0)
                return;
            Shape temp = GetSelectedShape();
            DeleteSelectedObject();
            mShapes.Insert(0, temp);
            mSelectedShapeIndex = 0;
        }

        //Send selected shape/group to forward
        public void SendObjectToForward()
        {
            if (mSelectedShapeIndex <= 0 || mSelectedShapeIndex == mShapes.Count - 1)
                return;
            Shape temp = GetSelectedShape();
            DeleteSelectedObject();
            mShapes.Insert(mSelectedShapeIndex + 1, temp);
            mSelectedShapeIndex++;
        }

        //Send selected shape/group to backward
        public void SendObjectToBackward()
        {
            if (mSelectedShapeIndex <= 0)
                return;
            Shape temp = GetSelectedShape();
            DeleteSelectedObject();
            mShapes.Insert(mSelectedShapeIndex - 1, temp);
            mSelectedShapeIndex--;
        }

        //Send selected shape/group to front
        public void SendObjectToFront()
        {
            if (mSelectedShapeIndex <= 0 || mSelectedShapeIndex == mShapes.Count - 1)
                return;
            Shape temp = GetSelectedShape();
            DeleteSelectedObject();
            mShapes.Add(temp);
            mSelectedShapeIndex = mShapes.Count - 1;
        }

        public Image getBitmap()
        {
            return bitmap;
        }




        //Find with shape or group is selected by mouse click
        public bool DetectWhichObjectIsSelected(Point mousePosition)
        {
            for (int i = mShapes.Count - 1; i >= 0; i--)
            {
                if (mShapes[i].IsSelected(mousePosition))
                {
                    mSelectedShapeIndex = i;
                    return true;
                }
            }
            mSelectedShapeIndex = -1;
            return false;
        }

        public void setFillForeground(Color color)
        {
            throw new NotImplementedException();
        }
        private Graphics GetGraphics()
        {
            return Graphics.FromImage(bitmap);
        }

        //Draw all shapes
        public void DrawAll()
        {
            GetGraphics().Clear(Color.White);
            for (int i = 0; i < mShapes.Count; i++)
            {
                mShapes[i].Fill(GetGraphics());
                mShapes[i].Draw(GetGraphics());
            }
        }

        public void addShape(Shape shape)
        {
            shape.setFillPattern(fillPattern);
            shape.setBorder(border);
            mShapes.Add(shape);
        }

        

        //Delete selected shape/group
        public void DeleteSelectedObject()
        {
            if (mSelectedShapeIndex != -1)
                mShapes.RemoveAt(mSelectedShapeIndex);
        }

        //Change selected object's border style (redraw)
        public void ChangeObjectBorderStyle()
        {

        }

        //Fill the shape (no group) with the given pattern
        public void FillShape()
        {
            Shape shape = GetSelectedShape();
            if (shape is null)
                return;
            shape.Fill(GetGraphics());
        }

        

        //Rotate the selected shape/group
        public void RotateObject(int angle)
        {
            Shape shape = GetSelectedShape();
            if (shape is null)
                return;
            shape.Rotate(GetGraphics(), angle);
        }

        //Scale the selected shape/group
        public void ScaleObject(float xRatio, float yRatio)
        {
            Shape shape = GetSelectedShape();
            if (shape is null)
                return;
            shape.Scale(GetGraphics(), xRatio, yRatio);
        }

        //Shift the selected shape/group
        public void ShiftObject(int dx, int dy)
        {
            Shape shape = GetSelectedShape();
            if (shape is null)
                return;
            shape.Shift(GetGraphics(), dx, dy);
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

        public void CopyBitmapToClipboard()
        {
            Clipboard.SetImage(bitmap);
        }

        public Bitmap ExportToBitmap()
        {
            throw new NotImplementedException();
        }
    }
}
