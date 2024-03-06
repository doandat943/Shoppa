using Bunifu.UI.WinForms.BunifuButton;
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
    public partial class uiHomeView : UserControl
    {
        private int ImageNumber = 1;

        BunifuButton btn = new BunifuButton();
        public uiHomeView()
        {
            InitializeComponent();
        }

        void Slider()
        {
            if (ImageNumber == 4)
            {
                ImageNumber = 1;
            }
            pictureBox1.ImageLocation = "https://cloud.joverse.me:2023/application/Shoppa/ad" + ImageNumber + ".jpg";
            pictureBox2.ImageLocation = "https://cloud.joverse.me:2023/application/Shoppa/Banner.png";
            pictureBox3.ImageLocation = "https://cloud.joverse.me:2023/application/Shoppa/dock1.jpg";
            pictureBox4.ImageLocation = "https://cloud.joverse.me:2023/application/Shoppa/dock2.jpg";
            pictureBox5.ImageLocation = "https://cloud.joverse.me:2023/application/Shoppa/dock3.jpg";
            ImageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Slider();
        }

        public event EventHandler<string> ClickOnProduct;
        public event EventHandler<string> ClickOnCategory;

        private void btnOne_Click(object sender, EventArgs e)
        {
            ClickOnCategory?.Invoke(this, "1");
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            ClickOnCategory?.Invoke(this, "2");
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            ClickOnCategory?.Invoke(this, "3");
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            ClickOnCategory?.Invoke(this, "4");
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            ClickOnCategory?.Invoke(this, "5");
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            ClickOnCategory?.Invoke(this, "6");
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            ClickOnProduct?.Invoke(this, "7");
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            ClickOnCategory?.Invoke(this, "8");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ImageNumber == 2) ClickOnProduct?.Invoke(this, "SP00000015");
            else if (ImageNumber == 3) ClickOnProduct?.Invoke(this, "SP00000016");
            else if (ImageNumber == 4) ClickOnProduct?.Invoke(this, "SP00000017");
            else if (ImageNumber == 5) ClickOnProduct?.Invoke(this, "SP00000015");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ClickOnProduct?.Invoke(this, "SP00000023");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ClickOnProduct?.Invoke(this, "SP00000020");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ClickOnProduct?.Invoke(this, "SP00000014");
        }
    }
}
