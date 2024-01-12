using System;
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
            mySqlServices.ExecuteNonQuery("CALL AddRatingForOrder(@OrderID, @Star, @Comment)");
            MessageBox.Show("Đánh giá thành công");
            this.Close();
        }
    }
}
