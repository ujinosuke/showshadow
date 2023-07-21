namespace Shoshado
{
    partial class DebugView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMouse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMouseClick = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMouseDoubleClick = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMouseWheel = new System.Windows.Forms.TextBox();
            this.txtKeyDown = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mouse Move";
            // 
            // txtMouse
            // 
            this.txtMouse.Enabled = false;
            this.txtMouse.Location = new System.Drawing.Point(137, 63);
            this.txtMouse.Name = "txtMouse";
            this.txtMouse.Size = new System.Drawing.Size(226, 19);
            this.txtMouse.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mouse Click";
            // 
            // txtMouseClick
            // 
            this.txtMouseClick.Enabled = false;
            this.txtMouseClick.Location = new System.Drawing.Point(137, 95);
            this.txtMouseClick.Name = "txtMouseClick";
            this.txtMouseClick.Size = new System.Drawing.Size(226, 19);
            this.txtMouseClick.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mouse Double Click";
            // 
            // txtMouseDoubleClick
            // 
            this.txtMouseDoubleClick.Enabled = false;
            this.txtMouseDoubleClick.Location = new System.Drawing.Point(137, 130);
            this.txtMouseDoubleClick.Name = "txtMouseDoubleClick";
            this.txtMouseDoubleClick.Size = new System.Drawing.Size(226, 19);
            this.txtMouseDoubleClick.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(14, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mouse Wheel";
            // 
            // txtMouseWheel
            // 
            this.txtMouseWheel.Enabled = false;
            this.txtMouseWheel.Location = new System.Drawing.Point(137, 165);
            this.txtMouseWheel.Name = "txtMouseWheel";
            this.txtMouseWheel.Size = new System.Drawing.Size(226, 19);
            this.txtMouseWheel.TabIndex = 8;
            // 
            // txtKeyDown
            // 
            this.txtKeyDown.Enabled = false;
            this.txtKeyDown.Location = new System.Drawing.Point(137, 206);
            this.txtKeyDown.Name = "txtKeyDown";
            this.txtKeyDown.Size = new System.Drawing.Size(226, 19);
            this.txtKeyDown.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Key Down";
            // 
            // DebugView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 378);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKeyDown);
            this.Controls.Add(this.txtMouseWheel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtMouseDoubleClick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMouseClick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMouse);
            this.Controls.Add(this.label1);
            this.Name = "DebugView";
            this.Text = "DebugView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DebugView_FormClosing);
            this.Load += new System.EventHandler(this.DebugView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMouseClick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMouseDoubleClick;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMouseWheel;
        private System.Windows.Forms.TextBox txtKeyDown;
        private System.Windows.Forms.Label label5;
    }
}