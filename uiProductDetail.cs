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
    public partial class uiProductDetail : UserControl
    {
        private SQL_Services mySqlServices = new SQL_Services();
        public uiProductDetail()
        {
            InitializeComponent();
        }

        private void btnSubtractCart_Click(object sender, EventArgs e)
        {
            if (tbNumberCart.Text != "1")
            {
                tbNumberCart.Text = (int.Parse(tbNumberCart.Text) - 1).ToString();
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            tbNumberCart.Text = (int.Parse(tbNumberCart.Text) + 1).ToString();
        }
    }
}
