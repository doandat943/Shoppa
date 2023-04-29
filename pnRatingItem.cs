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
    public partial class pnRatingItem : UserControl
    {
        public pnRatingItem()
        {
            InitializeComponent();
        }

        public string Set_AccountName
        {
            set => lbAccountName.Text = value;
        }

        public string Set_Comment
        {
            set => lbComment.Text = value;
        }
    }
}
