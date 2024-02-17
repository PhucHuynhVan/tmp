using BiasysControl.UICommon;

namespace BiasysControl.Features.Bobbin
{
    public partial class BobbinNumberInput : Form
    {
        public event FormClosed OnFormClose;
        MainForm _mainForm = null;
        private readonly BiasysControl.UICommon.UICommon uiCommon = BiasysControl.UICommon.UICommon.Instance;
        public BobbinNumberInput(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void DoClosingForm()
        {
            OnFormClose.Invoke(this);
        }

        private void BobbinNumberInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            DoClosingForm();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtBobbinNumber.Visible)
            {
                txtNumberOfStitches.Visible = true;
                lblBobbinNumber.Text = "Input Number of Stitches on Bobbin";
                txtNumberOfStitches.Text = "2000";
                this.txtBobbinNumber.Visible = false;
            }
            else
            {
                _mainForm.DisplayActiveOrderNumberForm();

                this.Close();
            }
        }

        private TextBox lastFocusedTextBox = null;
        private void txtNumberOfStitches_MouseLeave(object sender, EventArgs e)
        {
            if (txtNumberOfStitches.Focused)
                lastFocusedTextBox = txtNumberOfStitches;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            uiCommon.ImplementNummericButton(lastFocusedTextBox, (Button)sender);
        }

        private void txtBobbinNumber_MouseLeave(object sender, EventArgs e)
        {
            if (txtBobbinNumber.Focused)
                lastFocusedTextBox = txtBobbinNumber;
        }
    }
}
