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

        public event EventHandler<string> ClickOnDelete;
        public event EventHandler<Tuple<string, string>> QuantityChanged;
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClickOnDelete?.Invoke(this, ProductID);
        }

        private void btnSubtractQuantity_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "1")
            {
                txtQuantity.Text = (int.Parse(txtQuantity.Text) - 1).ToString();

                QuantityChanged?.Invoke(this, new Tuple<string, string>(ProductID, txtQuantity.Text));
            }
        }

        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = (int.Parse(txtQuantity.Text) + 1).ToString();

            QuantityChanged?.Invoke(this, new Tuple<string, string>(ProductID, txtQuantity.Text));
        }
    }
}
