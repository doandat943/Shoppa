using System;
using System.Windows.Forms;

namespace Shoppa
{
    public partial class pnPaymentItem : UserControl
    {
        public pnPaymentItem()
        {
            InitializeComponent();
        }
        

        public string Set_ProductName
        {
            set => lbProductName.Text = value;
        }

        public string Set_Price
        {
            set => lbPrice.Text = Convert.ToInt32(value).ToString("N0") + "₫";
        }

        public string Set_ProductImage
        {
            set => pbProductImage.ImageLocation = value;
        }

        public string Set_Quantity
        {
            set => lbQuantity.Text = "x" + value;
        }

        public int Set_Checkout
        {
            set => lbCheckout.Text = value.ToString("N0") + "₫";
        }
        
        public int Get_Price
        {
            get => Convert.ToInt32(lbPrice.Text.Replace("₫", null).Replace(",", null));
        }

        public int Get_Quantity
        {
            get => Convert.ToInt32(lbQuantity.Text.Replace("x", null));
        }
    }
}
