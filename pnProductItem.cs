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
    public partial class pnProductItem : UserControl
    {
        private SQL_Services mySqlServices = new SQL_Services();
        private string ProductID;

        public pnProductItem()
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

        public string Set_Sold
        {
            set => lbSold.Text = value;
        }

        public string Set_ProductImage
        {
            set => pbProductImage.ImageLocation = value;
        }

        public event EventHandler<string> ClickOnProduct;
        public event EventHandler<Tuple<string, string>> AddToCart;

        private void pbProductImage_Click(object sender, EventArgs e)
        {
            ClickOnProduct?.Invoke(this, ProductID);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            AddToCart?.Invoke(this, new Tuple<string, string>(ProductID, "1"));
        }
    }
}
