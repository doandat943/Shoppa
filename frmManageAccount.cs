using System;
using System.Data;
using System.Windows.Forms;

namespace Shoppa
{
    public partial class frmManageAccount : Form
    {
        private SQL_Services mySqlServices = new SQL_Services();
        
        private uiAccountView uiAccountView = new uiAccountView();
        private string AccountID;

        public frmManageAccount()
        {
            InitializeComponent();

            //
            DataTable dtRole = mySqlServices.ExecuteQueryTable("Select *From Roles");
            cboRole.DataSource = dtRole;
            cboRole.DisplayMember = "RoleName";
            cboRole.ValueMember = "RoleID";

            DataTable dtRoleFilter = mySqlServices.ExecuteQueryTable("Select *From Roles");
            cboRoleFilter.DataSource = dtRoleFilter;
            cboRoleFilter.DisplayMember = "RoleName";
            cboRoleFilter.ValueMember = "RoleID";

            DataTable dtProvince = mySqlServices.ExecuteQueryTable("Select *From Provinces");
            cboProvince.DataSource = dtProvince;
            cboProvince.DisplayMember = "ProvinceName";
            cboProvince.ValueMember = "ProvinceID";


            //
            Load();
        }

        private void Load(string filter = null)
        {
            string sSQL = "SELECT * FROM Accounts\r\n" + filter;
            dataGridView1.DataSource = mySqlServices.ExecuteQueryTable(sSQL);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            AccountID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtAccountID.Text = AccountID;
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cboRole.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            cboProvince.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            uiAccountView.Initialize(AccountID, true);
            //
            Form frmAccountView = new Form();
            frmAccountView.Text = "Chỉnh sửa thông tin người dùng";
            frmAccountView.FormBorderStyle = FormBorderStyle.FixedSingle;
            frmAccountView.StartPosition = FormStartPosition.CenterScreen;
            frmAccountView.MaximizeBox = false;
            frmAccountView.AutoSize = true;
            frmAccountView.Controls.Add(uiAccountView);
            frmAccountView.ShowDialog();
            Load();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Load("WHERE Name LIKE N'%" + txtSearch.Text + "%'");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cboRoleFilter.SelectedValue.ToString() == "-1")
            {
                Load();
            }
            else
            {
                Load("Where RoleID = " + cboRoleFilter.SelectedValue);
            }
        }
    }
}
