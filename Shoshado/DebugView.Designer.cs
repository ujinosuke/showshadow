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
            this.components = new System.ComponentModel.Container();
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
            this.propertyHover = new System.Windows.Forms.PropertyGrid();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.propertySelectOne = new System.Windows.Forms.PropertyGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMouseDrag = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mouse Move";
            // 
            // txtMouse
            // 
            this.txtMouse.Enabled = false;
            this.txtMouse.Location = new System.Drawing.Point(129, 69);
            this.txtMouse.Name = "txtMouse";
            this.txtMouse.Size = new System.Drawing.Size(201, 19);
            this.txtMouse.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mouse Click";
            // 
            // txtMouseClick
            // 
            this.txtMouseClick.Enabled = false;
            this.txtMouseClick.Location = new System.Drawing.Point(129, 101);
            this.txtMouseClick.Name = "txtMouseClick";
            this.txtMouseClick.Size = new System.Drawing.Size(201, 19);
            this.txtMouseClick.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mouse Double Click";
            // 
            // txtMouseDoubleClick
            // 
            this.txtMouseDoubleClick.Enabled = false;
            this.txtMouseDoubleClick.Location = new System.Drawing.Point(129, 136);
            this.txtMouseDoubleClick.Name = "txtMouseDoubleClick";
            this.txtMouseDoubleClick.Size = new System.Drawing.Size(201, 19);
            this.txtMouseDoubleClick.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 18);
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
            this.label4.Location = new System.Drawing.Point(3, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mouse Wheel";
            // 
            // txtMouseWheel
            // 
            this.txtMouseWheel.Enabled = false;
            this.txtMouseWheel.Location = new System.Drawing.Point(129, 171);
            this.txtMouseWheel.Name = "txtMouseWheel";
            this.txtMouseWheel.Size = new System.Drawing.Size(201, 19);
            this.txtMouseWheel.TabIndex = 8;
            // 
            // txtKeyDown
            // 
            this.txtKeyDown.Enabled = false;
            this.txtKeyDown.Location = new System.Drawing.Point(129, 237);
            this.txtKeyDown.Name = "txtKeyDown";
            this.txtKeyDown.Size = new System.Drawing.Size(201, 19);
            this.txtKeyDown.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Key Down";
            // 
            // propertyHover
            // 
            this.propertyHover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyHover.Location = new System.Drawing.Point(0, 0);
            this.propertyHover.Name = "propertyHover";
            this.propertyHover.Size = new System.Drawing.Size(359, 378);
            this.propertyHover.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 378);
            this.splitContainer1.SplitterDistance = 702;
            this.splitContainer1.TabIndex = 12;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.propertySelectOne);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.propertyHover);
            this.splitContainer2.Size = new System.Drawing.Size(702, 378);
            this.splitContainer2.SplitterDistance = 339;
            this.splitContainer2.TabIndex = 12;
            // 
            // propertySelectOne
            // 
            this.propertySelectOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertySelectOne.Location = new System.Drawing.Point(0, 0);
            this.propertySelectOne.Name = "propertySelectOne";
            this.propertySelectOne.Size = new System.Drawing.Size(339, 378);
            this.propertySelectOne.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMouseDrag);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKeyDown);
            this.groupBox1.Controls.Add(this.txtMouse);
            this.groupBox1.Controls.Add(this.txtMouseWheel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMouseClick);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMouseDoubleClick);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 378);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation";
            // 
            // txtMouseDrag
            // 
            this.txtMouseDrag.Enabled = false;
            this.txtMouseDrag.Location = new System.Drawing.Point(129, 202);
            this.txtMouseDrag.Name = "txtMouseDrag";
            this.txtMouseDrag.Size = new System.Drawing.Size(201, 19);
            this.txtMouseDrag.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mouse Drag";
            // 
            // DebugView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 378);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DebugView";
            this.Text = "DebugView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DebugView_FormClosing);
            this.Load += new System.EventHandler(this.DebugView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PropertyGrid propertyHover;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PropertyGrid propertySelectOne;
        private System.Windows.Forms.TextBox txtMouseDrag;
        private System.Windows.Forms.Label label6;
    }
}