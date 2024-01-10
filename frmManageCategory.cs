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
    public partial class frmManageCategory : Form
    {
        private SQL_Services mySqlServices = new SQL_Services();
        private string CategoryID;
        private bool newMode;

        public frmManageCategory()
        {
            InitializeComponent();

            //
            Load();
        }

        private void Load(string filter = null)
        {
            string sSQL = "SELECT Categories.CategoryID, Categories.CategoryName, COUNT(Products.ProductID) AS ProductCount, COALESCE(SUM(Products.QuantityInStock), 0) AS TotalQuantityInStock FROM Categories\r\nLEFT JOIN Products ON Products.CategoryID = Categories.CategoryID\r\nWHERE Categories.CategoryID != -1" + (filter != null ? " and " + filter : null) + "\r\nGROUP BY Categories.CategoryID, Categories.CategoryName";
            dataGridView1.DataSource = mySqlServices.ExecuteQueryTable(sSQL);
            SetControls(false);
        }

        private void SetControls(bool mode)
        {
            //
            dataGridView1.Enabled = !mode;
            btnAdd.Enabled = !mode;
            btnEdit.Enabled = !mode;
            btnDelete.Enabled = !mode;
            btnSave.Enabled = mode;
            btnCancel.Enabled = mode;

            //
            txtCategoryName.Enabled = mode;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CategoryID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtCategoryID.Text = CategoryID;
            txtCategoryName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtProductCount.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTotalQuantityInStock.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newMode = true;
            SetControls(true);

            txtCategoryID.Text = (int.Parse(mySqlServices.ExecuteScalar("Select MAX(CategoryID) From Categories")) + 1).ToString();
            txtCategoryName.Clear();
            txtProductCount.Text = "0";
            txtTotalQuantityInStock.Text = "0";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            newMode = false;
            SetControls(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa danh mục mặt hàng này chứ? Tất cả mặt hàng được liên kết với danh mục này sẽ được chuyển đến danh mục \"Chưa phân loại\"!!!", "Xóa loại mặt hàng", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                mySqlServices.AddParamater("@CategoryID", CategoryID);
                mySqlServices.ExecuteNonQuery("Update Products Set CategoryID = 0 Where CategoryID = @CategoryID");
                mySqlServices.ExecuteNonQuery("Delete From Categories Where CategoryID = @CategoryID");
                Load();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mySqlServices.AddParamater("@CategoryName", txtCategoryName.Text);

            if (newMode)
            {
                if (mySqlServices.CheckExist("Categories", "CategoryName"))
                {
                    MessageBox.Show("Loại danh mục này: \"" + txtCategoryName.Text + "\" đã tồn tại. Vui lòng nhập Tên danh mục khác");
                    txtCategoryName.Focus();
                }
                else
                {
                    mySqlServices.ExecuteNonQuery("Insert Into Categories Values (@CategoryName)");
                }
            }
            else
            {
                if (mySqlServices.CheckExist("Categories", "CategoryName") && txtCategoryName.Text != CategoryID)
                {
                    MessageBox.Show("Loại danh mục này: \"" + txtCategoryName.Text + "\" đã tồn tại. Vui lòng nhập Tên danh mục khác");
                    txtCategoryName.Focus();
                }
                else
                {
                    mySqlServices.AddParamater("@CategoryID", CategoryID);
                    mySqlServices.ExecuteNonQuery("Update Categories Set CategoryName = @CategoryName Where CategoryID = @CategoryID");
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
            Load("CategoryName LIKE N'%" + txtSearchBox.Text + "%'");
        }
    }
}
