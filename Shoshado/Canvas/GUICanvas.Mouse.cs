using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoshado.Canvas
{
    partial class GUICanvas
    {
        public Action<int, int> CanvasMouseMove = null;

        private void GUICanvas_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void GUICanvas_MouseMove(object sender, MouseEventArgs e)
        {
            CanvasMouseMove?.Invoke(e.X, e.Y);

        }

        private void GUICanvas_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void GUICanvas_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
