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
    public partial class uiAccountView : UserControl
    {
        private SQL_Services mySqlServices = new SQL_Services();
        private string AccountID;
        private bool AdminMode;

        public uiAccountView()
        {
            InitializeComponent();

            DataTable dtGender = mySqlServices.ExecuteQueryTable("Select *From Genders");
            cboGender.DataSource = dtGender;
            cboGender.DisplayMember = "GenderName";
            cboGender.ValueMember = "GenderID";

            DataTable dtRole = mySqlServices.ExecuteQueryTable("Select *From Roles Where RoleID != -1");
            cboRole.DataSource = dtRole;
            cboRole.DisplayMember = "RoleName";
            cboRole.ValueMember = "RoleID";

            DataTable dtProvince = mySqlServices.ExecuteQueryTable("Select *From Provinces");
            cboProvince.DataSource = dtProvince;
            cboProvince.DisplayMember = "ProvinceName";
            cboProvince.ValueMember = "ProvinceID";
        }

        public void Initialize(string AccountID, bool AdminMode = false)
        {
            this.AccountID = AccountID;
            this.AdminMode = AdminMode;

            if (AdminMode) cboRole.Enabled = true;

            txtAccountID.Text = AccountID;
            mySqlServices.AddParamater("@AccountID", AccountID);

            Load();
        }

        private void Load()
        {
            DataTable dataTable = mySqlServices.ExecuteQueryTable("Select Name, PhoneNumber, Email, Address, ProvinceID, GenderID, RoleID, Avatar From Accounts Where AccountID = @AccountID");

            if (dataTable.Rows.Count > 0)
            {
                txtName.Text = dataTable.Rows[0][0].ToString();
                txtPhoneNumber.Text = dataTable.Rows[0][1].ToString();
                txtEmail.Text = dataTable.Rows[0][2].ToString();
                txtAddress.Text = dataTable.Rows[0][3].ToString();
                cboProvince.SelectedValue = (int)dataTable.Rows[0][4];
                cboGender.SelectedValue = (int)dataTable.Rows[0][5];
                cboRole.SelectedValue = (int)dataTable.Rows[0][6];
                pbAvatar.ImageLocation = dataTable.Rows[0][7].ToString();
            }
            else
            {
                MessageBox.Show("Truy vấn thông tin tài khoản không thành công");
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(AccountID, AdminMode);
            frmChangePassword.ShowDialog();
        }

        private void btnSelectAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            pbAvatar.ImageLocation = openFileDialog.FileName;
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            mySqlServices.AddParamater("@Name", txtName.Text);
            mySqlServices.AddParamater("@PhoneNumber", txtPhoneNumber.Text);
            mySqlServices.AddParamater("@Email", txtEmail.Text);
            mySqlServices.AddParamater("@Address", txtAddress.Text);
            mySqlServices.AddParamater("@ProvinceID", cboProvince.SelectedValue.ToString());
            mySqlServices.AddParamater("@GenderID", cboGender.SelectedValue.ToString());
            mySqlServices.AddParamater("@Avatar", pbAvatar.ImageLocation);

            mySqlServices.AddParamater("@AccountID", AccountID);
            mySqlServices.AddParamater("@RoleID", cboRole.SelectedValue.ToString());

            if (mySqlServices.CheckExist("Accounts", "PhoneNumber", "AccountID != @AccountID"))
            {
                MessageBox.Show("Số điện thoại: \"" + txtPhoneNumber.Text + "\" đã liên kết với tài khoản khác. Vui lòng nhập Số điện thoại khác");
                txtPhoneNumber.Focus();
            }
            else
            {
                int temp = mySqlServices.ExecuteNonQuery("Update Accounts Set Name = @Name, PhoneNumber = @PhoneNumber, Email = @Email, Address = @Address, ProvinceID = @ProvinceID, GenderID = @GenderID, RoleID = @RoleID, Avatar = @Avatar Where AccountID = @AccountID");
                if (temp != 0)
                {
                    MessageBox.Show("Cập nhật thông tin tài khoản thành công!!!");
                    Load();
                }
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản chứ?", "Xóa tài khoản", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                mySqlServices.ExecuteNonQuery("Delete From Accounts Where AccountID = @AccountID");
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
