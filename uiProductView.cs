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

            //
            DataTable dtCategoryFilter = mySqlServices.ExecuteQueryTable("Select * From Categories");
            cboCategoryFilter.DataSource = dtCategoryFilter;
            cboCategoryFilter.DisplayMember = "CategoryName";
            cboCategoryFilter.ValueMember = "CategoryID";

            //
            Load();
        }

        public void Load(string filter = null)
        {
            DataTable dataTable = mySqlServices.ExecuteQueryTable("Select Products.ProductID, ProductName, Price, COUNT(OrderDetail.ProductID) AS Sold, ProductImage From Products\r\nLEFT JOIN dbo.OrderDetail ON OrderDetail.ProductID = Products.ProductID\r\n" + (filter != null ? "WHERE " + filter : null) + "\r\nGROUP BY Products.ProductID, ProductName, Price, ProductImage");

            if (dataTable.Rows.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    pnProductItem productItem = new pnProductItem();

                    productItem.Set_ProductID = row[0].ToString();
                    productItem.Set_ProductName = row[1].ToString();
                    productItem.Set_Price = row[2].ToString();
                    productItem.Set_Sold = "Đã bán: " + row[3];
                    productItem.Set_ProductImage = row[4].ToString();
                    productItem.ClickOnProduct += productItem_ClickOnProduct;
                    productItem.AddToCart += productItem_AddToCart;

                    flowLayoutPanel1.Controls.Add(productItem);
                }
            }
        }
        
        public event EventHandler<string> ClickOnProduct;
        public event EventHandler<Tuple<string, string>> AddToCart;

        private void productItem_ClickOnProduct(object sender, string ProductID)
        {
            ClickOnProduct?.Invoke(this, ProductID);
        }

        private void productItem_AddToCart(object sender, Tuple<string, string> e)
        {
            AddToCart?.Invoke(this, new Tuple<string, string>(e.Item1, e.Item2));
        }

        private void uiProductView_SizeChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = this.Height - flowLayoutPanel4.Height;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Load("ProductName LIKE N'%" + txtSearch.Text + "%'");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cboCategoryFilter.SelectedValue.ToString() == "-1")
            {
                Load();
            }
            else
            {
                Load("CategoryID = " + cboCategoryFilter.SelectedValue);
            }
        }
    }
}
