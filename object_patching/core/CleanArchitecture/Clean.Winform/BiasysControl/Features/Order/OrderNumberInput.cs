using BiasysControl.UICommon;
using Clean.WinF.Applications.Features.Article.DTOs;
using Clean.WinF.Domain.Entities;
using DocumentFormat.OpenXml.EMMA;

namespace BiasysControl.Features.Order
{
    public partial class OrderNumberInput : Form
    {
        public event FormClosed OnFormClose;
        MainForm _mainForm = null;
        private readonly BiasysControl.UICommon.UICommon uiCommon = BiasysControl.UICommon.UICommon.Instance;
        int countArticlePartNumber = 0;

        public ArticleDto article;
        private List<String> parts = new List<String>();
        private int currentPartIdx = 0;
        private int lastPartIdx = 0;

        private bool numOfPiece = false;

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
                    String articleCode = txtOrderNumber.Text;
                    this._mainForm.updateArticleInfo(articleCode, this);

                    //int partCount = 0;
                    parts.Add(article.FabricLeather1MaterialCode);
                    parts.Add(article.FabricLeather2MaterialCode);
                    parts.Add(article.FabricLeather3MaterialCode);
                    parts.Add(article.FabricLeather4MaterialCode);
                    parts.Add(article.FabricLeather5MaterialCode);

                    for(int i = 0; i < parts.Count; i++) {
                        if (parts[i] != null) {
                            lastPartIdx = i;
                        }
                    }
                    //MessageBox.Show("Parts size " + parts.Count + " - " + article.FabricLeather1MaterialCode);

                    SetArticlePartNumberValue(ucContent, nameOfControl, articleCode);

                    //this.Text = "Part number";
                    this.lblBobbinNumber.Text = "Enter/scan part";
                    this.txtPartNumber.Text = string.Empty;
                    this.txtPartNumber.Visible = true;
                    this.txtOrderNumber.Visible = false;
                    //countArticlePartNumber = 0;

                    //countArticlePartNumber++;
                    //txtOrderNumber.Text = string.Empty;
                    //if (countArticlePartNumber > GetArticleNumberMockData())
                    //{
                    //    this.Text = "Part number";
                    //    this.lblBobbinNumber.Text = "Enter/scan part";
                    //    this.txtPartNumber.Text = string.Empty;
                    //    this.txtPartNumber.Visible = true;
                    //    this.txtOrderNumber.Visible = false;
                    //    countArticlePartNumber = 0;
                    //}
                }
            }
            else
            {
                if(!numOfPiece)
                {
                    //this.lblBobbinNumber.Text = "enter/scan part";
                    // find next available part
                    int i = currentPartIdx;
                    for(; i< parts.Count; i++)
                    {
                        if (parts[i] != null)
                        {
                            currentPartIdx++;
                            break;
                        }
                    }
                    if (ucContent != null)
                    {
                        var nameOfControl = string.Concat("txtPart", (i+1).ToString());
                        SetArticlePartNumberValue(ucContent, nameOfControl, txtPartNumber.Text);
                    }
                    this.txtPartNumber.Text = string.Empty;
                    if(i == lastPartIdx)
                    {
                        numOfPiece = true;
                        _mainForm.EnableMainButtons(true);
                        _mainForm.UpdateMassageHeader("Too many stitches", "Press Machine Button Reset and Cancel Sewing");
                        this.lblBobbinNumber.Text = "Please enter the number of pieces.";
                    }
                } else
                {
                    SetArticlePartNumberValue(ucContent, "txtNoOfPiece", txtPartNumber.Text);
                    this.Close();
                }



                //countArticlePartNumber++;
                //if (countArticlePartNumber == GetPartNumberMockData())
                //{
                //    _mainForm.EnableMainButtons(true);
                //    _mainForm.UpdateMassageHeader("Too many stitches", "Press Machine Button Reset and Cancel Sewing");
                //    this.Close();
                //}
                //if (ucContent != null)
                //{
                //    var nameOfControl = string.Concat("txtPart", countArticlePartNumber.ToString());
                //    SetArticlePartNumberValue(ucContent, nameOfControl, txtPartNumber.Text); 
                //}
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
            return 1;
        }
    }
}
