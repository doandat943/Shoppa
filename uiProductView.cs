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
    public partial class uiProductView : UserControl
    {
        private SQL_Services mySqlServices = new SQL_Services();

        public uiProductView()
        {
            InitializeComponent();

            Load();
        }

        public void Load()
        {
            DataTable dataTable = mySqlServices.ExecuteQueryTable("Select ProductName, Price, QuantityInStock, ProductImage From Products");

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    pnProductItem productItem = new pnProductItem();

                    productItem.Set_ProductName = row[0].ToString();
                    productItem.Set_Price = row[1].ToString();
                    productItem.Set_Sold = row[2].ToString();
                    productItem.Set_ProductImage = row[3].ToString();

                    flowLayoutPanel1.Controls.Add(productItem);
                }
            }
        }
    }
}
