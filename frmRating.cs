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
    public partial class frmRating : Form
    {
        private SQL_Services mySqlServices = new SQL_Services();

        public frmRating()
        {
            InitializeComponent();

            pnRatingStar1.RatingMode = true;
            pnRatingStar1.Set_StarValue(1);
        }

        public void Initialize(string OrderID)
        {
            mySqlServices.AddParamater("@OrderID", OrderID);
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            mySqlServices.AddParamater("@Star", pnRatingStar1.Get_StarValue.ToString());
            mySqlServices.AddParamater("@Comment", txtProductInfo.Text);
            mySqlServices.ExecuteNonQuery("EXEC AddRatingForOrder @OrderID, @Star, @Comment");
            MessageBox.Show("Đánh giá thành công");
            this.Close();
        }
    }
}
