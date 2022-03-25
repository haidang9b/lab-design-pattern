using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            string messageError = "";

            if (!txtInt.runValidation())
            {
                messageError = "Số nguyên không hợp lệ";
            }
            else if (!txtDouble.runValidation())
            {
                messageError = "Số thực không hợp lệ";
            }
            else if (!txtString.runValidation())
            {
                messageError = "Chuỗi không hợp lệ";
            }
            else if (!txtEmail.runValidation())
            {
                messageError = "Email không hợp lệ";
            }
            else if (!txtDate.runValidation())
            {
                messageError = "Ngày tháng năm không hợp lệ";
            }
            else
            {
                messageError = "";
            }


            if (messageError.Length > 0)
            {
                SetError(messageError);
            }
            else
            {
                SetSuccess();
            }
            
        }
        private void SetError(string error)
        {
            txtError.ForeColor = Color.Red;
            txtError.Text = error;
        }
        private void SetSuccess()
        {
            txtError.ForeColor = Color.Green;
            txtError.Text = "Bạn đã nhập đúng đầy đủ";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
