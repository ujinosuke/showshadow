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
        public DebugView()
        {
            InitializeComponent();
        }

        private void DebugView_Load(object sender, EventArgs e)
        {

        }

        private void DebugView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }


        public void DebugMouseMove(int x, int y)
        {
            string txt = string.Format("(x,y) = ({0},{1})", x, y);
            txtMouse.Text = txt;
        }

    }
}
