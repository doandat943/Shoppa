using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoppa
{
    public partial class pnHistoryItem : UserControl
    {
        private SQL_Services mySqlServices = new SQL_Services();
        private frmRating frmRating;
        private string OrderID;

        public pnHistoryItem()
        {
            InitializeComponent();
        }

        public void Initialize(string OrderID)
        {
            this.OrderID = OrderID;
            mySqlServices.AddParamater("@OrderID", OrderID);
            Load();
        }
        

        public void Load()
        {
            DataTable dataTable = mySqlServices.ExecuteQueryTable("SELECT StatusName, TotalAmount\r\nFROM Orders\r\nJOIN Status ON Status.StatusID = Orders.StatusID\r\nWHERE OrderID = @OrderID");

            if (dataTable.Rows.Count > 0)
            {
                lbStatus.Text = dataTable.Rows[0][0].ToString();
                lbTotalAmount.Text = Convert.ToInt32(dataTable.Rows[0][1]).ToString("N0") + "₫";
            }

            dataTable = mySqlServices.ExecuteQueryTable("SELECT Products.ProductID, ProductName, Price, OrderDetail.Quantity, ProductImage \r\nFROM Products\r\nLEFT JOIN OrderDetail ON OrderDetail.ProductID = Products.ProductID\r\nLEFT JOIN Orders ON Orders.OrderID = OrderDetail.OrderID\r\nWHERE Orders.OrderID = @OrderID");

            if (dataTable.Rows.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    pnProductItem productItem = new pnProductItem();

                    productItem.Set_ProductID = row[0].ToString();
                    productItem.Set_ProductName = row[1].ToString();
                    productItem.Set_Price = row[2].ToString();
                    productItem.Set_Sold = "Số lượng: " + row[3];
                    productItem.Set_ProductImage = row[4].ToString();

                    flowLayoutPanel1.Controls.Add(productItem);
                }
            }
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            frmRating = new frmRating();
            frmRating.Initialize(OrderID);
            frmRating.ShowDialog();
        }
    }
}
