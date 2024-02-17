using Clean.Win.Apps;
using System.Windows.Forms;

namespace Clean.Win.AppUI.UserControls
{
    public partial class ucDBInformation : UserControl
    {
        MainForm mainForm;
        public ucDBInformation(MainForm _mainform)
        {
            mainForm = _mainform;
            InitializeComponent();
        }
    }
}
