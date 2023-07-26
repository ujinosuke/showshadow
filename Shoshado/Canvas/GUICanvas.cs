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
        private List<Parts.PartsBase> parts = new List<Parts.PartsBase>();
        private Parts.PartsBase hoverParts = null;

        public GUICanvas()
        {
            InitializeComponent();
            MouseWheel += GUICanvas_MouseWheel;
            gridHs = HatchStyle.DottedGrid;
            gridBrush = new HatchBrush(gridHs, Color.LightGray, Color.White);

            parts.Add(new Parts.PartsRectangle("Test Rectangle"));
        }



        private void GUICanvas_Load(object sender, EventArgs e)
        {

        }

        private void GUICanvas_Paint(object sender, PaintEventArgs e)
        {
            var update_rect = e.ClipRectangle;

            e.Graphics.FillRectangle(gridBrush, update_rect);

            foreach(var part in parts)
            {
                if (part == hoverParts) continue;
                if( part.InRange(update_rect))
                {
                    part.OnPaint( Parts.PartsBase.Style.Nomal, sender, e);
                }
            }

            if(hoverParts != null)
            {
                if(hoverParts.InRange(update_rect))
                {
                    hoverParts.OnPaint(Parts.PartsBase.Style.Hover, sender, e);
                }
            }


        }
    }
}
