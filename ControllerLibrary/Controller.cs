using IOLibrary;
using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ControllerLibrary
{
    [Serializable]
    public class Controller:IInputOutput, ICloneable//, ITransformer
    {
        List<Shape> mShapes;
        List<Group> mGroups;
        public int mSelectedShapeIndex;
        int mSelectedGroupIndex;

        FillPattern fillPattern;
        Border border;

        Bitmap bitmap;

        //Graphics graphics;


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

        private Controller()
        {
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
            if (mSelectedShapeIndex < 0 || mSelectedShapeIndex == mShapes.Count - 1)
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
            if (mSelectedShapeIndex < 0 || mSelectedShapeIndex == mShapes.Count - 1)
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
        public Shape DetectWhichObjectIsSelected(Point mousePosition)
        {
            for (int i = mShapes.Count - 1; i >= 0; i--)
            {
                if (mShapes[i].IsSelected(mousePosition))
                {
                    mSelectedShapeIndex = i;
                    return mShapes[i];
                }
            }
            mSelectedShapeIndex = -1;
            return null;
        }

        public void setFillForeground(Color color)
        {
            fillPattern.setForegroundColor(color);
        }
        private Graphics GetGraphics()
        {
            return Graphics.FromImage(bitmap);
        }

        public void setFillBackground(Color color)
        {
            fillPattern.setBackgroundColor(color);
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


        public void addShape(Shape shape, int index = int.MaxValue)
        {
            shape.setFillPattern(fillPattern);
            shape.setBorder(border);
            if (index > mShapes.Count)
                index = mShapes.Count;
            mShapes.Insert(index, shape);
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
        public bool FillShape()
        {
            Shape shape = GetSelectedShape();
            if (shape is null)
                return false;
            shape.Fill(GetGraphics());
            return true;
        }

        

        //Rotate the selected shape/group
        public bool RotateObject(float angle)
        {
            Shape shape = GetSelectedShape();
            if (shape is null)
                return false;
            shape.Rotate(null, angle);
            return true;
        }

        //Scale the selected shape/group
        public bool ScaleObject(float xRatio, float yRatio)
        {
            Shape shape = GetSelectedShape();
            if (shape is null)
                return false;
            shape.Scale(null, xRatio, yRatio);
            return true;
        }

        //Shift the selected shape/group
        public bool ShiftObject(int dx, int dy)
        {
            Shape shape = GetSelectedShape();
            if (shape is null)
                return false;
            shape.Shift(GetGraphics(), dx, dy);
            return true;
        }

        //Zoom the monitor with ratio in range of 0-1 (default is 0.5)
        public void Zoom(float ratio)
        {

        }

        //---------------------------------------------------
        //                IO Implementations
        public bool Load(string path, ulong offset)
        {
            try
            {
                SerializeProp ser = new SerializeProp();
                Stream objStreamDeSerialize = new FileStream(path,
                      FileMode.Open,
                      FileAccess.Read,
                      FileShare.Read);
                IFormatter objBinaryFormatter = new BinaryFormatter();

                ser = (SerializeProp)objBinaryFormatter.Deserialize(objStreamDeSerialize);
                this.mShapes = ser.shapes;
                this.mGroups = ser.groups;
                this.fillPattern = ser.fillPattern;
                this.border = ser.border;
                this.bitmap = ser.bitmap;
                this.mSelectedShapeIndex = ser.selectedShapeIndex;
                this.mSelectedGroupIndex = ser.selectedGroupIndex;
                objStreamDeSerialize.Close();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public void SetSelectedShape(Shape tempShape)
        {
            mShapes[mSelectedShapeIndex].mTopLeft = new Point(tempShape.mTopLeft.X, tempShape.mTopLeft.Y);
            mShapes[mSelectedShapeIndex].mBottomRight = new Point(tempShape.mBottomRight.X, tempShape.mBottomRight.Y);
            mShapes[mSelectedShapeIndex].mAngle = tempShape.mAngle;
        }

        public bool Save(string path, ulong offset)
        {
            try
            {
                SerializeProp ser = new SerializeProp();
                IFormatter objBinaryFormatter = new BinaryFormatter();
                Stream objStream = new FileStream(path,
                      FileMode.Create,
                      FileAccess.ReadWrite,
                      FileShare.None);

                ser.shapes = this.mShapes;
                ser.groups = this.mGroups;
                ser.fillPattern = this.fillPattern;
                ser.border = this.border;
                ser.bitmap = this.bitmap;
                ser.selectedShapeIndex = this.mSelectedShapeIndex;
                ser.selectedGroupIndex = this.mSelectedGroupIndex;
                objBinaryFormatter.Serialize(objStream, ser);
                objStream.Close();

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
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

        public object Clone()
        {
            Controller cloner = new Controller();

            cloner.bitmap = (Bitmap)bitmap.Clone();
            cloner.mSelectedGroupIndex = mSelectedGroupIndex;
            cloner.mSelectedShapeIndex = mSelectedShapeIndex;
            cloner.border = new Border(border);
            cloner.mShapes = new List<Shape>();
            for (int i = 0; i < mShapes.Count; i++)
                cloner.mShapes.Add((Shape)mShapes[i].Clone());
            cloner.fillPattern = fillPattern;

            return cloner;
        }
    }
}
