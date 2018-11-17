
using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2DDesigner
{
    [Serializable]
    public class Monitor
    {
        public Size sizeWindow_Min = new Size(805, 605);
        public Size sizeToolBar = new Size(800, 100);
        public Size sizePictureBox_Max;
        public Size sizeWindow_Max;

        Form form;

        public Monitor(Form xForm)
        {
            this.form = xForm;
        }

        public void SetFullScreen()
        {
            form.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            sizeWindow_Max = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            sizePictureBox_Max = new Size(
                sizeWindow_Max.Width-10,
                sizeWindow_Max.Height-sizeToolBar.Height-60);// sizeWindow_Max.Width, sizeWindow_Max.Height - sizeToolBar.Height);
        }
        
    }
    [Serializable]
    enum State
    {
        DEFAULT,//view
        MOVE,
        SCALE,
        FILL,
        DRAW,
        DRAW_RECTANGLE,
        DRAW_SQUARE,
        DRAW_HYPERBOLE,
        DRAW_TRIANGLE,
        ROTATE,
        HAND_VIEW,
    }

    
}
