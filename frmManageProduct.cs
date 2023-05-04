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

            //

            DataTable dtCategory = mySqlServices.ExecuteQueryTable("Select * From Categories"); 
            cboCategory.DataSource = dtCategory;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryID";

            DataTable dtCategoryFilter = mySqlServices.ExecuteQueryTable("Select * From Categories");
            cboCategoryFilter.DataSource = dtCategoryFilter;
            cboCategoryFilter.DisplayMember = "CategoryName";
            cboCategoryFilter.ValueMember = "CategoryID";

            DataTable dtUnit = mySqlServices.ExecuteQueryTable("Select * From Unit");
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
            dataGridView1.Enabled = !mode;
            btnAddProduct.Enabled = !mode;
            btnEditProduct.Enabled = !mode;
            btnDeleteProduct.Enabled = !mode;
            btnSaveProduct.Enabled = mode;
            btnCancel.Enabled = mode;

            ///

            txtProductID.Enabled = mode;
            txtProductName.Enabled = mode;
            cboCategory.Enabled = mode;
            cboUnit.Enabled = mode;
            txtPrice.Enabled = mode;
            txtQuantityInStock.Enabled = mode;
            txtProductInfo.Enabled = mode;
            btnSelectProductImage.Enabled = mode;
        }

        private string ProductID;
        private bool newMode;
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Load("WHERE ProductName LIKE N'%" + txtSearchBox.Text + "%'");
        }

        private void btnCategoryFilter_Click(object sender, EventArgs e)
        {
            if (cboCategoryFilter.SelectedValue == "-1")
            {
                Load();
            }
            else
            {
                Load("Where CategoryID = " + cboCategoryFilter.SelectedValue);
            }
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            newMode = true;
            SetControls(true);
            txtProductID.PlaceholderText = "SP00000001";

            txtProductID.Clear();
            txtProductName.Clear();
            cboCategory.SelectedIndex = 1;
            cboUnit.SelectedIndex = 1;
            txtPrice.Clear();
            txtQuantityInStock.Clear();
            txtProductInfo.Clear();
            pbProductImage.ImageLocation = @"C:\Users\doandat943\Documents\Pichon\product_480px.png";
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            newMode = false;
            SetControls(true);
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản chứ?", "Xóa tài khoản", MessageBoxButtons.OKCancel) == DialogResult.OK) ;
            {
                mySqlServices.AddParamater("@ProductID", ProductID);
                mySqlServices.ExecuteNonQuery("Delete From Products Where ProductID = @ProductID");
                Load();
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
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
    }
}
