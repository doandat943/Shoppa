﻿using System;
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
        private string CartID;

        private uiProductView uiProductView;
        private uiProductDetail uiProductDetail;
        private uiCartView uiCartView;
        private uiHistoryView uiHistoryView;
        private uiAccountView uiAccountView;
        private uiManageTool uiManageTool;

        public frmMain()
        {
            InitializeComponent();
            
            //
            uiProductView = new uiProductView();
            uiProductView.ClickOnProduct += productItem_ClickOnProduct;
            uiProductView.AddToCart += productItem_AddToCart;
            uiProductView.Dock = DockStyle.Right;
            this.Controls.Add(uiProductView);

            uiProductDetail = new uiProductDetail();
            uiProductDetail.AddToCart += productItem_AddToCart;
            uiProductDetail.Dock = DockStyle.Right;
            this.Controls.Add(uiProductDetail);

            uiCartView = new uiCartView();
            uiCartView.Dock = DockStyle.Right;
            this.Controls.Add(uiCartView);

            uiHistoryView = new uiHistoryView();
            uiHistoryView.Dock = DockStyle.Right;
            this.Controls.Add(uiHistoryView);

            uiAccountView = new uiAccountView();
            uiAccountView.Dock = DockStyle.Right;
            this.Controls.Add(uiAccountView);

            uiManageTool = new uiManageTool();
            uiManageTool.Dock = DockStyle.Right;
            this.Controls.Add(uiManageTool);
        }

        private void productItem_ClickOnProduct(object sender, string ProductID)
        {
            HideAllUserControl();

            uiProductDetail.Initialize(ProductID);
            uiProductDetail.Show();
        }
        
        private void productItem_AddToCart(object sender, Tuple<string, string> e)
        {
            mySqlServices.AddParamater("@AccountID", AccountID);
            mySqlServices.AddParamater("@ProductID", e.Item1);
            mySqlServices.AddParamater("@Quantity", e.Item2);
            int temp = mySqlServices.ExecuteNonQuery("EXEC AddToCart @AccountID, @ProductID, @Quantity");
            if (temp != 0)
            {
                MessageBox.Show("Thêm mặt hàng vào giỏ thành công. Số lượng: " + e.Item2);
            }
        }

        public void Initialize(string AccountID)
        {
            this.AccountID = AccountID;
            lbAccountID.Text = AccountID;

            mySqlServices.AddParamater("@AccountID", AccountID);
            if (mySqlServices.ExecuteScalar("SELECT RoleID\r\nFROM dbo.Accounts\r\nWHERE AccountID = @AccountID") == "0")
            {
                btnManageTool.Dispose();
            }

            HideAllUserControl();
            uiProductView.Show();
        }

        private void HideAllUserControl()
        {
            foreach (var control in Controls)
            {
                if (control is UserControl)
                {
                    ((UserControl)control).Hide();
                }
            }
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

            HideAllUserControl();

            clickedButton.OnPressedState.FillColor = Color.FromArgb(95, 29, 155);
            clickedButton.OnPressedState.BorderColor = Color.FromArgb(95, 29, 155);
        }

        private void btnProductView_Click(object sender, EventArgs e)
        {
            ColorButton((BunifuButton)sender);
            
            uiProductView.Show();
        }

        private void btnCartView_Click(object sender, EventArgs e)
        {
            ColorButton((BunifuButton)sender);

            uiCartView.Initialize(AccountID);
            uiCartView.Show();
        }

        private void btnHistoryView_Click(object sender, EventArgs e)
        {
            ColorButton((BunifuButton)sender);
            
            uiHistoryView.Initialize(AccountID);
            uiHistoryView.Show();
        }

        private void btnAccountView_Click(object sender, EventArgs e)
        {
            ColorButton((BunifuButton)sender);

            uiAccountView.Initialize(AccountID);
            uiAccountView.Show();
        }

        private void btnManageTool_Click(object sender, EventArgs e)
        {
            ColorButton((BunifuButton)sender);

            uiManageTool.Initialize(AccountID);
            uiManageTool.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetControlSize(Control control)
        {
            control.Size = new Size(this.ClientSize.Width - panel1.Width, this.ClientSize.Height - (control == uiManageTool ? panel1.Height : 0));
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            SetControlSize(uiProductView);
            SetControlSize(uiProductDetail);
            SetControlSize(uiCartView);
            SetControlSize(uiHistoryView);
            SetControlSize(uiAccountView);
            SetControlSize(uiManageTool);
        }
    }
}