using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Shoshado.Parts
{
    public class PartsBase
    {
        public string Name { set; get; }
        public int X { set; get; }
        public int Y { set; get; }

        public enum Style
        {
            Nomal,
            Select,
            Hover
        }

        public PartsBase(string name)
        {
            Name = name;
        }

        public virtual void OnPaint(Style style, object sender, PaintEventArgs e)
        {

        }

        public virtual bool InRange(Rectangle rect )
        {
            return true;
        }
    }
}
