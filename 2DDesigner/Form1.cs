using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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

        Stack<Controller> undoList = new Stack<Controller>();
        Stack<Controller> redoList = new Stack<Controller>();

        public Form()
        {
            InitializeComponent();
            monitor = new Monitor(this);
            controller = new Controller(pictureBox.Width, pictureBox.Height);
            start = new Point(0, 0);
            state = State.DEFAULT;
            shapeType = ShapeType.DEFAULT;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnShapePicker.Image = Properties.Resources.line;
            shapePickerPanel.Visible = false;
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
            if (shapePickerPanel.Visible == true)
                shapePickerPanel.Visible = false;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            undoList.Push(ObjectExtensions.Copy(controller));
            redoList.Clear();


            if (state == State.MOVE)
            {
                controller.DetectWhichObjectIsSelected(new Point(-1, -1));
            }
            else
            {
                Shape shape = ShapeFactory.CreateShape(shapeType, start, new Point(e.X, e.Y));
                controller.addShape(shape);
                controller.DrawAll();
                UpdateUI();
            }
            isMouseHold = false;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (state == State.MOVE)
            {
                controller.DetectWhichObjectIsSelected(new Point(e.X, e.Y));
            }
            isMouseHold = true;
            start = new Point(e.X, e.Y);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (state == State.MOVE)
            {
                if (!(controller.GetSelectedShape() is null))
                {
                    int dx = e.X - start.X;
                    int dy = e.Y - start.Y;
                    controller.ShiftObject(dx, dy);
                    controller.DrawAll();
                    UpdateUI();
                    start = new Point(e.X, e.Y);
                }
            }
            else
            {
                if (isMouseHold)
                {
                    Bitmap bitmap = (Bitmap)controller.getBitmap().Clone();
                    Graphics g = Graphics.FromImage(bitmap);
                    Shape shape = ShapeFactory.CreateShape(shapeType, start, new Point(e.X, e.Y));
                    shape.Draw(g);
                    pictureBox.Image = bitmap;
                }
            }
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

        private void sliderBorderWeight_Scroll(object sender, EventArgs e)
        {
            int weight = sliderBorderWeight.Value;
            lbBorderValue.Text = weight.ToString() + " px";
            controller.setBorder(weight);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            state = State.MOVE;
            //Cursor = Cursors.NoMove2D;
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

        private void btnLine_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.LINE;
            this.btnShapePicker.Image = Properties.Resources.line;
            shapePickerPanel.Visible = false;
            btnShapePicker.Focus();
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            state = State.DRAW_RECTANGLE;
            this.btnShapePicker.Image = Properties.Resources.rect;
            shapePickerPanel.Visible = false;
            btnShapePicker.Focus();
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.ELLIPSE;
            this.btnShapePicker.Image = Properties.Resources.ellipse;
            shapePickerPanel.Visible = false;
            btnShapePicker.Focus();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.ELLIPSE;
            this.btnShapePicker.Image = Properties.Resources.circle;
            shapePickerPanel.Visible = false;
            btnShapePicker.Focus();
        }

        private void btnParabola_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.PARABOLA;
            this.btnShapePicker.Image = Properties.Resources.parabola;
            shapePickerPanel.Visible = false;
            btnShapePicker.Focus();
        }

        private void btnHyperbole_Click(object sender, EventArgs e)
        {
            state = State.DRAW_HYPERBOLE;
            this.btnShapePicker.Image = Properties.Resources.hyperbole;
            shapePickerPanel.Visible = false;
            btnShapePicker.Focus();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            state = State.DRAW_SQUARE;
            this.btnShapePicker.Image = Properties.Resources.square;
            shapePickerPanel.Visible = false;
            btnShapePicker.Focus();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            state = State.DRAW_TRIANGLE;
            this.btnShapePicker.Image = Properties.Resources.triangle;
            shapePickerPanel.Visible = false;
            btnShapePicker.Focus();
        }

        private void toolbarHolder_ContentPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void toolbarHolder_Click(object sender, EventArgs e)
        {
            HideShapePickerPanel();
        }

        private void Form_MouseClick(object sender, MouseEventArgs e)
        {
            HideShapePickerPanel();
        }

        private void toolbarHolder_ContentPanel_MouseClick(object sender, MouseEventArgs e)
        {
            HideShapePickerPanel();
        }

        void HideShapePickerPanel()
        {
            if(shapePickerPanel.Visible == true)
                shapePickerPanel.Visible = false;
        }

        void ChangeState(State state)
        {
            this.state = state;
        }

        private void shapePickerPanel_Leave(object sender, EventArgs e)
        {
            HideShapePickerPanel();
        }

        private void Undo_Click(object sender, EventArgs e)
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

        private void Redo_Click(object sender, EventArgs e)
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
    }
}

    