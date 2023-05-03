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
    public partial class frmManageAccount : Form
    {
        private SQL_Services mySqlServices = new SQL_Services();

        public frmManageAccount()
        {
            InitializeComponent();
        }

        private void Load(string filter = "")
        {
            //mySqlServices
        }
    }
}
