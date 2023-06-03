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
            set => lbPrice.Text = int.Parse(value).ToString("N0") + "₫";
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
            get => int.Parse(lbPrice.Text.Replace("₫", null).Replace(",", null));
        }

        public int Get_Quantity
        {
            get => int.Parse(lbQuantity.Text.Replace("x", null));
        }
    }
}
