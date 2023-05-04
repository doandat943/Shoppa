using System;
using System.Data;
using System.Windows.Forms;

namespace Shoppa
{
    public partial class frmRegister : Form
    {
        private SQL_Services mySqlServices = new SQL_Services();

        public frmRegister()
        {
            InitializeComponent(); 

            DataTable dtGender = mySqlServices.ExecuteQueryTable("Select *From Genders");
            cboGender.DataSource = dtGender;
            cboGender.DisplayMember = "GenderName";
            cboGender.ValueMember = "GenderID";

            DataTable dtProvince = mySqlServices.ExecuteQueryTable("Select *From Provinces");
            cboProvince.DataSource = dtProvince;
            cboProvince.DisplayMember = "ProvinceName";
            cboProvince.ValueMember = "ProvinceID";

            cboGender.SelectedIndex = 0;
            cboProvince.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
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
            else if (txtRePassword.Text == "" || txtRePassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp. Vui lòng nhập lại Mật khẩu");
                txtRePassword.Focus();
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tên của bạn");
                txtName.Focus();
            }
            else if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại của bạn");
                txtPhoneNumber.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Địa chỉ của bạn");
                txtAddress.Focus();
            }
            else
            {
                string AccountID = txtAccountID.Text;

                mySqlServices.AddParamater("@AccountID", AccountID);
                mySqlServices.AddParamater("@Password", txtPassword.Text);
                mySqlServices.AddParamater("@Name", txtName.Text);
                mySqlServices.AddParamater("@PhoneNumber", txtPhoneNumber.Text);
                mySqlServices.AddParamater("@Email", txtEmail.Text);
                mySqlServices.AddParamater("@Address", txtAddress.Text);
                mySqlServices.AddParamater("@ProvinceID", cboProvince.SelectedValue.ToString());
                mySqlServices.AddParamater("@GenderID", cboGender.SelectedValue.ToString());

                if (mySqlServices.CheckExist("Accounts", "AccountID"))
                {
                    MessageBox.Show("Tên tài khoản: \"" + txtAccountID.Text + "\" đã tồn tại. Vui lòng nhập Tên tài khoản khác");
                    txtAccountID.Focus();
                }
                else if (mySqlServices.CheckExist("Accounts", "PhoneNumber"))
                {
                    MessageBox.Show("Số điện thoại: \"" + txtPhoneNumber.Text + "\" đã được liên kết với tài khoản khác. Vui lòng nhập Số điện thoại khác");
                    txtPassword.Focus();
                }
                else
                {
                    int temp = mySqlServices.ExecuteNonQuery(@"Insert Into Accounts Values (@AccountID, @Password, @Name, @PhoneNumber, @Email, @Address, @ProvinceID, @GenderID, 0, 'C:\Users\doandat943\source\repos\study\Shoppa\bin\Debug\Data\AccountImage\user_500pxx.png')");
                    if (temp == 1)
                    {
                        MessageBox.Show("Tạo tài khoản thành công. Mời bạn đăng nhập.");
                        this.Close();
                    }
                }
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtRePassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtRePassword.PasswordChar = '*';
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
