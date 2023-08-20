using Shoshado.Parts;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        public Action<Point, MouseEventArgs> CanvasMouseDrag = null;


        private class MouseContext
        {
            public Action<MouseEventArgs> LeftClick = null;
            public Action<MouseEventArgs> RightClick = null;
            public Action<MouseEventArgs> Moving = null;
            public Action<Point,MouseEventArgs> Dragging = null;

            public Point ClickPoint = new Point();
            public Point DragPrevPoint = new Point();

            public void Down(MouseEventArgs e)
            {
                if( e.Button == MouseButtons.Left)
                {
                    ClickPoint = e.Location;
                    DragPrevPoint = ClickPoint;
                    LeftClick?.Invoke(e);
                }
                else if ( e.Button == MouseButtons.Right)
                {
                    RightClick?.Invoke(e);
                }

            }

            public void Up(MouseEventArgs e)
            {
            }

            public void Move(MouseEventArgs e)
            {
                if(e.Button == MouseButtons.Left)
                {
                    if (ClickPoint != e.Location)
                    {
                        Dragging?.Invoke(DragPrevPoint, e);
                        DragPrevPoint = e.Location;
                    }
                }
                else if ( e.Button == MouseButtons.None)
                {
                    Moving?.Invoke(e);
                }
            }

        }

        private MouseContext mouseContext = new MouseContext();

        private void GUICanvas_MouseActivate()
        {
            mouseContext.LeftClick += (e) =>
            {

                var loc = e.Location;
                PartsBase selected = null;

                foreach (var p in parts)
                {
                    if (p.InRange(loc))
                    {
                        selected = p;
                        break;

                    }
                }
                if (selected != selectedOne)
                {
                    GUICanvas_DebugPropertySelectOne(selected);
                    selectedOne = selected;
                    Invalidate();
                }
            };

            mouseContext.RightClick += (e) =>
            {
                var loc = e.Location;

            };

            mouseContext.Moving += (e) =>
            {

                var loc = e.Location;
                PartsBase hover = null;

                //Check Hover
                foreach (var p in parts)
                {
                    if (p.InRange(loc))
                    {
                        hover = p;
                        break;
                    }
                }

                if (hover != hoverParts)
                {
                    GUICanvas_DebugPropertyHover(hover);
                    hoverParts = hover;
                    Invalidate();
                }
            };

            mouseContext.Dragging += (p, e) =>
            {
                CanvasMouseDrag?.Invoke(p, e);
                var loc = e.Location;

                if(selectedOne != null)
                {
                    var delta_x = loc.X - p.X;
                    var delta_y = loc.Y - p.Y;

                    selectedOne.X += delta_x;
                    selectedOne.Y += delta_y;
                    Invalidate();
                }

            };


        }


        private void GUICanvas_MouseDown(object sender, MouseEventArgs e)
        {
            mouseContext.Down(e);
            CanvasMouseClick?.Invoke(e);
        }

        private void GUICanvas_MouseMove(object sender, MouseEventArgs e)
        {
            mouseContext.Move(e);
            CanvasMouseMove?.Invoke(e);

        }

        private void GUICanvas_MouseUp(object sender, MouseEventArgs e)
        {
            mouseContext.Up(e);
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
