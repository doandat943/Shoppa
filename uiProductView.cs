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
    public partial class uiProductView : UserControl
    {
        private SQL_Services mySqlServices = new SQL_Services();

        public uiProductView()
        {
            InitializeComponent();

            DataTable dtCategoryFilter = mySqlServices.ExecuteQueryTable("Select * From Categories");
            cboCategoryFilter.DataSource = dtCategoryFilter;
            cboCategoryFilter.DisplayMember = "CategoryName";
            cboCategoryFilter.ValueMember = "CategoryID";

            Load();
        }

        public void Load(string filter = "")
        {
            DataTable dataTable = mySqlServices.ExecuteQueryTable("Select ProductName, Price, COUNT(OrderDetail.ProductID) AS Sold, ProductImage, CategoryID  From Products\r\nLEFT JOIN dbo.OrderDetail ON OrderDetail.ProductID = Products.ProductID\r\n" + filter +"\r\nGROUP BY ProductName, Price, ProductImage, CategoryID");

            if (dataTable.Rows.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    pnProductItem productItem = new pnProductItem();

                    productItem.Set_ProductName = row[0].ToString();
                    productItem.Set_Price = row[1].ToString();
                    productItem.Set_Sold = "Đã bán: " + row[2];
                    productItem.Set_ProductImage = row[3].ToString();

                    flowLayoutPanel1.Controls.Add(productItem);
                }
            }
        }

        private void uiProductView_SizeChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = this.Height - flowLayoutPanel4.Height;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Load("WHERE ProductName LIKE N'%" + txtSearchBox.Text + "%'");
        }

        private void btnCategoryFilter_Click(object sender, EventArgs e)
        {
            if (cboCategoryFilter.SelectedValue == "-1")
            {
                Load();
            }
            else
            {
                Load("Where CategoryID = " + cboCategoryFilter.SelectedValue);
            }
        }
    }
}
