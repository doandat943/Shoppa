using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoppa
{
    public partial class frmLogin : Form
    {
        private SQL_Services mySqlServices = new SQL_Services();

        public frmLogin()
        {
            InitializeComponent();
            
            mySqlServices.OpenDB("Data Source=MACBOOK\\SQLEXPRESS;Initial Catalog=Shoppa;Integrated Security=True");
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
                int temp = int.Parse(mySqlServices.ExecuteScalar("Select COUNT(*) From Accounts Where AccountID = @AccountID and Password = @Password"));
                if (temp != 0)
                {
                    frmMain frmMain = new frmMain();
                    frmMain.Initialize(AccountID);
                    frmMain.FormClosed += frmMain_FormClosed;
                    this.Hide();
                    frmMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác. Vui lòng thử lại!!!");
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
