using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoshado.Canvas
{
    partial class GUICanvas
    {
        public Action<bool /*isDirtyFile*/> EventUndoStateChange = null;
    }
}
