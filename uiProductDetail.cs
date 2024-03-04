using System;
using System.Data;
using System.Windows.Forms;

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

            DataTable dataTable = mySqlServices.ExecuteQueryTable("SELECT ProductName, COALESCE(SUM(CASE WHEN Orders.StatusID = 40 THEN OrderDetail.Quantity ELSE 0 END), 0) AS Sold, Price, IFNULL(ROUND(AVG(Rating.Star)), 0) AS AVG, UnitName, ProductInfo, ProductImage\r\nFROM Products\r\nLEFT JOIN OrderDetail ON OrderDetail.ProductID = Products.ProductID\r\nLEFT JOIN Units ON Units.UnitID = Products.UnitID\r\nLEFT JOIN Orders ON Orders.OrderID = OrderDetail.OrderID\r\nLEFT JOIN Rating ON Rating.ProductID = Products.ProductID\r\nWHERE Products.ProductID = @ProductID\r\nGROUP BY ProductName, Price, UnitName, ProductInfo, ProductImage");

            if (dataTable.Rows.Count > 0)
            {
                lbProductName.Text = dataTable.Rows[0][0].ToString();
                lbSold.Text = "Đã bán: " + dataTable.Rows[0][1].ToString();
                lbPrice.Text = Convert.ToInt32(dataTable.Rows[0][2].ToString()).ToString("N0") + "₫";
                pnRatingStar.Set_StarValue(Convert.ToInt32(dataTable.Rows[0][3].ToString()));
                lbUnit.Text = "Đơn vị: " +  dataTable.Rows[0][4];
                txtProductInfo.Text = dataTable.Rows[0][5].ToString();
                pbProductImage.ImageLocation = dataTable.Rows[0][6].ToString();

                flowLayoutPanel2.Controls.Clear();
                dataTable = mySqlServices.ExecuteQueryTable("SELECT Accounts.Avatar, Accounts.Name, Comment, Star\r\nFROM Rating\r\nLEFT JOIN Orders ON Orders.OrderID = Rating.OrderID\r\nLEFT JOIN Accounts ON Accounts.AccountID = Orders.OrdererAccountID\r\nWHERE ProductID = @ProductID");
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        pnRatingItem ratingItem = new pnRatingItem();

                        ratingItem.Set_Avatar = row[0].ToString();
                        ratingItem.Set_AccountName = row[1].ToString();
                        ratingItem.Set_Comment = row[2].ToString();
                        ratingItem.Set_Star = Convert.ToInt32(row[3].ToString());

                        flowLayoutPanel2.Controls.Add(ratingItem);
                    }
                }
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
                txtQuantity.Text = (Convert.ToInt32(txtQuantity.Text) - 1).ToString();
            }
        }

        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = (Convert.ToInt32(txtQuantity.Text) + 1).ToString();
        }

        public event EventHandler<Tuple<string, string>> AddToCart;

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            AddToCart?.Invoke(this, new Tuple<string, string>(ProductID, txtQuantity.Text));
        }
    }
}
