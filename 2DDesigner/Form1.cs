using System;
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
        Point start;
        bool isMove = false;
        bool isMouseHold = false;

        public Form()
        {
            InitializeComponent();
            monitor = new Monitor(this);
            controller = new Controller(pictureBox.Width, pictureBox.Height);
            start = new Point(0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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



        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMove)
            {
                controller.DetectWhichObjectIsSelected(new Point(-1, -1));
            }
            else
            {
                Shape shape = new Parabola(start, new Point(e.X, e.Y));
                controller.addShape(shape);
                controller.DrawAll();
                UpdateUI();
            }
            isMouseHold = false;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            //isMove = true;
            if (isMove)
            {
                controller.DetectWhichObjectIsSelected(new Point(e.X, e.Y));
            }
            isMouseHold = true;
            start = new Point(e.X, e.Y);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove)
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
                    Shape shape = new Parabola(start, new Point(e.X, e.Y));
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
                btnFillColorPicker.BackColor = color;

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

        private void MoveObject_CheckedChanged(object sender, EventArgs e)
        {
            isMove = MoveObject.Checked;
        }
    }
}

    