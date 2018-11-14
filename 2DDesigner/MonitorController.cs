
using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2DDesigner
{
    public class Monitor
    {
        int window_width;
        int window_height;

        int toolbar_width;
        int toolbar_height;
        Point toolbar_positon;

        int picturebox_width;
        int picturebox_height;
        Point picturebox_position;

        Form form;
       
        public Monitor(Form form)
        {
            this.form = form;

            SetFullScreen();
        }

        private void SetFullScreen()
        {
            window_width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            window_height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            form.SetBounds(0, 0, window_width, window_height);
            form.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
        }
        
    }

    enum State
    {
        DEFAULT,//view
        MOVE,
        SCALE,
        FILL,
        DRAW_LINE,
        DRAW_RECTANGLE,
        DRAW_SQUARE,
        DRAW_ELLIPSE,
        DRAW_CIRCLE,

    }

    
}
