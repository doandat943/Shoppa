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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shoppa
{
    public partial class pnRatingStar : UserControl
    {
        Dictionary<PictureBox, bool> picDictionary = new Dictionary<PictureBox, bool>();

        public pnRatingStar()
        {
            InitializeComponent();
        }

        public void Set_StarValue(int StarValue)
        {
            int temp = 0;
            foreach (KeyValuePair<PictureBox, bool> control in picDictionary)
            {
                if (++temp < StarValue)
                {
                    control.Key.ImageLocation = @"C:\Users\doandat943\Documents\Pichon\star_full_512px.png";
                }
            }
        }
    }
}
