using System;
using System.Windows.Forms;

namespace Shoppa
{
    public partial class frmLogin : Form
    {
        private SQL_Services mySqlServices = new SQL_Services();

        public frmLogin()
        {
            InitializeComponent();
            
            mySqlServices.OpenDB("Server=cloud.joverse.me;Port=3001;Database=Shoppa;Uid=root;Pwd=kinhvanhoa0;");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAccountID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tên tài khoản");
                txtAccountID.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu");
                txtPassword.Focus();
            }
            else
            {
                string AccountID = txtAccountID.Text;
                mySqlServices.AddParamater("@AccountID", AccountID);
                mySqlServices.AddParamater("@Password", txtPassword.Text);
                object result = mySqlServices.ExecuteScalar("SELECT RoleID FROM Accounts WHERE AccountID = @AccountID AND Password = @Password");
                int temp = result != "" ? Convert.ToInt32(result) : -2;
                if (temp == -2)
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác. Vui lòng thử lại!!!");
                }
                else if (temp == -1)
                {
                    MessageBox.Show("Tài khoản của bạn đã bị đóng. Vui lòng liên hệ kĩ thuật của Shoppa để nhận được hỗ trợ!!!");
                }
                else
                {
                    frmMain frmMain = new frmMain();
                    frmMain.Initialize(AccountID);
                    frmMain.FormClosed += frmMain_FormClosed;
                    this.Hide();
                    frmMain.ShowDialog();
                }
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            mySqlServices.CloseDB();
        }
    }
}
