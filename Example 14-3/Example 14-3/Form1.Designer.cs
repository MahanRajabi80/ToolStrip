namespace Example_14_3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolButtonB = new System.Windows.Forms.ToolStripButton();
            this.toolButtonI = new System.Windows.Forms.ToolStripButton();
            this.toolButtonU = new System.Windows.Forms.ToolStripButton();
            this.toolCmbSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolButtonLeft = new System.Windows.Forms.ToolStripButton();
            this.toolButtonCenter = new System.Windows.Forms.ToolStripButton();
            this.toolButtonRight = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolButtonB,
            this.toolButtonI,
            this.toolButtonU,
            this.toolCmbSize,
            this.toolButtonLeft,
            this.toolButtonCenter,
            this.toolButtonRight});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(444, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolButtonB
            // 
            this.toolButtonB.BackColor = System.Drawing.Color.Transparent;
            this.toolButtonB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonB.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonB.Image")));
            this.toolButtonB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolButtonB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonB.Margin = new System.Windows.Forms.Padding(1);
            this.toolButtonB.Name = "toolButtonB";
            this.toolButtonB.Size = new System.Drawing.Size(23, 23);
            this.toolButtonB.Text = "toolStripButton1";
            this.toolButtonB.ToolTipText = "Bold";
            // 
            // toolButtonI
            // 
            this.toolButtonI.BackColor = System.Drawing.Color.Transparent;
            this.toolButtonI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonI.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonI.Image")));
            this.toolButtonI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolButtonI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonI.Margin = new System.Windows.Forms.Padding(1);
            this.toolButtonI.Name = "toolButtonI";
            this.toolButtonI.Size = new System.Drawing.Size(23, 23);
            this.toolButtonI.Text = "toolStripButton1";
            this.toolButtonI.ToolTipText = "Italic";
            // 
            // toolButtonU
            // 
            this.toolButtonU.BackColor = System.Drawing.Color.Transparent;
            this.toolButtonU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonU.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonU.Image")));
            this.toolButtonU.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolButtonU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonU.Margin = new System.Windows.Forms.Padding(1);
            this.toolButtonU.Name = "toolButtonU";
            this.toolButtonU.Size = new System.Drawing.Size(23, 23);
            this.toolButtonU.Text = "toolStripButton1";
            this.toolButtonU.ToolTipText = "Underline";
            // 
            // toolCmbSize
            // 
            this.toolCmbSize.AutoToolTip = true;
            this.toolCmbSize.Margin = new System.Windows.Forms.Padding(1);
            this.toolCmbSize.Name = "toolCmbSize";
            this.toolCmbSize.Size = new System.Drawing.Size(75, 23);
            this.toolCmbSize.ToolTipText = "Font Size";
            this.toolCmbSize.TextChanged += new System.EventHandler(this.toolCmbSize_TextChanged);
            // 
            // toolButtonLeft
            // 
            this.toolButtonLeft.BackColor = System.Drawing.Color.Transparent;
            this.toolButtonLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonLeft.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonLeft.Image")));
            this.toolButtonLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolButtonLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonLeft.Margin = new System.Windows.Forms.Padding(1);
            this.toolButtonLeft.Name = "toolButtonLeft";
            this.toolButtonLeft.Size = new System.Drawing.Size(23, 23);
            this.toolButtonLeft.Text = "toolStripButton1";
            this.toolButtonLeft.ToolTipText = "Align Text Left";
            // 
            // toolButtonCenter
            // 
            this.toolButtonCenter.BackColor = System.Drawing.Color.Transparent;
            this.toolButtonCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonCenter.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonCenter.Image")));
            this.toolButtonCenter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolButtonCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonCenter.Margin = new System.Windows.Forms.Padding(1);
            this.toolButtonCenter.Name = "toolButtonCenter";
            this.toolButtonCenter.Size = new System.Drawing.Size(23, 23);
            this.toolButtonCenter.Text = "toolStripButton1";
            this.toolButtonCenter.ToolTipText = "Center";
            // 
            // toolButtonRight
            // 
            this.toolButtonRight.BackColor = System.Drawing.Color.Transparent;
            this.toolButtonRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonRight.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonRight.Image")));
            this.toolButtonRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolButtonRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonRight.Margin = new System.Windows.Forms.Padding(1);
            this.toolButtonRight.Name = "toolButtonRight";
            this.toolButtonRight.Size = new System.Drawing.Size(23, 23);
            this.toolButtonRight.Text = "toolStripButton1";
            this.toolButtonRight.ToolTipText = "Align Text Right";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(22, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 263);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Example 14-3 (ToolStrip)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripButton toolButtonB;
        private System.Windows.Forms.ToolStripButton toolButtonI;
        private System.Windows.Forms.ToolStripButton toolButtonU;
        private System.Windows.Forms.ToolStripComboBox toolCmbSize;
        private System.Windows.Forms.ToolStripButton toolButtonLeft;
        private System.Windows.Forms.ToolStripButton toolButtonCenter;
        private System.Windows.Forms.ToolStripButton toolButtonRight;
    }
}

