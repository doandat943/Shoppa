using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoppa
{
    public partial class uiHistoryView : UserControl
    {
        private SQL_Services mySqlServices = new SQL_Services();
        private string AccountID;

        public uiHistoryView()
        {
            InitializeComponent();
        }
        public void Initialize(string AccountID)
        {
            this.AccountID = AccountID;
            mySqlServices.AddParamater("@AccountID", AccountID);
            Load();
        }

        private void Load()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable dataTable = mySqlServices.ExecuteQueryTable("SELECT OrderID\r\nFROM dbo.Orders\r\nWHERE OrdererAccountID = @AccountID AND StatusID <> 0");

            if (dataTable.Rows.Count != 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    pnHistoryItem historyItem = new pnHistoryItem();
                    historyItem.Initialize(row[0].ToString());
                    flowLayoutPanel1.Controls.Add(historyItem);
                }
            }
        }
    }
}
