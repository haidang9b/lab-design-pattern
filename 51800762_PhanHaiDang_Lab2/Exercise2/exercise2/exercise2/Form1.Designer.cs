
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtError = new System.Windows.Forms.Label();
            this.txtDate = new exercise2.MyTextBox();
            this.txtEmail = new exercise2.MyTextBox();
            this.txtDouble = new exercise2.MyTextBox();
            this.txtString = new exercise2.MyTextBox();
            this.txtInt = new exercise2.MyTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số nguyên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số thực";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chuỗi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày tháng năm";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(187, 305);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(103, 33);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Đồng ý";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.Red;
            this.txtError.Location = new System.Drawing.Point(130, 362);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(0, 20);
            this.txtError.TabIndex = 11;
            this.txtError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(161, 246);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(194, 20);
            this.txtDate.TabIndex = 16;
            this.txtDate.validatorType = exercise2.ValidatorType.Date;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(161, 194);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 20);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.validatorType = exercise2.ValidatorType.Email;
            // 
            // txtDouble
            // 
            this.txtDouble.Location = new System.Drawing.Point(161, 86);
            this.txtDouble.Name = "txtDouble";
            this.txtDouble.Size = new System.Drawing.Size(194, 20);
            this.txtDouble.TabIndex = 14;
            this.txtDouble.validatorType = exercise2.ValidatorType.Double;
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(161, 141);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(194, 20);
            this.txtString.TabIndex = 13;
            this.txtString.validatorType = exercise2.ValidatorType.String;
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(161, 38);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(194, 20);
            this.txtInt.TabIndex = 12;
            this.txtInt.validatorType = exercise2.ValidatorType.Integer;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "(Lưu ý: mm/dd/yyyy)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDouble);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label txtError;
        private MyTextBox txtInt;
        private MyTextBox txtString;
        private MyTextBox txtDouble;
        private MyTextBox txtEmail;
        private MyTextBox txtDate;
        private System.Windows.Forms.Label label6;
    }
}

