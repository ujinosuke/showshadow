using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoshado.Parts
{
    public class Rectangle : PartsBase
    {
        public int Width { set; get; } = 20;
        public int Height { set; get; } = 20;

        public Rectangle(string name) : base(name) { }

        public override void OnPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(sender, e);
        }
    }
}
