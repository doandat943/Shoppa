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

        private uiProductView uiProductView;
        private uiProductDetail uiProductDetail;
        private uiCartView uiCartView;
        private uiAccountView uiAccountView;
        private uiManageTool uiManageTool;

        public frmMain()
        {
            InitializeComponent();


            //
            uiProductView = new uiProductView();
            uiProductView.ClickProductImage += ProductItem_ClickProductImage;
            uiProductView.Dock = DockStyle.Right;
            this.Controls.Add(uiProductView);

            uiProductDetail = new uiProductDetail();
            uiProductDetail.Dock = DockStyle.Right;
            this.Controls.Add(uiProductDetail);

            uiCartView = new uiCartView();
            uiCartView.Dock = DockStyle.Right;
            this.Controls.Add(uiCartView);

            uiAccountView = new uiAccountView();
            uiAccountView.Dock = DockStyle.Right;
            this.Controls.Add(uiAccountView);

            uiManageTool = new uiManageTool();
            uiManageTool.Dock = DockStyle.Right;
            this.Controls.Add(uiManageTool);
        }

        private void ProductItem_ClickProductImage(object sender, string ProductID)
        {
            HideAllUserControl();

            uiProductDetail.Initialize(ProductID);
            uiProductDetail.Show();
        }

        public void Initialize(string AccountID)
        {
            this.AccountID = AccountID;

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

            uiCartView.Show();
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

            uiManageTool.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            uiProductView.Width = this.ClientSize.Width - panel1.Width;
            uiProductView.Height = this.ClientSize.Height;

            uiProductDetail.Width = this.ClientSize.Width - panel1.Width;
            uiProductDetail.Height = this.ClientSize.Height;

            uiAccountView.Width = this.ClientSize.Width - panel1.Width;
            uiAccountView.Height = this.ClientSize.Height;

            uiManageTool.Width = this.ClientSize.Width - panel1.Width;
            uiManageTool.Height = this.ClientSize.Height - panel1.Height;
        }
    }
}