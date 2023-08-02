namespace Shoshado.Canvas
{
    partial class GUICanvas
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GUICanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.Name = "GUICanvas";
            this.Size = new System.Drawing.Size(518, 348);
            this.Load += new System.EventHandler(this.GUICanvas_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GUICanvas_Paint);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GUICanvas_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GUICanvas_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GUICanvas_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GUICanvas_MouseUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GUICanvas_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
