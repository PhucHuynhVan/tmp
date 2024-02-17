using BiasysControl;
using BiasysControl.UICommon;

namespace Clean.Win.AppUI.Forms
{

    public partial class AutomatSelect : Form
    {
        public event FormClosed OnFormClose;
        MainForm _mainForm = null;
        public AutomatSelect(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            //this.Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\Icons\\" + UIConstants.APP_0_Icon);
        }

        private void SelectInputForm_Load(object sender, System.EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainForm.DisplayActiveBobbinNumberForm();
        }

        private void DoClosingForm()
        {
            OnFormClose.Invoke(this);
        }

        private void AutomatSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            DoClosingForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
