using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Shoshado.Parts
{
    public class PartsRectangle : PartsBase
    {
        public int Width { set; get; } = 40;
        public int Height { set; get; } = 40;

        public PartsRectangle(string name) : base(name) { }

        public override void OnPaint(Style style, object sender, PaintEventArgs e)
        {
            var color =
                style == Style.Select ? Color.Red :
                style == Style.Hover ? Color.Gray :
                Color.Black;

            var pen = new Pen(new SolidBrush(color));
            pen.Width = 2;
            e.Graphics.DrawRectangle(pen, X,Y,Width,Height);
        }

        public override bool InRange(Rectangle rect)
        {
            return rect.IntersectsWith(new Rectangle(X, Y, Width, Height));
        }
    }
}
