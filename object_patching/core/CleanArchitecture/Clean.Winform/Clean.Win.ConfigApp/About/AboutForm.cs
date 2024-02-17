using Clean.Win.Apps;
using Clean.Win.AppUI.UICommon;
using System.Drawing;
using System.Windows.Forms;

namespace Clean.Win.AppUI.About
{
    public partial class AboutForm : Form
    {
        public event FormClosed OnFormClose;
        MainForm _mainForm = null;

        private readonly Clean.Win.AppUI.UICommon.UICommon uiCommon = Clean.Win.AppUI.UICommon.UICommon.Instance;
        public AboutForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            this.Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\Icons\\" + UIConstants.APP_1_Icon);
        }

        private void AboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DoClosingForm();
        }

        private void DoClosingForm()
        {
            OnFormClose.Invoke(this);
        }
    }
}
