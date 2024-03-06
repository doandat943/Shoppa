﻿using System;
using System.Data;
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
            cboCategoryFilter.SelectedIndexChanged += cboCategoryFilter_SelectedIndexChanged;

            //
            Load();
        }

        public void Load(string filter = null)
        {
            DataTable dataTable = mySqlServices.ExecuteQueryTable("SELECT Products.ProductID, ProductName, Price, COALESCE(SUM(CASE WHEN Orders.StatusID = 40 THEN OrderDetail.Quantity ELSE 0 END), 0) AS Sold, ProductImage \r\nFROM Products\r\nLEFT JOIN OrderDetail ON OrderDetail.ProductID = Products.ProductID\r\nLEFT JOIN Orders ON Orders.OrderID = OrderDetail.OrderID\r\n" + (filter != null ? "WHERE " + filter : null) + "\r\nGROUP BY Products.ProductID, ProductName, Price, ProductImage");

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Load("ProductName LIKE N'%" + txtSearch.Text + "%'");
        }

        private void cboCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterCategory(cboCategoryFilter.SelectedValue.ToString());
        }

        public void FilterCategory(string CategoryID)
        {
            if (CategoryID == "-1")
            {
                Load();
            }
            else
            {
                Load("CategoryID = " + CategoryID);
            }
        }

        private void uiProductView_SizeChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = this.Height - flowLayoutPanel4.Height;
        }
    }
}
