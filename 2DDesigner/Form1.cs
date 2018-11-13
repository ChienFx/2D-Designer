using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            if (colorPickerFill.ShowDialog() == DialogResult.OK)
            {
                btnFillColor.BackColor = colorPickerFill.Color;
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using(Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    Pen pen = new Pen(colorPickerFill.Color, 10);
                    float[] dashValues = { 5, 14, 4, 2 };
                    pen.DashPattern = dashValues;

                    g.DrawLine(pen, new Point(10, 10), new Point(400, 400));
                }
                
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           

           

            //pen.Dispose();
            

        }
    }
}
