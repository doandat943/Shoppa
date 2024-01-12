using Bunifu.Dataviz.WinForms;
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
    public partial class uiStatistic : UserControl
    {
        private SQL_Services mySqlServices = new SQL_Services();

        public uiStatistic()
        {
            InitializeComponent();
        }

        public void Load()
        {
            lbProduct.Text = mySqlServices.ExecuteScalar("SELECT SUM(Quantity) FROM OrderDetail");
            lbOrder.Text = mySqlServices.ExecuteScalar("SELECT COUNT(*) FROM Orders WHERE StatusID = 40");
            lbIncome.Text = Convert.ToInt32(mySqlServices.ExecuteScalar("SELECT SUM(TotalAmount) FROM Orders WHERE StatusID = 40")).ToString("N0") + "₫";

            BunifuDatavizAdvanced.Canvas canvas = new BunifuDatavizAdvanced.Canvas();
            BunifuDatavizAdvanced.DataPoint data = new BunifuDatavizAdvanced.DataPoint(BunifuDatavizAdvanced._type.Bunifu_splineArea);
            for (int i = -10; i < 10; i++)
            {
                string date = (DateTime.Now + TimeSpan.FromDays(i)).ToString("yyyy-MM-dd");
                mySqlServices.AddParamater("@Date", date);
                string invoice = mySqlServices.ExecuteScalar("SELECT IFNULL(SUM(TotalAmount), 0) AS TotalSum\r\nFROM Orders\r\nWHERE DATE(OrderDate) = @Date");

                data.addLabely(date.ToString(), invoice);
            }
            canvas.addData(data);
            bunifuDatavizAdvanced1.Render(canvas);
        }
    }
}