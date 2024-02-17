using Clean.Win.Apps;
using Clean.Win.AppUI.UICommon;
using System.Drawing;
using System.Windows.Forms;

namespace Clean.Win.AppUI.Forms
{
    public partial class AutomatSelect : Form
    {
        MainForm _mainform = null;
        public AutomatSelect(MainForm mainForm)
        {
            _mainform = mainForm;
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\Icons\\" + UIConstants.APP_0_Icon);
        }

        private void SelectInputForm_Load(object sender, System.EventArgs e)
        {

        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {

        }
    }
}
