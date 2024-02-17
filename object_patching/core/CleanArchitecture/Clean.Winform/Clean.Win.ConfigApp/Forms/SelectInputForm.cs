using Clean.Win.AppUI.UICommon;
using System.Drawing;
using System.Windows.Forms;

namespace Clean.Win.AppUI.Forms
{
    public partial class SelectInputForm : Form
    {
        public SelectInputForm()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\Icons\\" + UIConstants.APP_1_Icon);
        }

        private void SelectInputForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
