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
        public pnProductItem()
        {
            InitializeComponent();
        }
        public string Set_ProductName
        {
            //get => ProductName.Text;
            set => lbProductName.Text = value;
        }

        public string Set_Price
        {
            set => lbPrice.Text = int.Parse(value).ToString("N0") + "₫";
        }

        public string Set_QuantityInStock
        {
            set => lbQuantityInStock.Text = value;
        }

        public string Set_ProductImage
        {
            set => pbProductImage.ImageLocation = value;
        }
    }
}
