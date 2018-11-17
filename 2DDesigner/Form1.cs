using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using ControllerLibrary;
using ShapeLibrary;

namespace _2DDesigner
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Controller controller;
        //public Shape shape;
        public Monitor monitor;
        State state;
        Point start;
        ShapeType shapeType;
        bool isMouseHold = false;
        bool isSaved = false;

        Stack<Controller> undoList = new Stack<Controller>();
        Stack<Controller> redoList = new Stack<Controller>();

        string path_Save = null;

        public Form()
        {
            InitializeComponent();
            monitor = new Monitor(this);
            controller = new Controller(pictureBox.Width, pictureBox.Height);
            start = new Point(0, 0);
            state = State.DEFAULT;
            shapeType = ShapeType.DEFAULT;

            this.FormClosing += Form_FormClosing;

        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                DialogResult res = MessageBox.Show(this, "Do you want to save this project?", "Save & Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    e.Cancel = !this.SaveProject();
                }
                else if (res == DialogResult.No)
                {
                    DialogResult res2 = MessageBox.Show(this, "Your project will be loss!\nContinue Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    e.Cancel = (res2 == DialogResult.No);
                }
                else
                    e.Cancel = true;
            }
            DisposeResources();
                
        }

        private void DisposeResources()
        {
            if(pictureBox!=null)
                pictureBox.Dispose();

            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnShapePicker.Image = Properties.Resources.line;
            btnBorderColorPicker.BackColor = MyColor.DEFUALT_SHAPE_BORDER_COLOR;
            btnFillBgPicker.BackColor = MyColor.DEFAULT_BACKGROUND;
            btnFillForePicker.BackColor = MyColor.DEFAULT_SHAPE_FILL_COLOR;
            setSaveState(true);
            shapePickerPanel.Visible = false;
            layerPanel.Visible = false;
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ungroupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox_Click(object sender, EventArgs e)
        {
            HideShapePickerPanel();
            HideLayerPanel();
        }

        void setSaveState(bool flag)
        {
            isSaved = flag;
            this.Text = "2D Designner ";
            if (path_Save != null)
                this.Text += " - " + path_Save;
            if (!isSaved)
            {
                this.Text += "*";
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            //Push state into undo stack
            undoList.Push((Controller)controller.Clone());
            setSaveState(false);//unSaved
            redoList.Clear();

            switch (state)
            {
                case State.MOVE:
                case State.ROTATE:
                case State.FILL:
                case State.SCALE:
                    UnSelectedShape();
                    break;
                case State.DRAW:
                    Shape shape = ShapeFactory.CreateShape(shapeType, start, new Point(e.X, e.Y));
                    controller.addShape(shape);
                    controller.DrawAll();
                    UpdateUI();
                    break;
            }
            isMouseHold = false;
        }

        private void UnSelectedShape()
        {
            controller.DetectWhichObjectIsSelected(new Point(-1, -1));
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            switch (state)
            {
                case State.MOVE:
                case State.ROTATE:
                case State.SCALE:
                case State.FILL:
                case State.HAND_VIEW:
                    tempShape = ObjectExtensions.Copy(controller.DetectWhichObjectIsSelected(new Point(e.X, e.Y)));
                    break;
                case State.DRAW:
                    break;
            }
            isMouseHold = true;
            start = new Point(e.X, e.Y);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseHold)
            {
                switch (state)
                {
                    case State.MOVE:
                        HandlingMoveObjectEvent(new Point(e.X, e.Y));
                        break;
                    case State.SCALE:
                        HandlingScaleObjectEvent(new Point(e.X, e.Y));
                        break;
                    case State.ROTATE:
                        HandlingRotateObjectEvent(new Point(e.X, e.Y));
                        break;
                    case State.FILL:
                        HandlingFillObjectEvent();
                        break;
                    case State.DRAW:
                        HandlingDrawObjectEven(new Point(e.X, e.Y));
                        break;
                }
            }
        }

        private void HandlingFillObjectEvent()
        {
            controller.FillShape();
            controller.DrawAll();
            UpdateUI();
        }
        
        private void HandlingRotateObjectEvent(Point e)
        {
            if (tempShape is null)
                return;
            PointF center = controller.GetSelectedShape().GetCenterOfBoundingBox();
            Point end = new Point(e.X, e.Y);
            int angle = 1;

            if ((start.Y - center.Y) * (end.X - center.X)
                - (start.X - center.X) * (end.Y - center.Y) > 0)
                angle = -angle;

            controller.RotateObject(angle);
            controller.DrawAll();
            UpdateUI();
            start = end;
        }

        private double Distance(PointF a, PointF b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        Shape tempShape;
        private void HandlingScaleObjectEvent(Point e)
        {
            if (tempShape is null)
                return;
            controller.SetSelectedShape(tempShape);
            PointF center = tempShape.GetCenterOfBoundingBox();
            float Sx = Math.Abs(e.X - center.X) / Math.Abs(start.X - center.X);
            float Sy = Math.Abs(e.Y - center.Y) / Math.Abs(start.Y - center.Y);
            controller.ScaleObject(Sx, Sy);
            controller.DrawAll();
            UpdateUI();
        }

        private void HandlingDrawObjectEven(Point e)
        {
            Bitmap bitmap = (Bitmap)controller.getBitmap().Clone();
            Graphics g = Graphics.FromImage(bitmap);
            Shape shape = ShapeFactory.CreateShape(shapeType, start, new Point(e.X, e.Y));
            shape.Draw(g);
            pictureBox.Image = bitmap;
        }

        private void HandlingMoveObjectEvent(Point e)
        {
            if (tempShape is null)
                return;
            int dx = e.X - start.X;
            int dy = e.Y - start.Y;
            controller.ShiftObject(dx, dy);
            controller.DrawAll();
            UpdateUI();
            start = new Point(e.X, e.Y);
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {

        }

        public void UpdateUI()
        {
            this.pictureBox.Image = controller.getBitmap();
        }


        private void pickBorderColor(object sender, EventArgs e)
        {
            if (colorPickerBorder.ShowDialog() == DialogResult.OK)
            {
                Color color = colorPickerBorder.Color;
                btnBorderColorPicker.BackColor = color;
                controller.setBorder(color);
            }
        }


        private void pickFillColor(object sender, EventArgs e)
        {
            if (colorPickerFill.ShowDialog() == DialogResult.OK)
            {
                Color color = colorPickerFill.Color;
                btnFillForePicker.BackColor = color;

                controller.setFillForeground(color);
                //chang fill color
            }
        }

        private void borderSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(sender.ToString() + e.ToString());
            controller.setBorder(BorderStyle.getPattern(borderSelector.SelectedIndex));
        }

        private void pickFillForeColor(object sender, EventArgs e)
        {
            if (colorPickerFill.ShowDialog() == DialogResult.OK)
            {
                Color color = colorPickerFill.Color;
                btnFillForePicker.BackColor = color;
                controller.setFillForeground(color);
            }
        }

        private void pickFillBgColor(object sender, EventArgs e)
        {
            if (colorPickerFill.ShowDialog() == DialogResult.OK)
            {
                Color color = colorPickerFill.Color;
                btnFillBgPicker.BackColor = color;
                controller.setFillBackground(color);
            }
        }

        private void sliderBorderWeight_Scroll(object sender, EventArgs e)
        {
            int weight = sliderBorderWeight.Value;
            lbBorderValue.Text = weight.ToString() + " px";
            controller.setBorder(weight);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            SwitchToMoveState();
        }


        private void fillPatternSelection1_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.setFillPattern(fillPatternSelection.SelectedIndex);

        }

        private void btnShapePicker_Click(object sender, EventArgs e)
        {
            state = State.DRAW;
            shapePickerPanel.Visible = true;
            shapePickerPanel.Focus();
        }

        private void setPenCursor()
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursors\\pen.cur");
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.LINE;
            this.btnShapePicker.Image = Properties.Resources.line;
            HideShapePickerPanel();
            btnShapePicker.Focus();
            setPenCursor();
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            state = State.DRAW_RECTANGLE;
            this.btnShapePicker.Image = Properties.Resources.rect;
            HideShapePickerPanel();
            btnShapePicker.Focus();
            setPenCursor();
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.ELLIPSE;
            this.btnShapePicker.Image = Properties.Resources.ellipse;
            HideShapePickerPanel();
            btnShapePicker.Focus();
            setPenCursor();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.ELLIPSE;
            this.btnShapePicker.Image = Properties.Resources.circle;
            HideShapePickerPanel();
            btnShapePicker.Focus();
            setPenCursor();
        }

        private void btnParabola_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.PARABOLA;
            this.btnShapePicker.Image = Properties.Resources.parabola;
            HideShapePickerPanel();
            btnShapePicker.Focus();
            setPenCursor();
        }

        private void btnHyperbole_Click(object sender, EventArgs e)
        {
            state = State.DRAW_HYPERBOLE;
            this.btnShapePicker.Image = Properties.Resources.hyperbole;
            HideShapePickerPanel();
            btnShapePicker.Focus();
            setPenCursor();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            state = State.DRAW_SQUARE;
            this.btnShapePicker.Image = Properties.Resources.square;
            HideShapePickerPanel();
            btnShapePicker.Focus();
            setPenCursor();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            state = State.DRAW_TRIANGLE;
            this.btnShapePicker.Image = Properties.Resources.triangle;
            HideShapePickerPanel();
            btnShapePicker.Focus();
            setPenCursor();
        }

        private void toolbarHolder_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolbarHolder_Click(object sender, EventArgs e)
        {
            HideShapePickerPanel();
            HideLayerPanel();
        }

        private void Form_MouseClick(object sender, MouseEventArgs e)
        {
            HideShapePickerPanel();
            HideLayerPanel();
        }

        private void toolbarHolder_ContentPanel_MouseClick(object sender, MouseEventArgs e)
        {
            HideShapePickerPanel();
            HideLayerPanel();
        }

        void HideShapePickerPanel()
        {
            if (shapePickerPanel.Visible == true)
                shapePickerPanel.Visible = false;
        }

        void HideLayerPanel()
        {
            if (layerPanel.Visible == true)
                layerPanel.Visible = false;
        }

        void ChangeState(State state)
        {
            this.state = state;
        }

        private void shapePickerPanel_Leave(object sender, EventArgs e)
        {
            HideShapePickerPanel();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        void Undo()
        {
            state = State.DRAW;
            if (undoList.Count > 0)
            {
                redoList.Push(controller);
                controller = undoList.Pop();
                controller.DrawAll();
                UpdateUI();
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        void Redo()
        {
            state = State.DRAW;
            if (redoList.Count > 0)
            {
                undoList.Push(controller);
                controller = redoList.Pop();
                controller.DrawAll();
                UpdateUI();
            }
        }

        //private string _filePath = "D:\\_2D.txt";

        public bool SaveProject()
        {
            //get file path
            if (path_Save == null)
            {
                return SaveAsProject();
            }
            else
            {
                if (controller.Save(path_Save, 0) == true)
                {
                    setSaveState(true);
                    return true;
                }
                else
                {
                    MessageBox.Show(this, "Save Failed", "Notification", MessageBoxButtons.OK);
                    setSaveState(false);
                    return false;
                }
            }
                
        }

        public bool SaveAsProject()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path_Save = saveFileDialog.FileName;
                if(controller.Save(path_Save, 0) == true)
                {
                    setSaveState(true);
                    return true;
                }
                else
                {
                    MessageBox.Show(this, "Save Failed", "Notification", MessageBoxButtons.OK);
                    setSaveState(false);
                    return false;
                }
            }
            return false;
        }

        public void NewProject()
        {
            //do in new thread
            Thread newInsThread = new Thread(new ThreadStart(ThreadProc));
            newInsThread.SetApartmentState(ApartmentState.STA);
            newInsThread.Start();
        }

        public void CloseProject()
        {
            bool cando = false;
            if (!isSaved)
            {
                if (MessageBox.Show("You must save this project before closing", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    cando = SaveProject();
            }
            else
                cando = true;
            if (cando)
            {
                //do in new thread
                Thread newInsThread = new Thread(new ThreadStart(ThreadProc));
                newInsThread.SetApartmentState(ApartmentState.STA);
                newInsThread.Start();
                this.Close();
            }
        }

        private void ThreadProc()
        {
            var frm = new Form();
            frm.ShowDialog();
        }

        public void LoadProject()
        {
            bool can_do = false;
            if (!isSaved)
            {
                if (MessageBox.Show("You must save this project before work with other porject", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    if (SaveProject() == true)
                        can_do = true;
            }
            else
                can_do = true;

            if (can_do)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path_Save = openFileDialog.FileName;
                    if (controller.Load(path_Save, 0) == true)
                    {
                        setSaveState(true);
                        controller.DrawAll();
                        UpdateUI();
                    }
                    else
                    {
                        MessageBox.Show(this, "Open project failed", "Notification", MessageBoxButtons.OK);
                        setSaveState(false);
                    }
                }
            }

            
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            SwitchToScaleState();
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            SwitchToRotateState();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveProject();
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadProject();
        }

       
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control)
            {
                this.SaveProject();
            }
            else if (e.KeyCode == Keys.F12)
            {
                this.SaveAsProject();
            }
            else if (e.KeyCode == Keys.O && e.Modifiers == Keys.Control)
            {
                this.LoadProject();
            }
            else if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                this.NewProject();
            }
            else if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Z && e.Modifiers == Keys.Control)
            {
                this.Undo();
            }
            else if (e.KeyCode == Keys.Y && e.Modifiers == Keys.Control)
            {
                this.Redo();
            }
            else if (e.KeyCode == Keys.V)
            {
                SwitchToMoveState();
            }
            else if (e.KeyCode == Keys.D3 && e.Modifiers == Keys.Alt){
                SwitchToHandViewState();
            }
            else if (e.KeyCode == Keys.T && e.Modifiers == Keys.Control)
            {
                SwitchToScaleState();
            }
            else if (e.KeyCode == Keys.R && e.Modifiers == Keys.Control)
            {
                SwitchToRotateState();
            }

        }

        private void SwitchToMoveState()
        {
            this.state = State.MOVE;
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursors\\move.cur");
        }

        private void SwitchToRotateState()
        {
            this.state = State.ROTATE;
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursors\\rotate.cur");
        }

        private void SwitchToScaleState()
        {
            this.state = State.SCALE;
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursors\\scale.cur");
        }

        private void SwitchToHandViewState()
        {
            this.state = State.HAND_VIEW;// move hold the picture
            //this.Cursor = Cursors.Hand;
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursors\\hand.cur");

        }

        private void Form_KeyDown(object sender, KeyPressEventArgs e)
        {
           
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProject();
        }

        private void btnMove_MouseHover(object sender, EventArgs e)
        {
            //toolTip.SetToolTip(btnMove, "Move");
            showToolTipButton(btnMove, "Move");
        }

        void showToolTipButton(Button btn, String msg)
        {
            toolTip.SetToolTip(btn, msg);
        }

        private void btnShapePicker_MouseHover(object sender, EventArgs e)
        {
            showToolTipButton(btnShapePicker, "Drawing Shape");
        }

        private void btnUndo_MouseHover(object sender, EventArgs e)
        {
            showToolTipButton(btnUndo, "Undo");
        }

        private void btnRedo_MouseHover(object sender, EventArgs e)
        {
            showToolTipButton(btnRedo, "Redo");
        }

        private void btnLine_MouseHover(object sender, EventArgs e)
        {
            showToolTipButton(btnLine, "Line");
        }

        
        private void btnRotate_MouseHover(object sender, EventArgs e)
        {
            showToolTipButton(btnRotate, "Rotate");
        }

        private void btnScale_MouseHover(object sender, EventArgs e)
        {
            showToolTipButton(btnScale, "Scale");
        }

        private void btnOpenProject_MouseHover(object sender, EventArgs e)
        {
            showToolTipButton(btnOpenProject, "Open Project");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveAsProject();
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            showToolTipButton(btnSave, "Save");
        }

        private void btnSaveAs_MouseHover(object sender, EventArgs e)
        {
            showToolTipButton(btnSaveAs, "Save As");
        }

        private void btnNewProject_MouseHover(object sender, EventArgs e)
        {
            showToolTipButton(btnNewProject, "New Project");
        }

        private void btnLayer_Click(object sender, EventArgs e)
        {
            label7.Text = controller.mSelectedShapeIndex.ToString();
            layerPanel.Visible = true;
            layerPanel.Focus();
        }

        private void btnLayer_MouseHover(object sender, EventArgs e)
        {
            showToolTipButton(btnLayer, "Layer");
        }


        //Edit layer
        private void btnSendForward_Click(object sender, EventArgs e)
        {
            controller.SendObjectToForward();
            controller.DrawAll();
            UpdateUI();
            HideLayerPanel();
        }

        private void btnSendFront_Click(object sender, EventArgs e)
        {
            controller.SendObjectToFront();
            controller.DrawAll();
            UpdateUI();
            HideLayerPanel();
        }

        private void btnSendBackward_Click(object sender, EventArgs e)
        {
            controller.SendObjectToBackward();
            controller.DrawAll();
            UpdateUI();
            HideLayerPanel();
        }

        private void btnSendBack_Click(object sender, EventArgs e)
        {
            controller.SendObjectToBack();
            controller.DrawAll();
            UpdateUI();
            HideLayerPanel();
        }

        private void layerPanel_Leave(object sender, EventArgs e)
        {

            HideLayerPanel();
        }

        private void closeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseProject();
        }

        private void btnHandView_Click(object sender, EventArgs e)
        {
            SwitchToHandViewState();
        }

        private void btnHandView_MouseHover(object sender, EventArgs e)
        {
            showToolTipButton(btnHandView, "View");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

