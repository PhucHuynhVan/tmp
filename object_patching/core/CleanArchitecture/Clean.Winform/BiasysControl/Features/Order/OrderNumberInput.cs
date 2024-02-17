using BiasysControl.UICommon;

namespace BiasysControl.Features.Order
{
    public partial class OrderNumberInput : Form
    {
        public event FormClosed OnFormClose;
        MainForm _mainForm = null;
        private readonly BiasysControl.UICommon.UICommon uiCommon = BiasysControl.UICommon.UICommon.Instance;
        int countArticlePartNumber = 0;

        public OrderNumberInput(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

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
            var ucContent = uiCommon.FindControlByName(_mainForm.pnlRightContent, "ucContent");
            
            if (this.txtOrderNumber.Visible)
            {
                
                if (ucContent != null)
                {
                    var nameOfControl = string.Concat("txtArticleInfo", countArticlePartNumber.ToString());
                    SetArticlePartNumberValue(ucContent, nameOfControl, txtOrderNumber.Text);
                    countArticlePartNumber++;
                    txtOrderNumber.Text = string.Empty;
                    if (countArticlePartNumber > GetArticleNumberMockData())
                    {
                        this.Text = "Part number";
                        this.lblBobbinNumber.Text = "Enter/scan part number";
                        this.txtPartNumber.Text = string.Empty;
                        this.txtPartNumber.Visible = true;
                        this.txtOrderNumber.Visible = false;
                        countArticlePartNumber = 0;
                    }
                }
            }
            else
            {
                countArticlePartNumber++;                
                
                if (countArticlePartNumber == GetPartNumberMockData())
                {
                    _mainForm.EnableMainButtons(true);
                    _mainForm.UpdateMassageHeader("Too many stitches", "Press Machine Button Reset and Cancel Sewing");
                    this.Close();
                }
                if (ucContent != null)
                {
                    var nameOfControl = string.Concat("txtPart", countArticlePartNumber.ToString());
                    SetArticlePartNumberValue(ucContent, nameOfControl, txtPartNumber.Text); 
                }
                this.txtPartNumber.Text = string.Empty;
            }
        }

        private void SetArticlePartNumberValue(Control ucContent, string nameofControl, string value)
        {            
            var txtArticlePartControl = uiCommon.FindControlByName(ucContent, nameofControl) as TextBox;
            if (txtArticlePartControl != null)
            {
                txtArticlePartControl.Text = value;
            }
        }

        private TextBox lastFocusedTextBox = null;
        private void txtOrderNumber_MouseLeave(object sender, EventArgs e)
        {
            if (txtOrderNumber.Focused)
                lastFocusedTextBox = txtOrderNumber;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uiCommon.ImplementNummericButton(lastFocusedTextBox, (Button)sender);
        }

        private void txtPartNumber_MouseLeave(object sender, EventArgs e)
        {
            if (txtPartNumber.Focused)
                lastFocusedTextBox = txtPartNumber;
        }

        private void OrderNumberInput_Load(object sender, EventArgs e)
        {
            this.txtOrderNumber.Focus();
            countArticlePartNumber++;
        }

        private int GetPartNumberMockData()
        {
            return 5;
        }
        private int GetArticleNumberMockData()
        {
            return 4;
        }
    }
}
