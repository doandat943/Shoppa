using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Shoppa
{
    public partial class pnRatingStar : UserControl
    {
        Dictionary<PictureBox, bool> picDictionary = new Dictionary<PictureBox, bool>();
        private int StarValue;
        private bool ratingMode;

        public bool RatingMode
        {
            set => ratingMode = value;
        }

        public pnRatingStar()
        {
            InitializeComponent();

            picDictionary.Add(pbStar1, true);
            picDictionary.Add(pbStar2, true);
            picDictionary.Add(pbStar3, true);
            picDictionary.Add(pbStar4, true);
            picDictionary.Add(pbStar5, true);
        }

        public void Set_StarValue(int StarValue)
        {
            this.StarValue = 0;
            foreach (KeyValuePair<PictureBox, bool> control in picDictionary)
            {
                if (++this.StarValue <= StarValue)
                {
                    control.Key.ImageLocation = "https://cloud.joverse.me:2023/application/Shoppa/icon/star_full_512px.png";
                }
                else
                {
                    control.Key.ImageLocation = "https://cloud.joverse.me:2023/application/Shoppa/icon/star_512px.png";
                }
            }
            this.StarValue = StarValue;
        }

        public int Get_StarValue
        {
            get => StarValue;
        }

        private void pbStar1_Click(object sender, EventArgs e)
        {
            if (ratingMode)
            {
                Set_StarValue(1);
            }
        }

        private void pbStar2_Click(object sender, EventArgs e)
        {
            if (ratingMode)
            {
                Set_StarValue(2);
            }
        }

        private void pbStar3_Click(object sender, EventArgs e)
        {
            if (ratingMode)
            {
                Set_StarValue(3);
            }
        }

        private void pbStar4_Click(object sender, EventArgs e)
        {
            if (ratingMode)
            {
                Set_StarValue(4);
            }
        }

        private void pbStar5_Click(object sender, EventArgs e)
        {
            if (ratingMode)
            {
                Set_StarValue(5);
            }
        }
    }
}
