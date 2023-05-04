using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoppa
{
    public partial class frmChangePassword : Form
    {
        private SQL_Services mySqlServices = new SQL_Services();
        private string AccountID;
        private bool AdminMode;

        public frmChangePassword(string AccountID, bool AdminMode = false)
        {
            InitializeComponent();

            this.AccountID = AccountID;
            this.AdminMode = AdminMode;

            if (AdminMode) txtOldPassword.Enabled = false;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            mySqlServices.AddParamater("@AccountID", AccountID);
            string OldPassword = mySqlServices.ExecuteScalar("Select Password From Accounts Where AccountID = @AccountID").ToString();

            if (AdminMode == false)
            {
                if (txtOldPassword.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập Mật khẩu cũ");
                }
                else if (txtOldPassword.Text != OldPassword)
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác. Vui lòng thử lại!!!");
                }

                txtOldPassword.Focus();
            }
            else if (txtNewPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu mới");
                txtNewPassword.Focus();
            }
            else if (txtRePassword.Text == "" || txtRePassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp. Vui lòng nhập lại Mật khẩu mới");
                txtRePassword.Focus();
            }
            else
            {
                mySqlServices.AddParamater("@NewPassword", txtNewPassword.Text);
                if (mySqlServices.ExecuteNonQuery("Update Accounts Set Password = @NewPassword Where AccountID = @AccountID") == 1)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                }
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtOldPassword.PasswordChar = '\0';
                txtNewPassword.PasswordChar = '\0';
                txtRePassword.PasswordChar = '\0';
            }
            else
            {
                txtOldPassword.PasswordChar = '*';
                txtNewPassword.PasswordChar = '*';
                txtRePassword.PasswordChar = '*';
            }
        }
    }
}
