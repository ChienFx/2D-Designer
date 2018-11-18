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
    public class Controller: ICloneable//, ITransformer
    {
        List<Shape> mShapes;
        List<Group> mGroups;
        List<TextBox> mLabels;
        public int mSelectedShapeIndex;
        int mSelectedGroupIndex;
        Shape copiedShape;
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

        public bool setBorder(Color color)
        {
            Shape ins = GetSelectedShape();
            if (ins != null)
            {
                ins.setBorder(color);
                ins.Draw(GetGraphics());
                border.setBorder(color);
                return true;
            }
            else
            {
                border.setBorder(color);
                return false;
            }
            
        }

        public bool setBorder(int weight)
        {
            Shape ins = GetSelectedShape();
            if (ins != null)
            {
                ins.setBorder(weight);
                border.setBorder(weight);
                return true;
            }
            else
            {
                border.setBorder(weight);
                return false;
            }
                
        }

        public bool setBorder(BorderStyle borderStyle)
        {
            Shape ins = GetSelectedShape();
            if (ins != null)
            {
                ins.setBorder(borderStyle);
                border.setBorder(borderStyle);
                return true;
            }
            else
            {
                border.setBorder(borderStyle);
                return false;
            }
                
            
        }

        public bool setFillPattern(int index)
        {
            Shape ins = GetSelectedShape();
            if (ins != null)
            {
                ins.setFillPattern(index);
                fillPattern.setFillPattern(index);
                return true;
            }
            else
            {
                fillPattern.setFillPattern(index);
                return false;
            }
            
        }

        public FillPattern GetFillPattern()
        {
            return fillPattern;
        }

        public Border GetBorder()
        {
            return new Border(border);
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

        public Bitmap getBitmap()
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

        public bool setFillForeground(Color color)
        {
            Shape ins = GetSelectedShape();
            if (ins != null)
            {
                ins.setForegroundColor(color);
                ins.Fill(GetGraphics());
                ins.Draw(GetGraphics());
                fillPattern.setForegroundColor(color);
                return true;
            }
            else
            {
                fillPattern.setForegroundColor(color);
                return false;
            }
        }

        private Graphics GetGraphics()
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            return graphics;
        }

        public void ShowBoundingBoxOfObject()
        {
            DrawAll();
            if (!(GetSelectedShape() is null))
                GetSelectedShape().ShowBoundingBox(GetGraphics());
        }

        public bool setFillBackground(Color color)
        {
            Shape ins = GetSelectedShape();
            if (ins != null)
            {
                ins.setBackgroundColor(color);
                ins.Fill(GetGraphics());
                ins.Draw(GetGraphics());
                fillPattern.setBackgroundColor(color);
                return true;
            }
            else
            {
                fillPattern.setBackgroundColor(color);
                return false;
            }
            
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
            mSelectedShapeIndex = index;
        }



        //Delete selected shape/group
        public Shape DeleteSelectedObject()
        {
            Shape result = null;
            if (mSelectedShapeIndex != -1)
            {
                result = mShapes[mSelectedShapeIndex];
                mShapes.RemoveAt(mSelectedShapeIndex);
            }
            return result;
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
            shape.Rotate(angle);
            return true;
        }

        //Scale the selected shape/group
        public bool ScaleObject(float xRatio, float yRatio)
        {
            Shape shape = GetSelectedShape();
            if (shape is null)
                return false;
            shape.Scale(xRatio, yRatio);
            return true;
        }

        //Shift the selected shape/group
        public bool ShiftObject(int dx, int dy)
        {
            Shape shape = GetSelectedShape();
            if (shape is null)
                return false;
            shape.Shift(dx, dy);
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
                mShapes = ser.shapes;
                mGroups = ser.groups;
                fillPattern = ser.fillPattern;
                border = ser.border;
                bitmap = ser.bitmap;
                mSelectedShapeIndex = ser.selectedShapeIndex;
                mSelectedGroupIndex = ser.selectedGroupIndex;
                objStreamDeSerialize.Close();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
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

                ser.shapes = mShapes;
                ser.groups = mGroups;
                ser.fillPattern = fillPattern;
                ser.border = border;
                ser.bitmap = bitmap;
                ser.selectedShapeIndex = mSelectedShapeIndex;
                ser.selectedGroupIndex = mSelectedGroupIndex;
                objBinaryFormatter.Serialize(objStream, ser);
                objStream.Close();

                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public void CopyBitmapToClipboard()
        {
            Clipboard.SetImage(bitmap);
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

        public void copySelectedShape()
        {
            Shape tmp = GetSelectedShape();
            if (tmp != null)
                copiedShape = (Shape)tmp.Clone();
        }

        public bool pasteCopiedShape()
        {
            if (copiedShape != null)
            {
                copiedShape.Shift(10, 10);
                Shape tmp = (Shape)copiedShape.Clone();
                addShape(tmp);
                return true;
            }
            return false;
        }

        public bool cutSelectedShape()
        {
            Shape tmp = DeleteSelectedObject();
            if (tmp != null)
            {
                copiedShape = tmp;
                return true;
            }
            return false;
        }

        public Shape getCopiedShape()
        {
            return copiedShape;
        }
    }
}
