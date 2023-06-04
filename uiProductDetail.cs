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
    public partial class uiProductDetail : UserControl
    {
        private SQL_Services mySqlServices = new SQL_Services();
        private string ProductID;

        public uiProductDetail()
        {
            InitializeComponent();
        }

        public void Initialize(string ProductID)
        {
            this.ProductID = ProductID;
            mySqlServices.AddParamater("@ProductID", ProductID);

            DataTable dataTable = mySqlServices.ExecuteQueryTable("SELECT ProductName, ISNULL(SUM(CASE WHEN Orders.StatusID = 40 THEN OrderDetail.Quantity ELSE 0 END), 0) AS Sold, Price, UnitName, ProductInfo, ProductImage\r\nFROM Products\r\nLEFT JOIN dbo.OrderDetail ON OrderDetail.ProductID = Products.ProductID\r\nLEFT JOIN dbo.Units ON Units.UnitID = Products.UnitID\r\nLEFT JOIN dbo.Orders ON Orders.OrderID = OrderDetail.OrderID\r\nWHERE Products.ProductID = @ProductID\r\nGROUP BY ProductName, Price, UnitName, ProductInfo, ProductImage");

            if (dataTable.Rows.Count > 0)
            {
                lbProductName.Text = dataTable.Rows[0][0].ToString();
                lbSold.Text = "Đã bán: " + dataTable.Rows[0][1].ToString();
                lbPrice.Text = dataTable.Rows[0][2].ToString();
                lbUnit.Text = "Đơn vị: " +  dataTable.Rows[0][3];
                txtProductInfo.Text = dataTable.Rows[0][4].ToString();
                pbProductImage.ImageLocation = dataTable.Rows[0][5].ToString();
            }
            else
            {
                MessageBox.Show("Truy vấn thông tin sản phẩm không thành công");
            }
        }

        private void btnSubtractQuantity_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "1")
            {
                txtQuantity.Text = (int.Parse(txtQuantity.Text) - 1).ToString();
            }
        }

        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = (int.Parse(txtQuantity.Text) + 1).ToString();
        }

        public event EventHandler<Tuple<string, string>> AddToCart;

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            AddToCart?.Invoke(this, new Tuple<string, string>(ProductID, txtQuantity.Text));
        }
    }
}
