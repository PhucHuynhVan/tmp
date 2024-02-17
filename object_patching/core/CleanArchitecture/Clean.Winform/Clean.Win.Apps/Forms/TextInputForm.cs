using Clean.Win.AppUI.UICommon;
using Clean.Win.AppUI.UICommon.Entities;
using Clean.Win.AppUI.UserControls;
using Clean.WinF.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Clean.Win.AppUI.Forms
{
    public partial class TextInputForm : Form
    {
        public event FormClosed OnFormClose;// this will help to close form       
        public IList<MandatoryInputs> _mandatoryInputs = null; //this variable will be configured at usercontrol side
        IList<ProcessEventArgs> textInputRets = new List<ProcessEventArgs>();
        int textInputOrder = 0;
        //define parent user controls here
        ucParts parentUcPart;
        ucArticle parentUcArticle;
        ucSuppliers parentUcSupplier;
        ucThreads parentUcThread;

        bool isUpperCaseInput = false;

        //Constructor
        public TextInputForm(UserControl parentControl)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\Icons\\" + UIConstants.APP_0_Icon);
            //assign value from constructor
            parentUcPart = parentControl as ucParts;
            parentUcArticle = parentControl as ucArticle;
            parentUcSupplier = parentControl as ucSuppliers;
            parentUcThread = parentControl as ucThreads;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextInputForm_Load(object sender, EventArgs e)
        {
            if (_mandatoryInputs != null)
            {
                var firstField = _mandatoryInputs.FirstOrDefault(p => p.OrderInput == 0);
                if (firstField != null)
                {
                    lblFieldName.Text = firstField.FieldName;
                    this.txtTextInput.Tag = firstField.TagValue;
                    this.txtTextInput.Text = firstField.TextValue;
                    textInputOrder = firstField.OrderInput;
                    isUpperCaseInput = firstField.IsUpperCase;
                    this.txtTextInput.Focus();
                }
            }
        }

        private bool IsValidDataInput()
        {
            var result = true;
            if (_mandatoryInputs != null)
            {
                //get configuration which developer manually defines at user control
                var currMandatoryInput = _mandatoryInputs.ToList().FirstOrDefault(p => p.OrderInput == textInputOrder);
                if (currMandatoryInput.IsRequired)
                {
                    if (string.IsNullOrEmpty(this.txtTextInput.Text.Trim()))
                    {
                        UIUtility.AppShowMsg(currMandatoryInput.MsgRequiredText, UIConstants.MSGBOX_ICON_ERROR_STYLE);
                        result = false;
                    }
                }

                if (currMandatoryInput.IsUniqued)
                {
                    if (!string.IsNullOrEmpty(this.txtTextInput.Text.Trim()))
                    {
                        if (parentUcPart != null)
                        {
                            //var existedInput = parentUcPart.datasourceParts.ToList().FirstOrDefault(p => p.Code.Equals(this.txtTextInput.Text.Trim()));
                            //if (existedInput != null)
                            //{
                            //    UIUtility.AppShowMsg(currMandatoryInput.MsgUniquedText, UIConstants.MSGBOX_ICON_ERROR_STYLE);
                            //    result = false;
                            //}
                        }
                        //we can implement for other user case here also
                    }
                }

                if (currMandatoryInput.IsAllowedSpecialChars)
                {
                    if (!string.IsNullOrEmpty(this.txtTextInput.Text.Trim()) && CleanWinFUtility.CheckSpecialCharacter(this.txtTextInput.Text.Trim()))
                    {
                        UIUtility.AppShowMsg(currMandatoryInput.MsgAllowedSpecialChars, UIConstants.MSGBOX_ICON_ERROR_STYLE);
                        //Remove special characters also
                        this.txtTextInput.Text = CleanWinFUtility.RemoveSpecialCharacter(this.txtTextInput.Text.Trim());
                        result = false;
                    }
                }
            }
            return result;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!IsValidDataInput())//valid data input which is difined in the list mandatoryinputs objects
            {
                return;
            }
            var processTextInput = new ProcessEventArgs() { TagValue = txtTextInput.Tag.ToString(), TextValue = txtTextInput.Text };
            textInputRets.Add(processTextInput);
            textInputOrder++;
            if (textInputOrder < _mandatoryInputs.Count)
            {
                var textInput = _mandatoryInputs[textInputOrder];
                if (textInput != null)
                {
                    lblFieldName.Text = textInput.FieldName;
                    this.txtTextInput.Tag = textInput.TagValue;
                    this.txtTextInput.Text = textInput.TextValue;
                    isUpperCaseInput = textInput.IsUpperCase;
                    this.txtTextInput.Focus();
                }
            }

            if (textInputOrder == _mandatoryInputs.Count)
            {
                ProcessTextValue(textInputRets);
            }
        }

        private void ProcessTextValue(IList<ProcessEventArgs> processRets)
        {
            //if (parentUcPart != null)
            //    parentUcPart.CompletedGridValueInput(this, processRets);
            this.Close();
        }

        private void DoClosingForm()
        {
            OnFormClose.Invoke(this);
        }

        private void TextInputForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DoClosingForm();
        }

        private void TextInputForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void txtTextInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void txtTextInput_TextChanged(object sender, EventArgs e)
        {
            if (isUpperCaseInput)
            {
                this.txtTextInput.Text = txtTextInput.Text.ToUpper();
                txtTextInput.SelectionStart = txtTextInput.Text.Length;
            }
        }
    }
}
