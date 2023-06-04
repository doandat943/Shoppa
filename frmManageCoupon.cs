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
    public partial class frmManageCoupon : Form
    {
        private SQL_Services mySqlServices = new SQL_Services();
        private string AccountID;
        private string CouponID;
        private bool newMode;

        public frmManageCoupon()
        {
            InitializeComponent();
            
            DataTable dtCouponType = mySqlServices.ExecuteQueryTable("Select * From CouponType"); 
            cboCouponType.DataSource = dtCouponType;
            cboCouponType.DisplayMember = "CouponTypeName";
            cboCouponType.ValueMember = "CouponTypeID";
        }

        public void Initialize(string AccountID)
        {
            this.AccountID = AccountID;
            mySqlServices.AddParamater("@AccountID", AccountID);

            Load();
        }

        private void Load(string filter = null)
        {
            string sSQL = "SELECT Coupons.CouponID, CouponTypeID, CouponName, ExpireDate, Discount, CreatorAccountID, COUNT(Coupons.CouponID) AS UsedCount\r\nFROM dbo.Coupons\r\nLEFT JOIN dbo.Orders ON Orders.CouponID = Coupons.CouponID\r\nGROUP BY  Coupons.CouponID, CouponTypeID, CouponName, ExpireDate, Discount, CreatorAccountID";
            dataGridView1.DataSource = mySqlServices.ExecuteQueryTable(sSQL);
            SetControls(false);
        }

        private void SetControls(bool mode)
        {
            //
            dataGridView1.Enabled = !mode;
            btnAdd.Enabled = !mode;
            btnEdit.Enabled = !mode;
            btnDelete.Enabled = false;
            btnSave.Enabled = mode;
            btnCancel.Enabled = mode;

            //
            txtCouponID.Enabled = mode;
            cboCouponType.Enabled = mode;
            txtCouponName.Enabled = mode;
            bunifuDatePicker1.Enabled = mode;
            txtDiscount.Enabled = mode;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CouponID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtCouponID.Text = CouponID;
            cboCouponType.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            txtCouponName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            bunifuDatePicker1.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtDiscount.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCreatorAccountID.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtUsedCount.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newMode = true;
            SetControls(true);

            txtCouponID.Clear();
            cboCouponType.SelectedIndex = 0;
            txtCouponName.Clear();
            bunifuDatePicker1.Value = DateTime.Now;
            txtDiscount.Text = "0";
            txtCreatorAccountID.Text = AccountID;
            txtUsedCount.Text = "0";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            newMode = false;
            SetControls(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
