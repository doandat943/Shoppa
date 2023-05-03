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

        private uiProductView uiProductView;
        private uiUserInfo uiUserInfo;

        public frmMain(string AccountID)
        {
            InitializeComponent();

            this.AccountID = AccountID;

            ///

            uiProductView = new uiProductView();
            uiProductView.Dock = DockStyle.Right;
            this.Controls.Add(uiProductView);

            uiUserInfo = new uiUserInfo(AccountID);
            uiUserInfo.Location = new Point(200, 0);
            this.Controls.Add(uiUserInfo);
            
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

            foreach (var control in Controls)
            {
                if (control is UserControl)
                {
                    ((UserControl)control).Hide();
                }
            }

            clickedButton.OnPressedState.FillColor = Color.FromArgb(95, 29, 155);
            clickedButton.OnPressedState.BorderColor = Color.FromArgb(95, 29, 155);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProductView_Click(object sender, EventArgs e)
        {
            ColorButton((BunifuButton)sender);

            //
            
            uiProductView.Show();
        }

        private void btnCartView_Click(object sender, EventArgs e)
        {
            ColorButton((BunifuButton)sender);
        }

        private void btnUserInfoView_Click(object sender, EventArgs e)
        {
            ColorButton((BunifuButton)sender);

            uiUserInfo.Show();
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            frmManageProduct frmManageProduct = new frmManageProduct();
            frmManageProduct.ShowDialog();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            uiProductView.Width = this.ClientSize.Width - panel1.Width;
            uiProductView.Height = this.ClientSize.Height;
        }
    }
}