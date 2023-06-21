using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoshado.Canvas
{
    public partial class GUICanvas : UserControl
    {
        private HatchStyle gridHs;
        private HatchBrush gridBrush;

        public GUICanvas()
        {
            InitializeComponent();
            gridHs = HatchStyle.DottedGrid;
            gridBrush = new HatchBrush(gridHs, Color.LightGray, Color.White);
        }

        private void GUICanvas_Load(object sender, EventArgs e)
        {

        }

        private void GUICanvas_Paint(object sender, PaintEventArgs e)
        {
            var update_rect = e.ClipRectangle;

            e.Graphics.FillRectangle(gridBrush, update_rect);

        }
    }
}
