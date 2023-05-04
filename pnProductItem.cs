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
        public event EventHandler<string> ClickProductImage;
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

        private void pbProductImage_Click(object sender, EventArgs e)
        {
            ClickProductImage?.Invoke(this, ProductID);
        }
    }
}
