﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoshado.Canvas
{
    partial class GUICanvas
    {
        public Action<MouseEventArgs> CanvasMouseMove = null;
        public Action<MouseEventArgs> CanvasMouseClick = null;
        public Action<MouseEventArgs> CanvasMouseClickUp = null;
        public Action<MouseEventArgs> CanvasMouseDoubleClick = null;
        public Action<MouseEventArgs> CanvasMouseWheel = null;

        private void GUICanvas_MouseDown(object sender, MouseEventArgs e)
        {
            CanvasMouseClick?.Invoke(e);

        }

        private void GUICanvas_MouseMove(object sender, MouseEventArgs e)
        {
            CanvasMouseMove?.Invoke(e);

        }

        private void GUICanvas_MouseUp(object sender, MouseEventArgs e)
        {
            CanvasMouseClickUp?.Invoke(e);
        }

        private void GUICanvas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CanvasMouseDoubleClick?.Invoke(e);

        }
        private void GUICanvas_MouseWheel(object sender, MouseEventArgs e)
        {
            CanvasMouseWheel?.Invoke(e);
        }
    }
}
