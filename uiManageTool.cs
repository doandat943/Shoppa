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
    public partial class uiManageTool : UserControl
    {
        public uiManageTool()
        {
            InitializeComponent();
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            frmManageProduct frmManageProduct = new frmManageProduct();
            frmManageProduct.Show();
        }

        private void btnManageCategory_Click(object sender, EventArgs e)
        {
            frmManageProduct frmManageProduct = new frmManageProduct();
            frmManageProduct.Show();
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            frmTemp frmManageAccount = new frmTemp();
            frmManageAccount.Show();
        }
    }
}
