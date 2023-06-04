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
        private string ProductID;
        private bool newMode;

        public frmManageProduct()
        {
            InitializeComponent();

            //
            DataTable dtCategory = mySqlServices.ExecuteQueryTable("Select * From Categories Where CategoryID != -1"); 
            cboCategory.DataSource = dtCategory;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryID";

            DataTable dtCategoryFilter = mySqlServices.ExecuteQueryTable("Select * From Categories");
            cboCategoryFilter.DataSource = dtCategoryFilter;
            cboCategoryFilter.DisplayMember = "CategoryName";
            cboCategoryFilter.ValueMember = "CategoryID";

            DataTable dtUnit = mySqlServices.ExecuteQueryTable("Select * From Units");
            cboUnit.DataSource = dtUnit;
            cboUnit.DisplayMember = "UnitName";
            cboUnit.ValueMember = "UnitID";

            //
            Load();
        }

        private void Load(string filter = null)
        {
            dataGridView1.DataSource = mySqlServices.ExecuteQueryTable("Select * From Products " + filter);
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
            txtProductID.Enabled = mode;
            txtProductName.Enabled = mode;
            cboCategory.Enabled = mode;
            cboUnit.Enabled = mode;
            txtPrice.Enabled = mode;
            txtQuantityInStock.Enabled = mode;
            txtProductInfo.Enabled = mode;
            btnSelectProductImage.Enabled = mode;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ProductID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtProductID.Text = ProductID;
            txtProductName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cboCategory.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cboUnit.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtQuantityInStock.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtProductInfo.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            pbProductImage.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnSelectProductImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            pbProductImage.ImageLocation = ofd.FileName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newMode = true;
            SetControls(true);
            //txtProductID.PlaceholderText = "SP00000001";
            txtProductID.Text = "SP" + (int.Parse(mySqlServices.ExecuteScalar("Select MAX(ProductID) From Products").Replace("SP", null)) + 1).ToString("D8");

            //txtProductID.Clear();
            txtProductName.Clear();
            cboCategory.SelectedIndex = 1;
            cboUnit.SelectedIndex = 1;
            txtPrice.Clear();
            txtQuantityInStock.Clear();
            txtProductInfo.Clear();
            pbProductImage.ImageLocation = @"C:\Users\doandat943\Documents\Pichon\product_480px.png";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            newMode = false;
            SetControls(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản chứ?", "Xóa tài khoản", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                mySqlServices.AddParamater("@ProductID", ProductID);
                mySqlServices.ExecuteNonQuery("Delete From Products Where ProductID = @ProductID");
                Load();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mySqlServices.AddParamater("@ProductID", txtProductID.Text);
            mySqlServices.AddParamater("@ProductName", txtProductName.Text);
            mySqlServices.AddParamater("@CategoryID", cboCategory.SelectedValue.ToString());
            mySqlServices.AddParamater("@UnitID", cboUnit.SelectedValue.ToString());
            mySqlServices.AddParamater("@Price", txtPrice.Text);
            mySqlServices.AddParamater("@QuantityInStock", txtQuantityInStock.Text);
            mySqlServices.AddParamater("@ProductInfo", txtProductInfo.Text);
            mySqlServices.AddParamater("@ProductImage", pbProductImage.ImageLocation);

            if (newMode == true)
            {
                if (mySqlServices.CheckExist("Products", "ProductID"))
                {
                    MessageBox.Show("Mã sản phẩm: \"" + txtProductID.Text + "\" đã tồn tại. Vui lòng nhập Mã sản phẩm khác");
                    txtProductID.Focus();
                }
                else
                {
                    mySqlServices.ExecuteNonQuery("Insert Into Products Values (@ProductID, @ProductName, @CategoryID, @UnitID, @Price, @QuantityInStock, @ProductInfo, @ProductImage)");
                }
            }
            else
            {
                if (mySqlServices.CheckExist("Products", "ProductID") && txtProductID.Text != ProductID)
                {
                    MessageBox.Show("Mã sản phẩm: \"" + txtProductID.Text + "\" đã tồn tại. Vui lòng nhập Mã sản phẩm khác");
                    txtProductID.Focus();
                }
                else
                {
                    mySqlServices.AddParamater("oldProductID", ProductID);
                    mySqlServices.ExecuteNonQuery("Update Products Set ProductID = @ProductID, ProductName = @ProductName, CategoryID = @CategoryID, UnitID = @UnitID, Price = @Price, QuantityInStock = @QuantityInStock, ProductInfo = @ProductInfo, ProductImage = @ProductImage Where ProductID = @oldProductID");
                }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Load("WHERE ProductName LIKE N'%" + txtSearch.Text + "%'");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cboCategoryFilter.SelectedValue.ToString() == "-1")
            {
                Load();
            }
            else
            {
                Load("Where CategoryID = " + cboCategoryFilter.SelectedValue);
            }
        }
    }
}
