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
    public partial class frmManageProduct : Form
    {
        private SQL_Services mySqlServices = new SQL_Services();

        public frmManageProduct()
        {
            InitializeComponent();

            DataTable dtCategory = mySqlServices.ExecuteQueryTable("Select * From Categories"); 
            cboCategory.DataSource = dtCategory;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryID";
        }
        
        private void btnSelectProductImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            pbProductImage.ImageLocation = ofd.FileName;
        }
    }
}
