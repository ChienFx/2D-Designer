
using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2DDesigner
{
    public class BorderSelector : ComboBox
    {
        public BorderSelector()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            for(int i = 0; i < BorderStyle.AmountOfBorderStyle; i++)
            {
                this.Items.Add(i);
            }
            
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            Point p1 = new Point(e.Bounds.Left + 5, e.Bounds.Y + 5);
            Point p2 = new Point(e.Bounds.Right - 5, e.Bounds.Y + 5);

            Pen pen = new Pen(Color.Black, 2);
            BorderStyle borderStyle = BorderStyle.getPattern(e.Index);
            pen.DashPattern = borderStyle.getValues();
            e.Graphics.DrawLine(pen, p1, p2);
        }
    }
}