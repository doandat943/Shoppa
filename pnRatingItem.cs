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
