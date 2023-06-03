using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Shoppa
{
    public partial class uiManageTool : UserControl
    {
        private SQL_Services mySqlServices = new SQL_Services();
        private string RoleID;

        
        private frmManageAccount frmManageAccount;
        private frmManageProduct frmManageProduct;
        private frmManageCategory frmManageCategory;

        public uiManageTool()
        {
            InitializeComponent();
        }

        public void Initialize(string AccountID)
        {
            mySqlServices.AddParamater("@AccountID", AccountID);

            DataTable dataTable = mySqlServices.ExecuteQueryTable("SELECT Name, RoleName, Accounts.RoleID\r\nFROM Accounts\r\nJOIN dbo.Roles ON Roles.RoleID = Accounts.RoleID\r\nWHERE AccountID = @AccountID");

            if (dataTable.Rows.Count > 0)
            {

                lbName.Text = dataTable.Rows[0][0].ToString();
                lbRole.Text = dataTable.Rows[0][1].ToString();
                RoleID = dataTable.Rows[0][2].ToString();
            }
            else
            {
                MessageBox.Show("Truy vấn thông tin tài khoản không thành công");
            }
        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            if (RoleID == "3")
            {
                frmManageAccount = new frmManageAccount();
                frmManageAccount.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này.");
            }
                
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            if (RoleID == "3")
            {
                frmManageProduct = new frmManageProduct();
                frmManageProduct.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này.");
            }
        }

        private void btnManageCategory_Click(object sender, EventArgs e)
        {
            if (RoleID == "3")
            {
                frmManageProduct = new frmManageProduct();
                frmManageCategory.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này.");
            }
        }

        private void uiManageTool_SizeChanged(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = this.Width;
            bunifuSeparator2.Width = this.Width;
        }
    }
}
