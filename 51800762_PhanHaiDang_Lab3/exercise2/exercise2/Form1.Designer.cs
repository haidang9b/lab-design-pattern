
namespace exercise2
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
            this.btnVuong = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnThuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVuong
            // 
            this.btnVuong.Location = new System.Drawing.Point(112, 28);
            this.btnVuong.Name = "btnVuong";
            this.btnVuong.Size = new System.Drawing.Size(103, 23);
            this.btnVuong.TabIndex = 0;
            this.btnVuong.Text = "Tam giác vuông";
            this.btnVuong.UseVisualStyleBackColor = true;
            this.btnVuong.Click += new System.EventHandler(this.btnVuong_Click);
            // 
            // btnCan
            // 
            this.btnCan.Location = new System.Drawing.Point(269, 28);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(103, 23);
            this.btnCan.TabIndex = 1;
            this.btnCan.Text = "Tam giác cân";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // btnThuong
            // 
            this.btnThuong.Location = new System.Drawing.Point(435, 28);
            this.btnThuong.Name = "btnThuong";
            this.btnThuong.Size = new System.Drawing.Size(103, 23);
            this.btnThuong.TabIndex = 2;
            this.btnThuong.Text = "Tam giác thường";
            this.btnThuong.UseVisualStyleBackColor = true;
            this.btnThuong.Click += new System.EventHandler(this.btnThuong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThuong);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnVuong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVuong;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnThuong;
    }
}

