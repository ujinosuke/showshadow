using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shoshado.Canvas;

namespace Shoshado
{
    public partial class Form1 : Form
    {
        #region Parameter/Variables/Constants

        private GUICanvas Canvas;
        private ScrollPanel CanvasPanel = new ScrollPanel();
        private DebugView DebugView = new DebugView();

        public Action<int /*x*/, int /*y*/, int /*w*/, int /*h*/> EventWindowChange;

        private string _filepath = "";
        private bool _modified = false;

        #endregion

        public Form1()
        {
            InitializeComponent();
            createCanvas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetTitle(false);

            DebugView.Activate();
#if DEBUG
            DebugView.Show();
#endif
            Canvas.CanvasMouseMove += DebugView.DebugMouseMove;
            Canvas.CanvasMouseClick += DebugView.DebugMouseClick;
            Canvas.CanvasMouseClickUp += DebugView.DebugMouseClickUp;
            Canvas.CanvasMouseDoubleClick += DebugView.DebugMouseDoubleClick;
            Canvas.CanvasMouseWheel += DebugView.DebugMouseWheel;
            Canvas.CanvasPreviewKeyDown += DebugView.DebugKeyDown;

        }

        public void SetTitle(bool fModify)
        {
            _modified = fModify;
            string mark = (fModify) ? "*" : "";
            string filename = (_filepath == "") ? "New file" : System.IO.Path.GetFileName(_filepath);
            string projectName = "No Project";
            string text = string.Format("Shoshado: {0} / {1} - {2}", projectName, filename, mark);
            this.Text = text;

        }
        /// <summary>
        /// Canvasの生成
        /// </summary>
        private void createCanvas()
        {
            Canvas = new GUICanvas();
            Canvas.Visible = false;
            Canvas.EventUndoStateChange += SetTitle;
            CanvasPanel.AutoScroll = true;
            CanvasPanel.BorderStyle = BorderStyle.Fixed3D;
            CanvasPanel.SetBounds(0, menuStrip1.Height, ClientSize.Width, ClientSize.Height - menuStrip1.Height /*- statusStrip1.Height*/);
            CanvasPanel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.Controls.Add(CanvasPanel);
            CanvasPanel.Controls.Add(Canvas);
            Canvas.SetBounds(0, 0, CanvasPanel.ClientSize.Width, CanvasPanel.ClientSize.Height);
            CanvasPanel.EventScrollChanged += EventAutoScrollChanged;
        }

        private void EventAutoScrollChanged()
        {
            int x = CanvasPanel.AutoScrollPosition.X;
            int y = CanvasPanel.AutoScrollPosition.Y;
            int w = ClientSize.Width;
            int h = ClientSize.Height - menuStrip1.Height/* - statusStrip1.Height*/;
            EventWindowChange?.Invoke(-x, -y, w, h);
        }

        private void 新規作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas.Visible = true;
        }

        private void debugViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebugView.Activate();
            DebugView.Show();
        }

        private void 四角ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
