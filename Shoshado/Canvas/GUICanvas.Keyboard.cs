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
        public Action<PreviewKeyDownEventArgs> CanvasPreviewKeyDown = null;

        private void GUICanvas_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            CanvasPreviewKeyDown?.Invoke(e);
        }
    }
}
