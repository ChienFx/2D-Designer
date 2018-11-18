using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
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
        TextBox label;

        Stack<object> undoList = new Stack<object>();
        Stack<object> redoList = new Stack<object>();

        string path_Save = null;

        private float zoomRatio = 1;
        private Shape tempShape, shape;

        private Cursor curFunction = Cursor.Current;

        public Form()
        {
            InitializeComponent();
            monitor = new Monitor(this);
            monitor.SetFullScreen();
            pictureBox.Size = monitor.sizePictureBox_Max;

            controller = new Controller(pictureBox.Width, pictureBox.Height);
            start = new Point(0, 0);
            state = State.DEFAULT;
            shapeType = ShapeType.DEFAULT;
            UpdateUI();
            this.DoubleBuffered = true;
            this.FormClosing += Form_FormClosing;
            shape = null;
            label = null;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool stopClosing = false;
            if (!isSaved)
            {
                DialogResult res = MessageBox.Show(this, "Do you want to save this project?", "Save & Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    stopClosing = !this.SaveProject();
                }
                else if (res == DialogResult.No)
                {
                    DialogResult res2 = MessageBox.Show(this, "Your project will be loss!\nContinue Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    stopClosing = (res2 == DialogResult.No);
                }
                else
                    stopClosing = true;

                e.Cancel = stopClosing;
            }
            if (stopClosing) { return; }
            DisposeResources();
                
        }

        private void DisposeResources()
        {
            if(pictureBox.Image!=null)
                pictureBox.Image.Dispose();

            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnShapePicker.Image = Properties.Resources.line;
            btnBorderColorPicker.BackColor = MyColor.DEFUALT_SHAPE_BORDER_COLOR;
            btnFillBgPicker.BackColor = MyColor.DEFAULT_BACKGROUND;
            btnFillForePicker.BackColor = MyColor.DEFAULT_SHAPE_FILL_COLOR;
            setSaveState(true);
            HideLayerPanel();
            HideShapePickerPanel();
            HideZoomPanel();
            shapeType = ShapeType.LINE;
            setCursor("pen.cur");
            state = State.DRAW;
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
            HideZoomPanel();
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
            switch (state)
            {
                case State.MOVE:
                case State.ROTATE:
                case State.SCALE:
                case State.FILL:
                    if (!(shape is null))
                    {
                        controller.addShape(shape, controller.mSelectedShapeIndex);
                        shape = null;
                    }
                    SaveState();
                    break;
                case State.DRAW:
                    SaveState();
                    if (start.X == e.X && start.Y == e.Y)
                    {
                        if (shape != null && shapeType == ShapeType.BEZIER)
                        {
                            ((Bezier)shape).AddPoint(new Point(e.X, e.Y));
                        }
                        break;
                    }
                    shape = ShapeFactory.CreateShape(shapeType, start, new Point(e.X, e.Y));
                    controller.addShape(shape);
                    if (shapeType != ShapeType.BEZIER)
                        shape = null;
                    break;
                default:
                    break;
            }

            controller.ShowBoundingBoxOfObject();
            UpdateUI();
            isMouseHold = false;
        }

        private void SaveState()
        {
            //Push state into undo stack
            undoList.Push((Controller)controller.Clone());
            setSaveState(false);//unSaved
            redoList.Clear();
        }

        private void UnSelectedShape()
        {
            controller.DetectWhichObjectIsSelected(new Point(-1, -1));
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            controller.DetectWhichObjectIsSelected(new Point(e.X, e.Y));

            switch (state)
            {
                case State.DRAW_LABEL:
                    HandlingDrawLabelEvent(e.Location);
                    break;
                case State.MOVE:
                case State.ROTATE:
                case State.SCALE:
                    shape = controller.DeleteSelectedObject();
                    if (!(shape is null))
                    {
                        tempShape = (Shape)shape.Clone();
                        controller.DrawAll();
                        DrawOnCloneGraphics(shape);
                    }
                    break;
                case State.HAND_VIEW:
                case State.FILL:
                    break;
                case State.DRAW:
                    break;
            }
            isMouseHold = true;
            start = new Point(e.X, e.Y);
        }

        public static bool SetStyle(Control c, ControlStyles Style, bool value)
        {
            bool retval = false;
            Type typeTB = typeof(Control);
            System.Reflection.MethodInfo misSetStyle = typeTB.GetMethod("SetStyle", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            if (misSetStyle != null && c != null) { misSetStyle.Invoke(c, new object[] { Style, value }); retval = true; }
            return retval;
        }

        private void HandlingDrawLabelEvent(Point e)
        {
            if (label is null)
            {
                label = new TextBox();
                SetStyle(label, ControlStyles.SupportsTransparentBackColor, true);
                label.Font = new Font(FontFamily.GenericSansSerif, 15F, FontStyle.Regular);
                label.Visible = true;
                label.TextChanged += Label_TextChange;
                label.WordWrap = true;
                label.Location = e;
                pictureBox.Controls.Add(label);
                undoList.Push(label);
                redoList.Clear();
            }
            else
            {
                label.BorderStyle = System.Windows.Forms.BorderStyle.None;
                label.Enabled = false;
                label.BackColor = Color.Transparent;
                label = null;
            }
        }

        private void Label_TextChange(object sender, EventArgs e)
        {
            SizeF size = new SizeF();
            using (Graphics g = this.CreateGraphics())
            {
                size = g.MeasureString(label.Text, label.Font);
            }
            label.Width = (int)Math.Round(size.Width, 0);
            label.Height = (int)Math.Round(size.Height, 0);
        }

        private void setTextForLabel(Label lb, Point p)
        {
            lb.Text = p.ToString();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            setTextForLabel(lbMouseHover, e.Location);
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
            if (shape is null)
                return;
            PointF center = shape.GetCenterOfBoundingBox();
            Point end = new Point(e.X, e.Y);
            int angle = 1;
            if ((start.Y - center.Y) * (end.X - center.X)
                - (start.X - center.X) * (end.Y - center.Y) > 0)
                angle = -angle;
            shape.Rotate(angle);
            DrawOnCloneGraphics(shape, true);
            start = end;
        }


        private void HandlingScaleObjectEvent(Point e)
        {
            if (shape is null || !tempShape.CheckScaleOk(start) || !tempShape.CheckScaleOk(e))
                return;
            shape = (Shape)tempShape.Clone();
            PointF center = shape.mTopLeft;
            float Sx = Math.Abs(e.X - center.X) / Math.Abs(start.X - center.X);
            float Sy = Math.Abs(e.Y - center.Y) / Math.Abs(start.Y - center.Y);
            shape.Scale(Sx, Sy);
            DrawOnCloneGraphics(shape, true);
        }

        private void HandlingDrawObjectEven(Point e)
        {
            Shape shape = ShapeFactory.CreateShape(shapeType, start, new Point(e.X, e.Y));
            shape.setBorder(controller.GetBorder());
            shape.setFillPattern(controller.GetFillPattern());
            DrawOnCloneGraphics(shape);
        }

        private void HandlingMoveObjectEvent(Point e)
        {
            if (shape is null)
                return;
            int dx = e.X - start.X;
            int dy = e.Y - start.Y;
            shape.Shift(dx, dy);
            DrawOnCloneGraphics(shape, true);
            start = new Point(e.X, e.Y);
        }

        private void DrawOnCloneGraphics(Shape shape, bool isShowBoundingBox = false)
        {
            Bitmap bitmap = (Bitmap)controller.getBitmap().Clone();
            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            shape.Fill(g);
            shape.Draw(g);
            if (isShowBoundingBox)
                shape.ShowBoundingBox(g);
            pictureBox.Image = bitmap;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {

        }

        public void UpdateUI()
        {
            this.pictureBox.Image = (Bitmap)controller.getBitmap();
        }
        
        private void pickBorderColor(object sender, EventArgs e)
        {
            if (colorPickerBorder.ShowDialog() == DialogResult.OK)
            {
                Color color = colorPickerBorder.Color;
                btnBorderColorPicker.BackColor = color;
                if (controller.setBorder(color))
                {
                    UpdateUI();
                }
            }
        }


        private void pickFillColor(object sender, EventArgs e)
        {
            if (colorPickerFill.ShowDialog() == DialogResult.OK)
            {
                Color color = colorPickerFill.Color;
                btnFillForePicker.BackColor = color;

                if (controller.setFillForeground(color))
                {
                    UpdateUI();
                }
            }
        }

        private void borderSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(sender.ToString() + e.ToString());
            if (controller.setBorder(BorderStyle.getPattern(borderSelector.SelectedIndex)))
            {
                controller.DrawAll();
                UpdateUI();
            }
        }

        private void pickFillForeColor(object sender, EventArgs e)
        {
            if (colorPickerFill.ShowDialog() == DialogResult.OK)
            {
                Color color = colorPickerFill.Color;
                btnFillForePicker.BackColor = color;
                if(controller.setFillForeground(color))
                {
                    UpdateUI();
                }
            }
        }

        private void pickFillBgColor(object sender, EventArgs e)
        {
            if (colorPickerFill.ShowDialog() == DialogResult.OK)
            {
                Color color = colorPickerFill.Color;
                btnFillBgPicker.BackColor = color;
                if (controller.setFillBackground(color))
                {
                    UpdateUI();
                }
            }
        }

        private void sliderBorderWeight_Scroll(object sender, EventArgs e)
        {
            int weight = sliderBorderWeight.Value;
            lbBorderValue.Text = weight.ToString() + " px";
            if (controller.setBorder(weight))
            {
                controller.DrawAll();
                UpdateUI();
            }
                
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            SwitchToMoveState();
        }

        private void fillPatternSelection1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controller.setFillPattern(fillPatternSelection.SelectedIndex))
            {
                controller.DrawAll();
                UpdateUI();
            }

        }

        private void btnShapePicker_Click(object sender, EventArgs e)
        {
            state = State.DRAW;
            shapePickerPanel.Visible = true;
            shapePickerPanel.Focus();
            setCursor(null, Cursors.Arrow);
        }

        private void setCursor(string curName=null, Cursor cur=null)
        {
            if (curName != null)
            {
                curFunction = new Cursor(Application.StartupPath + "\\Cursors\\" + curName);
                this.Cursor = curFunction;
            }

            if (cur != null)
                curFunction = cur;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.LINE;
            this.btnShapePicker.Image = Properties.Resources.line;
            HideShapePickerPanel();
            btnShapePicker.Focus();
            setCursor("pen.cur");
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.RECTANGLE;
            this.btnShapePicker.Image = Properties.Resources.rect;
            HideShapePickerPanel();
            btnShapePicker.Focus();
            setCursor("pen.cur");
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.ELLIPSE;
            this.btnShapePicker.Image = Properties.Resources.ellipse;
            HideShapePickerPanel();
            btnShapePicker.Focus();
            setCursor("pen.cur");
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.CIRCLE;
            this.btnShapePicker.Image = Properties.Resources.circle;
            HideShapePickerPanel();
            btnShapePicker.Focus();
            setCursor("pen.cur");
        }

        private void btnParabola_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.PARABOLA;
            this.btnShapePicker.Image = Properties.Resources.parabola;
            HideShapePickerPanel();
            btnShapePicker.Focus();
            setCursor("pen.cur");
        }

        private void btnHyperbole_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.BEZIER;
            this.btnShapePicker.Image = Properties.Resources.hyperbole;
            HideShapePickerPanel();
            btnShapePicker.Focus();
            setCursor("pen.cur");
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.SQUARE;
            this.btnShapePicker.Image = Properties.Resources.square;
            HideShapePickerPanel();
            btnShapePicker.Focus();
            setCursor("pen.cur");
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.TRIANGLE;
            this.btnShapePicker.Image = Properties.Resources.triangle;
            HideShapePickerPanel();
            btnShapePicker.Focus();
            setCursor("pen.cur");
        }

        private void toolbarHolder_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolbarHolder_Click(object sender, EventArgs e)
        {
            HideShapePickerPanel();
            HideLayerPanel();
            HideZoomPanel();
        }

        private void Form_MouseClick(object sender, MouseEventArgs e)
        {
            HideShapePickerPanel();
            HideLayerPanel();
            HideZoomPanel();
        }

        private void toolbarHolder_ContentPanel_MouseClick(object sender, MouseEventArgs e)
        {
            HideShapePickerPanel();
            HideLayerPanel();
            HideZoomPanel();
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

        void HideZoomPanel()
        {
            if(zoomSlider.Visible == true)
            {
                zoomSlider.Visible = false;
                zoomLabel.Visible = false;
            }
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
                object _object = undoList.Pop();
                try
                {
                    Controller tmp = (Controller)_object;

                    redoList.Push(controller);
                    controller = tmp;
                    controller.DrawAll();
                    UpdateUI();
                }
                catch (Exception)
                {
                    pictureBox.Controls.Remove((TextBox)_object);
                    redoList.Push(_object);
                }

                /*redoList.Push(controller);
                controller = (Controller)undoList.Pop();
                controller.DrawAll();
                UpdateUI();*/
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
                object _object = redoList.Pop();

                try
                {
                    Controller tmp = (Controller)_object;

                    undoList.Push(controller);
                    controller = tmp;
                    controller.DrawAll();
                    UpdateUI();
                }
                catch (Exception)
                {
                    pictureBox.Controls.Add((TextBox)_object);
                    undoList.Push(_object);
                }
                /*
                undoList.Push(controller);
                controller = (Controller)redoList.Pop();
                controller.DrawAll();
                UpdateUI();
                */
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
                        undoList.Clear();
                        redoList.Clear();
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
            else if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            {
                controller.copySelectedShape();
            }
            else if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                if (controller.pasteCopiedShape())
                {
                    controller.DrawAll();
                    UpdateUI();
                }
            }
            else if (e.KeyCode == Keys.X && e.Modifiers == Keys.Control)
            {
                if (controller.cutSelectedShape())
                {
                    controller.DrawAll();
                    UpdateUI();
                }
            }
            else if (e.KeyCode == Keys.V)
            {
                SwitchToMoveState();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (controller.GetSelectedShape() != null)
                    if(controller.DeleteSelectedObject() != null)
                    {
                        controller.DrawAll();
                        UpdateUI();
                    }
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
            setCursor("move.cur");
        }

        private void SwitchToRotateState()
        {
            this.state = State.ROTATE;
            setCursor("rotate.cur");
        }

        private void SwitchToScaleState()
        {
            this.state = State.SCALE;
            setCursor("scale.cur");
        }

        private void SwitchToHandViewState()
        {
            this.state = State.HAND_VIEW;// move hold the picture
            setCursor("hand.cur");

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

        private void zoomSlider_Scroll(object sender, EventArgs e)
        {
            if(zoomSlider.Value > 0)
            {
                zoomLabel.Text = ((zoomSlider.Value * 10)).ToString() + "%";
                zoomRatio = zoomSlider.Value / 10.0f;

                pictureBox.Image= null;
                pictureBox.Image = PictureBoxZoom(controller.getBitmap(), zoomRatio);
            }
        }

        public Image PictureBoxZoom(Image img, float ratio)
        {
            Bitmap bm = new Bitmap(img, (int)(img.Width * ratio),(int)(img.Height * ratio));
            //Graphics grap = Graphics.FromImage(bm);
            //grap.InterpolationMode = InterpolationMode.HighQualityBicubic;
            return bm;
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            zoomSlider.Visible = true;
            zoomLabel.Visible = true;
            zoomSlider.Focus();
        }

        private void zoomSlider_Leave(object sender, EventArgs e)
        {
            HideZoomPanel();
            zoomRatio = 1;
            UpdateUI();
        }

        private void lbMappedCur_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            controller.DeleteSelectedObject();
            controller.DrawAll();
            UpdateUI();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void bitmapbmpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rightClickMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Shape selectedShape = controller.GetSelectedShape();
            bool notNull = selectedShape != null;
            btnCopy.Enabled = notNull;
            btnCut.Enabled = notNull;
            btnDelItem.Enabled = notNull;
            btnLayerItem.Enabled = notNull;
            btnExportShape.Enabled = notNull;
            btnPaste.Enabled = controller.getCopiedShape() != null;
        }      

        void ExportProjectToImage(ImageFormat imgF, string defaultExt, string title, string filter, string defaultFileName)
        {
            saveImgDialog.AddExtension = true;
            saveImgDialog.DefaultExt = defaultExt;
            saveImgDialog.Title = title;
            saveImgDialog.FileName = defaultFileName;
            saveImgDialog.Filter = filter;


            if (saveImgDialog.ShowDialog() == DialogResult.OK)
            {
                string pathImg = saveImgDialog.FileName;
                try
                {
                    controller.getBitmap().Save(pathImg, imgF);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportProjectToImage(ImageFormat.Bmp, "bmp", "Export to Bitmap", "Bitmap file|*.bmp", "bitmap01");
        }

        private void iMGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportProjectToImage(ImageFormat.Jpeg,"jpg", "Export to JPEG", "JPEG file|*.jpg", "jpegfile01");
          
        }

        private void pNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportProjectToImage(ImageFormat.Png, "png", "Export to PNG", "PNG file|*.png", "pngfile01");
        }

        private void gifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportProjectToImage(ImageFormat.Gif, "gif", "Export to GIF", "GIF file|*.gif", "giffile01");
        }


        private void rightClickMenu_Click(object sender, EventArgs e)
        {
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            controller.copySelectedShape();
        }
        
        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (controller.pasteCopiedShape())
            {
                controller.DrawAll();
                UpdateUI();
            }
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            if (controller.cutSelectedShape())
            {
                controller.DrawAll();
                UpdateUI();
            }
        }

        private void setMouseToMainBoard(object sender, EventArgs e)
        {
            this.Cursor = curFunction;
        }

        private void setMouseToToolbar(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controller.DeleteSelectedObject() != null)
            {
                controller.DrawAll();
                UpdateUI();
            }
        }

        void ExportShapeToImage(ImageFormat imgF, string defaultExt, string title, string filter, string defaultFileName)
        {
            saveImgDialog.AddExtension = true;
            saveImgDialog.DefaultExt = defaultExt;
            saveImgDialog.Title = title;
            saveImgDialog.FileName = defaultFileName;
            saveImgDialog.Filter = filter;


            if (saveImgDialog.ShowDialog() == DialogResult.OK)
            {
                string pathImg = saveImgDialog.FileName;
                try
                {
                    Shape curShape = controller.GetSelectedShape();
                    if (curShape != null)
                    {
                        curShape = (Shape) curShape.Clone();
                        Size size = curShape.getBoundingSize();
                        
                        Bitmap tmpBitmap = curShape.ExportToImage();
                        
                        tmpBitmap.Save(pathImg, imgF);

                    }
                    else
                        return;
                    //controller.getBitmap().Save(pathImg, imgF);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bMPShapeExport_Click(object sender, EventArgs e)
        {
            ExportShapeToImage(ImageFormat.Bmp, "bmp", "Export to Bitmap", "Bitmap file|*.bmp", "export_shape_to_bitmap");
        }

        private void iMGShapeExport_Click(object sender, EventArgs e)
        {
            ExportShapeToImage(ImageFormat.Jpeg, "jpg", "Export to JPEG", "JPEG file|*.jpg", "export_shape_to_jpeg");

        }

        private void pNGShapeExport_Click(object sender, EventArgs e)
        {
            ExportShapeToImage(ImageFormat.Png, "png", "Export to PNG", "PNG file|*.png", "export_shape_to_png");
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToMoveState();
        }

        private void rotateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SwitchToRotateState();
        }

        private void scaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToScaleState();
        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            state = State.DRAW_LABEL;
            this.btnShapePicker.Image = Properties.Resources.char1;
            HideShapePickerPanel();
            btnShapePicker.Focus();
            setCursor("pen.cur");
        }

        private void gifShapeExport_Click(object sender, EventArgs e)
        {
            ExportShapeToImage(ImageFormat.Gif, "gif", "Export to GIF", "GIF file|*.gif", "export_shape_to_gif");
        }
    }
}

