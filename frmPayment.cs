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
    public partial class frmPayment : Form
    {
        private SQL_Services mySqlServices = new SQL_Services();
        private bool temp = false;

        public frmPayment()
        {
            InitializeComponent();

            DataTable dtCategory = mySqlServices.ExecuteQueryTable("Select * From DeliveryFee"); 
            cboDeliveryFee.DataSource = dtCategory;
            cboDeliveryFee.DisplayMember = "DeliveryFeeName";
            cboDeliveryFee.ValueMember = "DeliveryFeeValue";

            panel5.Visible = false;
        }

        public void Initialize(string AccountID)
        {
            temp = true;
            mySqlServices.AddParamater("@AccountID", AccountID);
            mySqlServices.GetCartID();
            Load();
        }

        private void Payment_Checkout()
        {
            int total = 0;

            // Product
            foreach (pnPaymentItem paymentItem in flowLayoutPanel3.Controls)
            {
                int price = paymentItem.Get_Price;
                int quantity = paymentItem.Get_Quantity;
                int subtotal = price * quantity;
                paymentItem.Set_Checkout = subtotal;
                total += subtotal;
            }

            // Delivery
            int DistanceToNgheAn = int.Parse(mySqlServices.ExecuteScalar("SELECT DistanceToNgheAn FROM dbo.Provinces\r\nJOIN dbo.Accounts ON Accounts.ProvinceID = Provinces.ProvinceID\r\nWHERE AccountID = @AccountID"));
            int DeliveryFee = DistanceToNgheAn * int.Parse(cboDeliveryFee.SelectedValue.ToString());
            lbDeliveryFee.Text = DeliveryFee.ToString("N0") + "₫";
            total += DeliveryFee;

            // Coupon

            if (panel5.Visible)
            {
                total += int.Parse(lbCoupon.Text.Replace("₫", null).Replace(",", null));
            }

            // Total
            lbCheckout.Text = total.ToString("N0") + "₫";
        }

        private void Load()
        {
            DataTable dataTable = mySqlServices.ExecuteQueryTable("Select Name, PhoneNumber, Address, ProvinceName\r\nFROM Accounts \r\nJOIN dbo.Provinces ON Provinces.ProvinceID = Accounts.ProvinceID\r\nWHERE AccountID = @AccountID");

            if (dataTable.Rows.Count > 0)
            {
                lbAddress.Text = dataTable.Rows[0][0] + " (" + dataTable.Rows[0][1] + ") - " + dataTable.Rows[0][2] + " - " + dataTable.Rows[0][3];
            }

            dataTable = mySqlServices.ExecuteQueryTable("SELECT ProductName, Price, ProductImage, Quantity FROM dbo.OrderDetail\r\nJOIN dbo.Products ON Products.ProductID = OrderDetail.ProductID\r\nJOIN dbo.Orders ON Orders.OrderID = OrderDetail.OrderID\r\nWHERE StatusID = 0 AND OrdererAccountID = @AccountID");

            if (dataTable.Rows.Count > 0)
            {
                flowLayoutPanel3.Controls.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    pnPaymentItem pnPaymentItem = new pnPaymentItem();
                    
                    pnPaymentItem.Set_ProductName = row[0].ToString();
                    pnPaymentItem.Set_Price = row[1].ToString();
                    pnPaymentItem.Set_ProductImage = row[2].ToString();
                    pnPaymentItem.Set_Quantity = row[3].ToString();

                    flowLayoutPanel3.Controls.Add(pnPaymentItem);
                }
            }
            Payment_Checkout();
        }

        private void cboDeliveryFee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (temp) Payment_Checkout();
        }

        private void btnCoupon_Click(object sender, EventArgs e)
        {
            mySqlServices.AddParamater("@CouponID", txtCoupon.Text);
            DataTable dataTable = mySqlServices.ExecuteQueryTable("Select CouponName, Discount, CouponType\r\nFROM Coupons\r\nWHERE CouponID = @CouponID");

            if (dataTable.Rows.Count > 0)
            {
                mySqlServices.ExecuteNonQuery("UPDATE dbo.Orders\r\nSET CouponID = @CouponID\r\nWHERE OrderID = @CartID");

                string couponName = dataTable.Rows[0][0].ToString();
                int discount = int.Parse(dataTable.Rows[0][1].ToString());
                string couponType = dataTable.Rows[0][2].ToString();

                if (couponType == "1")
                {
                    couponType = "%";
                    lbCoupon.Text = "-" + (discount * int.Parse(lbCheckout.Text.Replace("₫", null).Replace(",", null))).ToString("N0") + "₫";
                }
                else if (couponType == "2")
                {
                    couponType = "₫";
                    lbCoupon.Text = "-" + discount.ToString("N0") + "₫";
                }

                lbCouponInfo.Text = couponName + " (Ưu đãi giảm " + discount.ToString("N0") + couponType + ")";

                panel5.Visible = true;
            }
            else
            {
                MessageBox.Show("Mã giảm giá không tồn tại!!!");
            }
            Payment_Checkout();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            int temp = mySqlServices.ExecuteNonQuery("UPDATE dbo.Orders\r\nSET StatusID = 10\r\nWHERE OrderID = @CartID");
            if (temp != 0)
            {
                MessageBox.Show("Đặt hàng thành công!!!");
                this.Close();
            }
        }
    }
}
