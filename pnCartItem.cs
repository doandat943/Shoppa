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
    public partial class pnCartItem : UserControl
    {
        private SQL_Services mySqlServices = new SQL_Services();
        private string ProductID;

        public pnCartItem()
        {
            InitializeComponent();
        }

        public string Set_ProductID
        {
            set => ProductID = value;
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
            set => txtQuantity.Text = value;
        }

        public int Get_Price
        {
            get => int.Parse(lbPrice.Text.Replace("₫", null).Replace(",", null));
        }

        public int Get_Quantity
        {
            get => int.Parse(txtQuantity.Text);
        }

        public event EventHandler<string> ClickOnDelete;
        public event EventHandler<Tuple<string, string>> QuantityChanged;
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClickOnDelete?.Invoke(this, ProductID);
        }

        private void btnSubtractQuantity_Click(object sender, EventArgs e)
        {
            int Quantity = int.Parse(txtQuantity.Text);
            if (Quantity > 1)
            {
                txtQuantity.Text = (Quantity - 1).ToString();
            }
        }

        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            int Quantity = int.Parse(txtQuantity.Text);
            if (Quantity < 100)
            {
                txtQuantity.Text = (Quantity + 1).ToString();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            int Quantity = int.Parse(txtQuantity.Text);
            if (Quantity < 1)
            {
                txtQuantity.Text = "1";
            }
            else if (Quantity > 100)
            {
                txtQuantity.Text = "100";
            }
            QuantityChanged?.Invoke(this, new Tuple<string, string>(ProductID, txtQuantity.Text));
        }
    }
}
