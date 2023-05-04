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

            DataTable dataTable = mySqlServices.ExecuteQueryTable("SELECT ProductName, CategoryName, Price, UnitName, ProductInfo\r\nFROM Products \r\nJOIN dbo.Categories ON Categories.CategoryID = Products.CategoryID\r\nJOIN dbo.Unit ON Unit.UnitID = Products.UnitID\r\nWHERE ProductID = @ProductID");

            if (dataTable.Rows.Count > 0)
            {
                lbProductName.Text = dataTable.Rows[0][0].ToString();
                lbCategoryName.Text = dataTable.Rows[0][1].ToString();
                lbPrice.Text = dataTable.Rows[0][2].ToString();
                lbUnit.Text = "Đơn vị: " +  dataTable.Rows[0][3];
                txtProductInfo.Text = dataTable.Rows[0][4].ToString();
            }
            else
            {
                MessageBox.Show("Truy vấn thông tin sản phẩm không thành công");
            }
        }

        private void btnSubtractCart_Click(object sender, EventArgs e)
        {
            if (tbNumberCart.Text != "1")
            {
                tbNumberCart.Text = (int.Parse(tbNumberCart.Text) - 1).ToString();
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            tbNumberCart.Text = (int.Parse(tbNumberCart.Text) + 1).ToString();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }
    }
}
