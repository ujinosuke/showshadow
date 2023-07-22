using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoshado.Parts
{
    public class PartsBase
    {
        public string Name { set; get; }
        public int X { set; get; }
        public int Y { set; get; }

        public PartsBase(string name)
        {
            Name = name;
        }

        public virtual void OnPaint(object sender, PaintEventArgs e)
        {

        }
    }
}
