namespace BiasysControl.UserControls
{
    public partial class ucAppInformation : UserControl
    {
        private MainForm _mainForm;
        public ucAppInformation(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();

        }

        private void ucAppInformation_Load(object sender, EventArgs e)
        {
            //DisplayHeaderInformation();
        }

        private void DisplayHeaderInformation()
        {
            lblAppName.Left = (pnlInitialContent.Width / 2) - (lblAppName.Width / 2);
            lblAppVersion.Left = (pnlInitialContent.Width / 2) - (lblAppVersion.Width / 2);
            lblAppLicense.Left = (pnlInitialContent.Width / 2) - (lblAppLicense.Width / 2);
        }

        private void ucAppInformation_SizeChanged(object sender, EventArgs e)
        {
            DisplayHeaderInformation();
        }
    }
}
