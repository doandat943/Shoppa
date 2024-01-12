using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Shoppa
{
    public partial class frmManageCoupon : Form
    {
        private SQL_Services mySqlServices = new SQL_Services();
        private string AccountID;
        private bool newMode;

        public frmManageCoupon()
        {
            InitializeComponent();

            List<DataSource> dataSourceList = new List<DataSource>
            {
                new DataSource("Giảm phí vận chuyển", 1),
                new DataSource("Giảm giá đơn hàng", 2)
            };

            cboCouponType.DataSource = dataSourceList;
            cboCouponType.DisplayMember = "Text";
            cboCouponType.ValueMember = "Value";

        }

        public class DataSource
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public DataSource(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        public void Initialize(string AccountID)
        {
            this.AccountID = AccountID;
            mySqlServices.AddParamater("@AccountID", AccountID);

            Load();
        }

        private void Load(string filter = null)
        {
            string sSQL = "SELECT Coupons.CouponID, CouponType, CouponName, ExpireDate, Discount, CreatorAccountID, COUNT(Coupons.CouponID) AS UsedCount\r\nFROM Coupons\r\nLEFT JOIN Orders ON Orders.CouponID = Coupons.CouponID\r\nGROUP BY  Coupons.CouponID, CouponType, CouponName, ExpireDate, Discount, CreatorAccountID";
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
            txtCouponID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
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
            txtCouponID.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mySqlServices.AddParamater("@CouponID", txtCouponID.Text);
            mySqlServices.AddParamater("@CouponType", cboCouponType.SelectedValue.ToString());
            mySqlServices.AddParamater("@CouponName", txtCouponName.Text);
            mySqlServices.AddParamater("@ExpireDate", bunifuDatePicker1.Value.ToString("yyyy/MM/dd"));
            mySqlServices.AddParamater("@Discount", txtDiscount.Text);
            mySqlServices.AddParamater("@CreatorAccountID", txtCreatorAccountID.Text);

            if (newMode)
            {
                if (mySqlServices.CheckExist("Coupons", "CouponID"))
                {
                    MessageBox.Show("Mã giảm giá: \"" + txtCouponID.Text + "\" đã tồn tại. Vui lòng nhập Mã giảm giá khác");
                    txtCouponID.Focus();
                }
                else
                {
                    mySqlServices.ExecuteNonQuery("Insert Into Coupons Values (@CouponID, @CouponType, @CouponName, @ExpireDate, @Discount, @CreatorAccountID)");
                }
            }
            else
            {
                mySqlServices.ExecuteNonQuery("Update Coupons Set CouponType = @CouponType, CouponName = @CouponName, ExpireDate = @ExpireDate, Discount = @Discount Where CouponID = @CouponID");
            }

            Load();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
