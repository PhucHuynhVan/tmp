using Clean.Win.AppUI.UICommon;
using Clean.Win.AppUI.UICommon.Entities;
using Clean.WinF.Applications.Features.Article.DTOs;
using Clean.WinF.Applications.Features.Computer.DTOs;
using Clean.WinF.Applications.Features.Language.DTOs;
using Clean.WinF.Applications.Features.Part.DTOs;
using Clean.WinF.Applications.Features.SewingMachine.DTOs;
using Clean.WinF.Applications.Features.Supplier.DTOs;
using Clean.WinF.Applications.Features.Thread.DTOs;
using Clean.WinF.Applications.Features.Users.DTOs;
using Clean.WinF.Common.Enum;
using Clean.WinF.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Clean.Win.AppUI.Forms
{
    public partial class InputDataForm : Form

    {

        public delegate void FormInputDataClosed(Object inputObject, string status);

        public event FormInputDataClosed OnFormClose;// this will help to close form       
        private List<InputDataStep> steps = null;
        private int currentStepIdx = -1;
        private Object inputObject = new Object();
        private EInputDataForm inputFormType;
        private string drgSelectedID;
        private int _selectedRowIdx = -1;
        private Action action;
        private bool isDone = false;

        public InputDataForm(List<InputDataStep> steps, object data, EInputDataForm inputFormType)
        {
            this.steps = steps;
            this.inputObject = data;
            this.inputFormType = inputFormType;
            currentStepIdx = 0;
            InitializeComponent();
            InitBaseView();
            this.Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\Icons\\" + UIConstants.APP_0_Icon);
        }
        public InputDataForm(List<InputDataStep> steps, object data, EInputDataForm inputFormType, Action action)
        {
            this.steps = steps;
            this.inputObject = data;
            this.inputFormType = inputFormType;
            currentStepIdx = 0;
            InitializeComponent();
            InitBaseView();
            this.action = action;
        }

        private void InitBaseView()
        {
            InputDataStep inputDataStep = steps[currentStepIdx];
            int bottomBarHeight = 60;
            switch (inputDataStep.ControllType)
            {
                case EInputDataType.TEXTBOX:
                    pnlTextbox.Visible = true;
                    pnlDataGridView.Visible = false;
                    pnlUserConfig.Visible = false;
                    this.Height = 150 + bottomBarHeight;
                    this.Width = 400;
                    pnlTextbox.Height = 180;
                    pnlTextbox.Width = 400;
                    lblFieldName.Text = inputDataStep.PropertyName;
                    txtTextInput.Text = null;
                    txtTextInput.Focus();
                    break;
                case EInputDataType.DATAGRIDVIEW:
                    pnlDataGridView.Visible = true;

                    pnlTextbox.Visible = false;
                    pnlUserConfig.Visible = false;
                    this.Height = 200 + bottomBarHeight;
                    this.Width = 500;
                    pnlDataGridView.Height = 200;
                    pnlDataGridView.Width = 500;
                    switch (inputFormType)
                    {
                        case EInputDataForm.ARTICLE:
                            InitDataGridViewForArticle(inputDataStep);
                            break;
                        case EInputDataForm.THREADS:
                            InitDataGridViewForThread(inputDataStep);
                            break;
                        case EInputDataForm.USERS:
                            InitDataGridViewForUser(inputDataStep);
                            break;
                        case EInputDataForm.LANGUAGES:
                            InitDataGridViewForLanguages(inputDataStep);
                            break;
                        case EInputDataForm.SEWINGMACHINECONFIG:
                            InitDataGridViewForSewingMachineConfiguration(inputDataStep);
                            break;
                    }
                    break;
                case EInputDataType.USERCONFIG:
                    pnlUserConfig.Visible = true;

                    pnlTextbox.Visible = false;
                    pnlDataGridView.Visible = false;

                    pnlDataGridView.Height = 200;
                    pnlDataGridView.Width = 500;
                    break;

            }
        }

        private void InitDataGridViewForArticle(InputDataStep inputDataStep)
        {
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ScrollBars = ScrollBars.Both;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.MultiSelect = false;
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "ID",
                DataPropertyName = "ID"
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Code",
                DataPropertyName = "Code",
                Width = 150

            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Name",
                DataPropertyName = "Name",
                Width = 150

            });
            dataGridView.DataSource = inputDataStep.ExtraData;
            if (dataGridView.Rows.Count > 0)
            {
                dataGridView.Rows[0].Selected = true;

            }
            dataGridView.Refresh();
        }

        private void InitDataGridViewForThread(InputDataStep inputDataStep)
        {
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ScrollBars = ScrollBars.Both;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.MultiSelect = false;
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Name",
                DataPropertyName = "Name"
            });
            dataGridView.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                HeaderText = "Needle Thread",
                DataPropertyName = "NeedleThread",
                ReadOnly = true,
            });
            dataGridView.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                HeaderText = "Bobbin Thread",
                DataPropertyName = "BobbinThread",
                ReadOnly = true,
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Stitches on full Bobbin",
                DataPropertyName = "StitchesOnFullBobbin",
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Winding Duration on Machine [ms]",
                DataPropertyName = "WindingDurationOnMachine",
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Remark",
                DataPropertyName = "Remark",
            });
            dataGridView.DataSource = inputDataStep.ExtraData;
            dataGridView.Rows[0].Selected = true;
            dataGridView.Refresh();
        }

        private void InitDataGridViewForSewingMachineConfiguration(InputDataStep inputDataStep)
        {
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ScrollBars = ScrollBars.Both;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.MultiSelect = false;
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Clip Sensor Input",
                DataPropertyName = "Name"
            });

            dataGridView.DataSource = inputDataStep.ExtraData;
            dataGridView.Rows[0].Selected = true;
            dataGridView.Refresh();
        }

        private void InitDataGridViewForUser(InputDataStep inputDataStep)
        {
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ScrollBars = ScrollBars.Both;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.MultiSelect = false;
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "User Group",
                DataPropertyName = "Name"
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Description",
                DataPropertyName = "Description",
            });
            dataGridView.DataSource = inputDataStep.ExtraData;
            dataGridView.Rows[0].Selected = true;
            dataGridView.Refresh();
        }

        private void InitDataGridViewForLanguages(InputDataStep inputDataStep)
        {
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ScrollBars = ScrollBars.Both;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.MultiSelect = false;
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Language",
                DataPropertyName = "Lang",
                Width = 250

            });
            dataGridView.DataSource = inputDataStep.ExtraData;
            dataGridView.Rows[0].Selected = true;
            dataGridView.Refresh();
        }

        private void InputDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isDone)
            {
                OnFormClose.Invoke(inputObject, CommonConstant.FormClosed);
            }
            else
            {
                OnFormClose.Invoke(inputObject, CommonConstant.InputDataFinished);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //set input data to DTO
            switch (inputFormType)
            {
                case EInputDataForm.ARTICLE:
                    object value = null;
                    switch (steps[currentStepIdx].ControllType)
                    {
                        case EInputDataType.TEXTBOX:
                            //if (boolAction(txtTextInput.Text))
                            //{

                            //}
                            value = txtTextInput.Text;
                            break;
                        case EInputDataType.DATAGRIDVIEW:
                            if (steps[currentStepIdx].PropertyName.Equals("Automat"))
                                value = ((List<AutomatDto>)steps[currentStepIdx].ExtraData)[_selectedRowIdx];
                            if (steps[currentStepIdx].PropertyName.Equals("FabricLeather1ID")
                                || steps[currentStepIdx].PropertyName.Equals("FabricLeather2ID")
                                || steps[currentStepIdx].PropertyName.Equals("FabricLeather3ID")
                                || steps[currentStepIdx].PropertyName.Equals("FabricLeather4ID")
                                || steps[currentStepIdx].PropertyName.Equals("FabricLeather5ID")
                                )
                                value = ((List<PartDto>)steps[currentStepIdx].ExtraData)[_selectedRowIdx].ID;
                            if (steps[currentStepIdx].PropertyName.Equals("UpperThreadID")
                                || steps[currentStepIdx].PropertyName.Equals("LowerThreadID"))
                                value = ((List<ThreadDto>)steps[currentStepIdx].ExtraData)[_selectedRowIdx].ID;
                            break;
                    }
                    PropertyInfo propertyInfo = ((ArticleDto)inputObject).GetType().GetProperty(steps[currentStepIdx].PropertyName);
                    propertyInfo.SetValue(((ArticleDto)inputObject), Convert.ChangeType(value, propertyInfo.PropertyType), null);
                    break;
                case EInputDataForm.THREADS:
                    var dto = (ThreadDto)inputObject;
                    value = null;
                    switch (steps[currentStepIdx].ControllType)
                    {
                        case EInputDataType.TEXTBOX:
                            value = txtTextInput.Text;
                            propertyInfo = dto.GetType().GetProperty(steps[currentStepIdx].PropertyName);
                            propertyInfo.SetValue(dto, Convert.ChangeType(value, propertyInfo.PropertyType), null);
                            break;
                        case EInputDataType.DATAGRIDVIEW:
                            dto.WindingParamIdx = _selectedRowIdx;
                            break;
                    }
                    break;
                case EInputDataForm.PARTS:
                    var partDto = (PartDto)inputObject;
                    value = null;
                    switch (steps[currentStepIdx].ControllType)
                    {
                        case EInputDataType.TEXTBOX:
                            value = txtTextInput.Text;
                            propertyInfo = partDto.GetType().GetProperty(steps[currentStepIdx].PropertyName);
                            propertyInfo.SetValue(partDto, Convert.ChangeType(value, propertyInfo.PropertyType), null);
                            break;
                    }
                    break;
                case EInputDataForm.USERS:
                    var userDto = (UserDto)inputObject;
                    value = null;
                    switch (steps[currentStepIdx].ControllType)
                    {
                        case EInputDataType.TEXTBOX:
                            value = txtTextInput.Text;
                            propertyInfo = userDto.GetType().GetProperty(steps[currentStepIdx].PropertyName);
                            propertyInfo.SetValue(userDto, Convert.ChangeType(value, propertyInfo.PropertyType), null);
                            break;
                        case EInputDataType.DATAGRIDVIEW:
                            userDto.RoleIdx = _selectedRowIdx;
                            break;
                    }
                    break;
                // For Supplier  
                case EInputDataForm.SUPPLIERS:
                    string supplierValue = null;
                    switch (steps[currentStepIdx].ControllType)
                    {
                        case EInputDataType.TEXTBOX:
                            supplierValue = txtTextInput.Text;
                            break;
                    }
                    PropertyInfo supplierPropertyInfo = ((SupplierDto)inputObject).GetType().GetProperty(steps[currentStepIdx].PropertyName);
                    supplierPropertyInfo.SetValue(((SupplierDto)inputObject), Convert.ChangeType(supplierValue, supplierPropertyInfo.PropertyType), null);
                    break;
                // For Role 
                case EInputDataForm.USERGROUPS:
                    string roleValue = null;
                    switch (steps[currentStepIdx].ControllType)
                    {
                        case EInputDataType.TEXTBOX:
                            roleValue = txtTextInput.Text;
                            break;
                    }
                    PropertyInfo rolePropertyInfo = ((RoleDto)inputObject).GetType().GetProperty(steps[currentStepIdx].PropertyName);
                    rolePropertyInfo.SetValue(((RoleDto)inputObject), Convert.ChangeType(roleValue, rolePropertyInfo.PropertyType), null);
                    break;
                // For Languages
                case EInputDataForm.LANGUAGES:
                    var computerDto = (ComputerDto)inputObject;
                    string languageValue = null;
                    switch (steps[currentStepIdx].ControllType)
                    {
                        case EInputDataType.TEXTBOX:
                            value = txtTextInput.Text;
                            PropertyInfo languagePropertyInfo = ((LanguageDto)inputObject).GetType().GetProperty(steps[currentStepIdx].PropertyName);
                            languagePropertyInfo.SetValue(((LanguageDto)inputObject), Convert.ChangeType(languageValue, languagePropertyInfo.PropertyType), null);
                            break;
                        case EInputDataType.DATAGRIDVIEW:
                            computerDto.LanguagueForBiasysControlId = _selectedRowIdx;
                            computerDto.LanguagueForBiasysDBId = _selectedRowIdx;
                            break;
                    }
                    break;
                case EInputDataForm.SEWINGMACHINECONFIG:
                    var sewingMachineDto = (SewingMachineConfigurationDto)inputObject;
                    string sewingMachineValue = null;
                    switch (steps[currentStepIdx].ControllType)
                    {
                        case EInputDataType.TEXTBOX:
                            sewingMachineValue = txtTextInput.Text;
                            PropertyInfo sewingMachinePropertyInfo = ((SewingMachineConfigurationDto)inputObject).GetType().GetProperty(steps[currentStepIdx].PropertyName);
                            sewingMachinePropertyInfo.SetValue(((SewingMachineConfigurationDto)inputObject), Convert.ChangeType(sewingMachineValue, sewingMachinePropertyInfo.PropertyType), null);
                            break;
                        case EInputDataType.DATAGRIDVIEW:
                            sewingMachineDto.ClipSenserActivationIdx = _selectedRowIdx;
                            break;
                    }
                    break;
            }
            if (currentStepIdx < steps.Count - 1)
            {
                // setup new view
                currentStepIdx++;
                InitBaseView();

            }
            else
            {
                isDone = true;
                Close();
            }
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var targetGridView = sender as DataGridView;
            var selectedRow = targetGridView.CurrentRow;
            if (selectedRow != null)
            {
                _selectedRowIdx = selectedRow.Index;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTextInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnOK_Click(sender, e);
            }
        }

        private void InputDataForm_Load(object sender, EventArgs e)
        {

        }
    }
}
