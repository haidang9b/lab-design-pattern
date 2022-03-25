namespace exercise4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnDashCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFillCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnDashRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSolidRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnDashSquare = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSquare = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFillSquare = new System.Windows.Forms.ToolStripMenuItem();
            this.toolColor = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.toolColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(910, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDashCircle,
            this.btnCircle,
            this.btnFillCircle});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(50, 22);
            this.toolStripDropDownButton1.Text = "Circle";
            // 
            // btnDashCircle
            // 
            this.btnDashCircle.Name = "btnDashCircle";
            this.btnDashCircle.Size = new System.Drawing.Size(115, 22);
            this.btnDashCircle.Text = "Nét đứt";
            this.btnDashCircle.Click += new System.EventHandler(this.btnDashCircle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(115, 22);
            this.btnCircle.Text = "Nét liền";
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnFillCircle
            // 
            this.btnFillCircle.Name = "btnFillCircle";
            this.btnFillCircle.Size = new System.Drawing.Size(115, 22);
            this.btnFillCircle.Text = "Tô đen";
            this.btnFillCircle.Click += new System.EventHandler(this.btnFillCircle_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDashRectangle,
            this.btnRectangle,
            this.btnSolidRectangle});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(72, 22);
            this.toolStripDropDownButton2.Text = "Rectangle";
            // 
            // btnDashRectangle
            // 
            this.btnDashRectangle.Name = "btnDashRectangle";
            this.btnDashRectangle.Size = new System.Drawing.Size(115, 22);
            this.btnDashRectangle.Text = "Nét đứt";
            this.btnDashRectangle.Click += new System.EventHandler(this.btnDashRectangle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(115, 22);
            this.btnRectangle.Text = "Nét liền";
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnSolidRectangle
            // 
            this.btnSolidRectangle.Name = "btnSolidRectangle";
            this.btnSolidRectangle.Size = new System.Drawing.Size(115, 22);
            this.btnSolidRectangle.Text = "Tô đen";
            this.btnSolidRectangle.Click += new System.EventHandler(this.btnSolidRectangle_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDashSquare,
            this.btnSquare,
            this.btnFillSquare});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(56, 22);
            this.toolStripDropDownButton3.Text = "Square";
            // 
            // btnDashSquare
            // 
            this.btnDashSquare.Name = "btnDashSquare";
            this.btnDashSquare.Size = new System.Drawing.Size(180, 22);
            this.btnDashSquare.Text = "Nét đứt";
            this.btnDashSquare.Click += new System.EventHandler(this.btnDashSquare_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(180, 22);
            this.btnSquare.Text = "Nét liền";
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnFillSquare
            // 
            this.btnFillSquare.Name = "btnFillSquare";
            this.btnFillSquare.Size = new System.Drawing.Size(180, 22);
            this.btnFillSquare.Text = "Tô đen";
            this.btnFillSquare.Click += new System.EventHandler(this.btnFillSquare_Click);
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
            this.ClientSize = new System.Drawing.Size(910, 538);
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
        private System.Windows.Forms.ToolStripButton toolColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnDashCircle;
        private System.Windows.Forms.ToolStripMenuItem btnCircle;
        private System.Windows.Forms.ToolStripMenuItem btnFillCircle;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem btnDashRectangle;
        private System.Windows.Forms.ToolStripMenuItem btnRectangle;
        private System.Windows.Forms.ToolStripMenuItem btnSolidRectangle;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem btnDashSquare;
        private System.Windows.Forms.ToolStripMenuItem btnSquare;
        private System.Windows.Forms.ToolStripMenuItem btnFillSquare;
    }
}

