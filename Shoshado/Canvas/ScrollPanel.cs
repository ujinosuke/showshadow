using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Shoshado.Canvas
{
    public class ScrollPanel : Panel
    {
        public delegate void fnEventScrollChanged();
        public fnEventScrollChanged EventScrollChanged;

        /// <summary>
        /// ScrollToControlをオーバーライド　（フォーカスを失って戻ると、スクロール位置が(0,0)に戻ってしまうため）
        /// http://social.msdn.microsoft.com/Forums/ja-JP/winforms/thread/285b1a48-ce21-47ea-80bf-5601d6014cf7
        /// </summary>
        /// <param name="activeControl"></param>
        /// <returns></returns>
        protected override Point ScrollToControl(Control activeControl)
        {
            return this.AutoScrollPosition;
        }
        protected override void OnScroll(ScrollEventArgs se)
        {
            base.OnScroll(se);
            EventScrollChanged?.Invoke();
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                int x = -this.AutoScrollPosition.X;
                int y = -this.AutoScrollPosition.Y;
                x = x - e.Delta;
                this.AutoScrollPosition = new Point(x, y);
            }
            else
            {
                base.OnMouseWheel(e);
            }
            EventScrollChanged?.Invoke();
        }

        public void GoHome()
        {
            this.AutoScrollPosition = new Point(0, 0);
            EventScrollChanged?.Invoke();
        }
        public void Jump(int x, int y)
        {
            this.AutoScrollPosition = new Point(x, y);
            EventScrollChanged?.Invoke();
        }
        public void CenterJump(int x, int y)
        {
            int width = Width;
            int height = Height;
            this.AutoScrollPosition = new Point(x - width / 2, y - height / 2);
            EventScrollChanged?.Invoke();
        }
        public void ScrollHV(int deltaH, int deltaV)
        {
            int x = -this.AutoScrollPosition.X;
            int y = -this.AutoScrollPosition.Y;
            x = x + deltaH;
            y = y + deltaV;
            this.AutoScrollPosition = new Point(x, y);
            EventScrollChanged?.Invoke();
        }

        public void ScrollHorizontal(int delta)
        {
            ScrollHV(delta, 0);
        }
        public void ScrollVertical(int delta)
        {
            ScrollHV(0, delta);
        }

        readonly int Delta = 30;

        public void Action_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Home:
                    GoHome();
                    break;
                case Keys.Left:
                    ScrollHorizontal(-Delta);
                    break;
                case Keys.Right:
                    ScrollHorizontal(Delta);
                    break;
                case Keys.Up:
                    ScrollVertical(-Delta);
                    break;
                case Keys.Down:
                    ScrollVertical(Delta);
                    break;
                case Keys.PageUp:
                    ScrollVertical(-Delta * 10);
                    break;
                case Keys.PageDown:
                    ScrollVertical(Delta * 10);
                    break;


            }


        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ScrollPanel
            // 
            this.AutoScroll = true;
            this.ResumeLayout(false);

        }

    }
}
