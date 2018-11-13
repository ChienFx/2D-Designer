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
        public Shape shape;
        public Monitor monitor;
        public Form()
        {
            InitializeComponent();
            monitor = new Monitor(this);
            controller = new Controller(pictureBox.Width, pictureBox.Height);

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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            shape = new Line();
            controller.addShape(shape);
            shape.mTopLeft = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            shape.mBottomRight = new Point(e.X, e.Y);
            controller.DrawAll();
            UpdateUI();

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
    }
}

    