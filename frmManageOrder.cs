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
    public partial class frmManageOrder : Form
    {
        private SQL_Services mySqlServices = new SQL_Services();

        public frmManageOrder()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable dataTable = mySqlServices.ExecuteQueryTable("SELECT OrderID\r\nFROM Orders\r\nWHERE StatusID <> 0\r\nORDER BY OrderID DESC");

            if (dataTable.Rows.Count != 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    pnHistoryItem historyItem = new pnHistoryItem();
                    historyItem.setMode(1);
                    historyItem.Initialize(row[0].ToString());
                    flowLayoutPanel1.Controls.Add(historyItem);
                }
            }
        }
    }
}
