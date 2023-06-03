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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Shoppa
{
    public partial class uiCartView : UserControl
    {
        private SQL_Services mySqlServices = new SQL_Services();
        private string AccountID;

        public uiCartView()
        {
            InitializeComponent();
        }

        public void Initialize(string AccountID)
        {
            this.AccountID = AccountID;
            mySqlServices.AddParamater("@AccountID", AccountID);
            mySqlServices.GetCartID();
            Load();
        }

        private void Cart_Checkout()
        {
            int total = 0;
            foreach (pnCartItem cartItem in flowLayoutPanel1.Controls)
            {
                int price = cartItem.Get_Price;
                int quantity = cartItem.Get_Quantity;
                int subtotal = price * quantity;
                total += subtotal;
            }

            lbPayment.Text = "Tổng: " + total.ToString("N0") + "₫";
        }

        private void Load()
        {
            DataTable dataTable = mySqlServices.ExecuteQueryTable("SELECT OrderDetail.ProductID, ProductName, Price, ProductImage, Quantity FROM dbo.OrderDetail\r\nJOIN dbo.Products ON Products.ProductID = OrderDetail.ProductID\r\nJOIN dbo.Orders ON Orders.OrderID = OrderDetail.OrderID\r\nWHERE StatusID = 0 AND OrdererAccountID = @AccountID");

            if (dataTable.Rows.Count > 0)
            {

                flowLayoutPanel1.Controls.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    pnCartItem cartItem = new pnCartItem();

                    cartItem.Set_ProductID = row[0].ToString();
                    cartItem.Set_ProductName = row[1].ToString();
                    cartItem.Set_Price = row[2].ToString();
                    cartItem.Set_ProductImage = row[3].ToString();
                    cartItem.Set_Quantity = row[4].ToString();
                    cartItem.QuantityChanged += cartItem_QuantityChanged;
                    cartItem.ClickOnDelete += cartItem_ClickOnDelete;

                    flowLayoutPanel1.Controls.Add(cartItem);
                }
            }
            Cart_Checkout();
        }

        private void cartItem_ClickOnDelete(object sender, string ProductID)
        {
            mySqlServices.AddParamater("@ProductID", ProductID);
            mySqlServices.ExecuteNonQuery("DELETE FROM dbo.OrderDetail\r\nWHERE OrderID = @CartID AND ProductID = @ProductID");
            pnCartItem cartItem = (pnCartItem)sender;
            flowLayoutPanel1.Controls.Remove(cartItem);
            Cart_Checkout();
        }

        private void cartItem_QuantityChanged(object sender, Tuple<string, string> e)
        {
            mySqlServices.AddParamater("@ProductID", e.Item1);
            mySqlServices.AddParamater("@Quantity", e.Item2);
            mySqlServices.ExecuteNonQuery("UPDATE dbo.OrderDetail\r\nSET Quantity = @Quantity\r\nWHERE OrderID = @CartID AND ProductID = @ProductID");
            Cart_Checkout();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

        }
    }
}
