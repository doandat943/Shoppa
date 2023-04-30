using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Bunifu.UI.WinForms.BunifuButton;

namespace Shoppa
{
    public partial class frmMain : Form
    {
        private SQL_Services mySqlServices = new SQL_Services();
        private string AccountID;

        FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();

        public frmMain(string AccountID)
        {
            InitializeComponent();

            this.AccountID = AccountID;
        }

        private void ColorButton(BunifuButton clickedButton)
        {
            foreach (var control in Controls)
            {
                if (control is BunifuButton)
                {
                    ((BunifuButton)control).OnPressedState.FillColor = Color.DarkViolet;
                    ((BunifuButton)control).OnPressedState.BorderColor = Color.DarkViolet;
                }
            }
            clickedButton.OnPressedState.FillColor = Color.FromArgb(95, 29, 155);
            clickedButton.OnPressedState.BorderColor = Color.FromArgb(95, 29, 155);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            mySqlServices.CloseDB();
        }

        private void btnProductView_Click(object sender, EventArgs e)
        {
            ColorButton((BunifuButton)sender);

            //


            DataTable dataTable = mySqlServices.ExecuteQueryTable("Select ProductName, Price, QuantityInStock, ProductImage From Products");

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    pnProductItem productItem = new pnProductItem();

                    productItem.Set_ProductName = row[0].ToString();
                    productItem.Set_Price = row[1].ToString();
                    productItem.Set_Sold = row[2].ToString();
                    productItem.Set_ProductImage = row[3].ToString();

                    flowLayoutPanel.Controls.Add(productItem);
                }
            }

            flowLayoutPanel.Location = new Point(200, 0);
            flowLayoutPanel.Size = new Size(670, 450);
            flowLayoutPanel.AutoScroll = true;
            this.Controls.Add(flowLayoutPanel);
        }

        private void btnCartView_Click(object sender, EventArgs e)
        {
            ColorButton((BunifuButton)sender);
        }

        private void btnUserInfoView_Click(object sender, EventArgs e)
        {
            ColorButton((BunifuButton)sender);

            uiUserInfo userInfoView = new uiUserInfo(AccountID);
            userInfoView.Location = new Point(200, 0);
            this.Controls.Add(userInfoView);
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            frmManageProduct frmManageProduct = new frmManageProduct();
            frmManageProduct.ShowDialog();
        }
    }
}