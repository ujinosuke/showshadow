using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoshado
{
    public partial class DebugView : Form
    {
        private List<TextBox> textBoxes = new List<TextBox>();
        public DebugView()
        {
            InitializeComponent();
            foreach(var c in Controls)
            {
                if (c is TextBox t) textBoxes.Add(t);
            }
        }

        private void DebugView_Load(object sender, EventArgs e)
        {

        }

        private void DebugView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach(var t in textBoxes)
            {
                t.Text = "";
            }


        }

        public void DebugMouseMove(MouseEventArgs e)
        {
            string txt = string.Format("(x,y) = ({0},{1})", e.X, e.Y);
            txtMouse.Text = txt;
        }

        public void DebugMouseClick(MouseEventArgs e)
        {
            string txt = string.Format("Down : {2} (x,y) = ({0},{1})", e.X, e.Y, e.Button.ToString());
            txtMouseClick.Text = txt;
        }

        public void DebugMouseClickUp(MouseEventArgs e)
        {
            string txt = string.Format("Up : {2} (x,y) = ({0},{1})", e.X, e.Y, e.Button.ToString());
            txtMouseClick.Text = txt;
        }

        public void DebugMouseDoubleClick(MouseEventArgs e)
        {
            string txt = string.Format("{2} (x,y) = ({0},{1})", e.X, e.Y, e.Button.ToString());
            txtMouseDoubleClick.Text = txt;
        }

        public void DebugMouseWheel(MouseEventArgs e)
        {
            string txt = string.Format("Delta:{2} (x,y) = ({0},{1})", e.X, e.Y, e.Delta);
            txtMouseWheel.Text = txt;
        }

        public void DebugKeyDown(PreviewKeyDownEventArgs e)
        {
            //string txt = string.Format("Control {0} / Shift {1} /Alt: {2} ", e.Control, e.Shift, e.Alt);
            txtKeyDown.Text = e.KeyCode.ToString();


        }

    }
}
