namespace exercise13
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolCircle = new System.Windows.Forms.ToolStripButton();
            this.toolSolidCircle = new System.Windows.Forms.ToolStripButton();
            this.toolRectangle = new System.Windows.Forms.ToolStripButton();
            this.toolSolidRectangle = new System.Windows.Forms.ToolStripButton();
            this.toolSquare = new System.Windows.Forms.ToolStripButton();
            this.toolColor = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCircle,
            this.toolSolidCircle,
            this.toolRectangle,
            this.toolSolidRectangle,
            this.toolSquare,
            this.toolColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(418, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolCircle
            // 
            this.toolCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolCircle.Image = ((System.Drawing.Image)(resources.GetObject("toolCircle.Image")));
            this.toolCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCircle.Name = "toolCircle";
            this.toolCircle.Size = new System.Drawing.Size(41, 22);
            this.toolCircle.Text = "Circle";
            this.toolCircle.Click += new System.EventHandler(this.toolCircle_Click);
            // 
            // toolSolidCircle
            // 
            this.toolSolidCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSolidCircle.Image = ((System.Drawing.Image)(resources.GetObject("toolSolidCircle.Image")));
            this.toolSolidCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSolidCircle.Name = "toolSolidCircle";
            this.toolSolidCircle.Size = new System.Drawing.Size(68, 22);
            this.toolSolidCircle.Text = "Solid circle";
            this.toolSolidCircle.Click += new System.EventHandler(this.toolSolidCircle_Click);
            // 
            // toolRectangle
            // 
            this.toolRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolRectangle.Image = ((System.Drawing.Image)(resources.GetObject("toolRectangle.Image")));
            this.toolRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRectangle.Name = "toolRectangle";
            this.toolRectangle.Size = new System.Drawing.Size(63, 22);
            this.toolRectangle.Text = "Rectangle";
            this.toolRectangle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolRectangle.Click += new System.EventHandler(this.toolRectangle_Click);
            // 
            // toolSolidRectangle
            // 
            this.toolSolidRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSolidRectangle.Image = ((System.Drawing.Image)(resources.GetObject("toolSolidRectangle.Image")));
            this.toolSolidRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSolidRectangle.Name = "toolSolidRectangle";
            this.toolSolidRectangle.Size = new System.Drawing.Size(92, 22);
            this.toolSolidRectangle.Text = "Solid Rectangle";
            this.toolSolidRectangle.ToolTipText = "Solid Rectangle";
            this.toolSolidRectangle.Click += new System.EventHandler(this.toolSolidRectangle_Click);
            // 
            // toolSquare
            // 
            this.toolSquare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSquare.Image = ((System.Drawing.Image)(resources.GetObject("toolSquare.Image")));
            this.toolSquare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSquare.Name = "toolSquare";
            this.toolSquare.Size = new System.Drawing.Size(47, 22);
            this.toolSquare.Text = "Square";
            this.toolSquare.Click += new System.EventHandler(this.toolSquare_Click);
            // 
            // toolColor
            // 
            this.toolColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolColor.Image = ((System.Drawing.Image)(resources.GetObject("toolColor.Image")));
            this.toolColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolColor.Name = "toolColor";
            this.toolColor.Size = new System.Drawing.Size(23, 22);
            this.toolColor.Text = " ";
            this.toolColor.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 312);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "Draw shape";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSolidCircle;
        private System.Windows.Forms.ToolStripButton toolCircle;
        private System.Windows.Forms.ToolStripButton toolColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton toolRectangle;
        private System.Windows.Forms.ToolStripButton toolSolidRectangle;
        private System.Windows.Forms.ToolStripButton toolSquare;
    }
}

