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
    public partial class frmTemp : Form
    {
        private SQL_Services mySqlServices = new SQL_Services();

        public frmTemp()
        {
            InitializeComponent();

            mySqlServices.OpenDB("Data Source=MACBOOK\\SQLEXPRESS;Initial Catalog=Shoppa;Integrated Security=True");

            uiProductDetail uiProductDetail = new uiProductDetail();
            uiProductDetail.Initialize("SP00000001");
            this.Controls.Add(uiProductDetail);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
