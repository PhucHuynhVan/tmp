using BiasysControl.UICommon;

namespace BiasysControl.UserControls
{
    public partial class ucContent : UserControl
    {
        private MainForm _mainForm;
        public ucContent(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            txtUser.Text = UIUtility.userLogin;
        }
    }
}
