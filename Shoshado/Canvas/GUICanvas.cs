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
        private Parts.PartsBase selectedOne = null;
        public Action<object> DebugPropetySelecteOne = null;
        public Action<object> DebugPropertyHover = null;

        public GUICanvas()
        {
            InitializeComponent();
            GUICanvas_MouseActivate();

            MouseWheel += GUICanvas_MouseWheel;
            gridHs = HatchStyle.DottedGrid;
            gridBrush = new HatchBrush(gridHs, Color.LightGray, Color.White);

            var p0 = new Parts.PartsRectangle("Rect0");
            var p1 = new Parts.PartsRectangle("Rect1");
            p1.X = 100;
            p1.Y = 100;

            parts.Add(p0);
            parts.Add(p1);
            
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

            if(selectedOne != null)
            {
                if( selectedOne.InRange(update_rect))
                {
                    selectedOne.OnPaint(Parts.PartsBase.Style.Select, sender, e);
                }
            }

            if(hoverParts != null && selectedOne != hoverParts)
            {
                if(hoverParts.InRange(update_rect))
                {
                    hoverParts.OnPaint(Parts.PartsBase.Style.Hover, sender, e);
                }
            }


        }

        private void GUICanvas_DebugPropertyHover(object obj)
        {
            DebugPropertyHover?.Invoke(obj);
        }

        private void GUICanvas_DebugPropertySelectOne(object obj)
        {
            DebugPropetySelecteOne?.Invoke(obj);
        }
    }
}
