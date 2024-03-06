using System;
using System.Data;
using System.Windows.Forms;

namespace Shoppa
{
    public partial class uiManageTool : UserControl
    {
        private SQL_Services mySqlServices = new SQL_Services();
        private string AccountID;
        private string RoleID;

        private frmManageOrder frmManageOrder;
        private frmManageAccount frmManageAccount;
        private frmManageProduct frmManageProduct;
        private frmManageCategory frmManageCategory;
        private frmManageCoupon frmManageCoupon;

        public uiManageTool()
        {
            InitializeComponent();
        }

        public void Initialize(string AccountID)
        {
            this.AccountID = AccountID;
            mySqlServices.AddParamater("@AccountID", AccountID);

            DataTable dataTable = mySqlServices.ExecuteQueryTable("SELECT Name, RoleName, Accounts.RoleID\r\nFROM Accounts\r\nJOIN Roles ON Roles.RoleID = Accounts.RoleID\r\nWHERE AccountID = @AccountID");

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
            if (RoleID == "3")
            {
                frmManageOrder = new frmManageOrder();
                frmManageOrder.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này.");
            }
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
                frmManageCategory = new frmManageCategory();
                frmManageCategory.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này.");
            }
        }

        private void btnManageCoupon_Click(object sender, EventArgs e)
        {
            if (RoleID == "3")
            {
                frmManageCoupon = new frmManageCoupon();
                frmManageCoupon.Initialize(AccountID);
                frmManageCoupon.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này.");
            }
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            if (RoleID == "3")
            {
                ClickOnStatistic?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này.");
            }
        }

        public event EventHandler ClickOnStatistic;

        private void uiManageTool_SizeChanged(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = this.Width;
            bunifuSeparator2.Width = this.Width;
        }
    }
}
