using Clean.Win.AppUI.Forms;
using Clean.Win.AppUI.UICommon;
using Clean.Win.AppUI.UICommon.Entities;
using Clean.WinF.Applications.Features.Article.DTOs;
using Clean.WinF.Applications.Features.Article.Interfaces;
using Clean.WinF.Applications.Features.Automat.Interfaces;
using Clean.WinF.Applications.Features.Part.DTOs;
using Clean.WinF.Applications.Features.Part.Interfaces;
using Clean.WinF.Applications.Features.Thread.DTOs;
using Clean.WinF.Applications.Features.Thread.Interfaces;
using Clean.WinF.Common.Enum;
using Clean.WinF.Shared.Constants;
using Clean.WinF.Shared.ErrorMessage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clean.Win.AppUI.UserControls
{
    public partial class ucArticle : UserControl
    {
        private readonly IArticleQueryServices _queryService;
        private readonly IArticleCommandServices _commandService;
        private readonly IThreadQueryServices _queryThreadService;
        private readonly IThreadCommandServices _commandThreadService;
        private readonly IPartCommandServices _commandPartService;
        private readonly IPartQueryServices _queryPartService;
        public IAutomatCommandServices _automatCommandServices;
        public IAutomatQueryServices _automatQueryServices;
        List<ArticleDto> _data = new List<ArticleDto>();
        List<AutomatDto> _dataAutomat = new List<AutomatDto>();
        IEnumerable<ThreadDto> _dataThread = new List<ThreadDto>();
        IEnumerable<PartDto> _dataPart = new List<PartDto>();
        private int _selectedRowIdx = -1;
        private ArticleDto selectedDto;
        private readonly UICommon.UICommon uiCommon = UICommon.UICommon.Instance;


        public ucArticle(IArticleCommandServices commandService,
            IArticleQueryServices queryServices,
            IAutomatCommandServices automatCommandServices,
            IAutomatQueryServices automatQueryServices,
            IPartCommandServices commandPartService,
            IPartQueryServices queryPartService,
            IThreadCommandServices commandThreadService,
            IThreadQueryServices queryThreadService
            )
        {
            _automatCommandServices = automatCommandServices;
            _automatQueryServices = automatQueryServices;
            _commandService = commandService;
            _commandPartService = commandPartService;
            _queryPartService = queryPartService;
            _queryService = queryServices;
            _queryThreadService = queryThreadService;
            _commandThreadService = commandThreadService;
            InitializeComponent();
            ucStitchSection1.Visible = true;
            ucStitchSection3.Visible = false;
            ucStitchSection5.Visible = false;
            btn1Critical0notches.BackColor = Color.LightSteelBlue;
            btnSeamProfile.BackColor = Color.LightSteelBlue;
            ucThreadsPartsEndlabelInformation.OnDataChange += OnDataChange;
            ucSewingMachineParameter.OnDataChange += OnDataChange;
            ucStitchSection1.OnDataChange += OnDataStitchSectionChange;
            ucStitchSection3.OnDataChange += OnDataStitchSectionChange;
            ucStitchSection5.OnDataChange += OnDataStitchSectionChange;
            ucStitchSection1.Location = new Point(ucSeamProfile.Width + 200, pnlTop.Height + 40);
            ucStitchSection3.Location = new Point(ucSeamProfile.Width + 200, pnlTop.Height + 40);
            ucStitchSection5.Location = new Point(ucSeamProfile.Width + 200, pnlTop.Height + 40);
            ucSeamProfile.OnDataChange += OnDataChange;
            ucThreadsPartsEndlabelInformation.setServiceFromDB(_commandPartService, _queryPartService, _commandThreadService, _queryThreadService);
            Console.WriteLine();
        }


        private void showEndLabelPanel(ArticleDto model)
        {
            switch (model.SeamProfile)
            {
                case "TwoCriticalSectionFourSeamsWithTwoEndLabel":
                case "OneCriticalSectionTwoSeamsWithTwoEndLabel":
                case "ThreeCriticalSectionFourSeamsWithTwoEndLabel":
                    if (!ucStitchSection5.pnlEndlabel.Visible)
                        ucStitchSection5.pnlEndlabel.Visible = true;
                    ucStitchSection3.pnlEndlabel.Visible = false;
                    ucStitchSection1.pnlEndlabel.Visible = false;
                    break;
                case "ThreeCriticalSectionTwoSeamsWithEndLabel":
                case "OneCriticalSectionTwoSeamsWithEndLabel":
                case "OneCriticalSectionTwoSeamsWithEndLabelBehind":
                    if (!ucStitchSection3.pnlEndlabel.Visible)
                        ucStitchSection3.pnlEndlabel.Visible = true;
                    ucStitchSection5.pnlEndlabel.Visible = false;
                    ucStitchSection1.pnlEndlabel.Visible = false;
                    break;
                case "ThreeCriticalSectionFourSeamsWithEndLabel":
                case "TwoCriticalSectionFourSeamsWithEndLabelBehind":
                case "ThreeCriticalSectionFourSeamsWithEndLabelBehind":
                case "TwoCriticalSectionFourSeamsWithEndLabel":
                    if (!ucStitchSection5.pnlEndlabel.Visible)
                        ucStitchSection5.pnlEndlabel.Visible = true;
                    ucStitchSection3.pnlEndlabel.Visible = false;
                    ucStitchSection1.pnlEndlabel.Visible = false;
                    break;
                case "OneCriticalSectionNoSeamsWithEndLabel":
                    if (!ucStitchSection1.pnlEndlabel.Visible)
                        ucStitchSection1.pnlEndlabel.Visible = true;
                    ucStitchSection5.pnlEndlabel.Visible = false;
                    ucStitchSection3.pnlEndlabel.Visible = false;
                    break;
                default:
                    ucStitchSection5.pnlEndlabel.Visible = false;
                    ucStitchSection3.pnlEndlabel.Visible = false;
                    ucStitchSection1.pnlEndlabel.Visible = false;
                    break;

            }
        }

        private void showSeamProfile(ArticleDto dto)
        {
            if (isReloadStitchSection)
            {
                switch (dto.SeamProfile)
                {
                    case "TwoCriticalSectionFourSeamsWithTwoEndLabel":
                    case "OneCriticalSectionTwoSeamsWithTwoEndLabel":
                    case "ThreeCriticalSectionFourSeamsWithTwoEndLabel":
                        changeProfileButtonSelection(3);
                        ucSeamProfile.ShowProfile(3);
                        ucStitchSection1.Visible = false;
                        ucStitchSection3.Visible = false;
                        ucStitchSection5.Visible = true;
                        break;
                    case "ThreeCriticalSectionTwoSeamsWithFLPart":
                    case "ThreeCriticalSectionTwoSeamsWithEndLabel":
                    case "OneCriticalSectionTwoSeamsWithFLPart":
                    case "OneCriticalSectionTwoSeamsWithEndLabel":
                    case "OneCriticalSectionTwoSeamsWithEndLabelBehind":
                        changeProfileButtonSelection(1);
                        ucSeamProfile.ShowProfile(1);
                        ucStitchSection1.Visible = false;
                        ucStitchSection3.Visible = true;
                        ucStitchSection5.Visible = false;
                        break;
                    case "ThreeCriticalSectionFourSeamsWithFLPart":
                    case "ThreeCriticalSectionFourSeamsWithEndLabel":
                    case "TwoCriticalSectionFourSeamsWithEndLabelBehind":
                    case "ThreeCriticalSectionFourSeamsWithEndLabelBehind":
                    case "TwoCriticalSectionFourSeamsWithEndLabel":
                    case "TwoCriticalSectionFourSeamsWithFLPart":
                        changeProfileButtonSelection(2);
                        ucSeamProfile.ShowProfile(2);
                        ucStitchSection1.Visible = false;
                        ucStitchSection3.Visible = false;
                        ucStitchSection5.Visible = true;
                        break;
                    default:
                        changeProfileButtonSelection(0);
                        ucSeamProfile.ShowProfile(0);
                        ucStitchSection1.Visible = true;
                        ucStitchSection3.Visible = false;
                        ucStitchSection5.Visible = false;
                        break;

                }
            }

        }

        private async Task InitDataAsync()
        {
            _dataAutomat = await this._automatQueryServices.ListAllAsync();
            if (_dataAutomat.Count == 0)
            {
                var rs = await _automatCommandServices.CreateBulkAutomats(new List<AutomatDto>()
                {
                    new AutomatDto(){Code = "E84",Name="E84", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now, IsActive = true},
                    new AutomatDto(){Code = "FX5.8",Name="FX5.8", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now, IsActive = true}
                });
                if (rs)
                {
                    _dataAutomat = await this._automatQueryServices.ListAllAsync();
                }

            }
            _data = await _queryService.ListAllAsync();
            if (_data.Count == 0)
            {
                var rs = await _commandService.CreateBulkArticles(new List<ArticleDto>()
                {
                    new ArticleDto(){Code = "732415901",Name="E84 FS SPT LH NENX", Automat = _dataAutomat[0], CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now, IsActive = true},
                    new ArticleDto(){Code = "732415902",Name="FX5.8 FS SPT LH NENX", Automat = _dataAutomat[1], CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now, IsActive = true}
                });
                if (rs)
                {
                    _data = await _queryService.ListAllAsync();
                    await Console.Out.WriteLineAsync();
                }
            }
            _dataThread = await _queryThreadService.ListAllAsync();
            _dataPart = await _queryPartService.ListAllAsync();



        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            showInputDataDiaglog();
        }

        private void reloadGridView()
        {
            this.updateGridViewData(this._data);
        }
        Image createImage = Image.FromFile("Icons\\createnew.png");
        Image changeImage = Image.FromFile("Icons\\change.png");
        Image automatImage = Image.FromFile("Icons\\Button\\10.BMP");
        Image ImageLabelDefinition = Image.FromFile("Icons\\Button\\label.bmp");
        Image ImageEndlabel = Image.FromFile("Icons\\Button\\label.bmp");
        Image noneImage = new Bitmap(1, 1);
        private bool _refreshGrid = false;

        private Image getStatusChangeBitmap(ArticleDto dto)
        {
            if (dto.IsCreated)
            {
                return createImage;
            }
            if (dto.IsUpdated)
            {
                return changeImage;
            }
            return noneImage;
        }

        private void updateGridViewData(List<ArticleDto> data)
        {
            if (data.Count > 0)
            {
                foreach (var item in _data)
                {
                    item.AutomatCode = item.Automat != null ? item.Automat.Code : "";
                    item.StatusChange = getStatusChangeBitmap(item);
                    item.ImageAutomat = automatImage;
                    item.ImageEndlabel = ImageEndlabel;
                    item.ImageLabelDefinition = ImageLabelDefinition;
                }

                this.drgArticle.DataSource = null;
                this.drgArticle.DataSource = _data;

            }
            else
            {
                this.drgArticle.DataSource = null;
            }
            this.drgArticle.Refresh();


        }
        private async void refreshData()
        {

            // debug code begin
            _data = await this._queryService.ListAllAsync();
            //_data = _data.OrderByDescending(x => x.ID).ToList();
            _dataAutomat = await this._automatQueryServices.ListAllAsync();

            // debug code end
            this.reloadGridView();
        }

        private void btnRejectChanges_Click(object sender, EventArgs e)
        {
            refreshData();
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            var addedArticles = _data.ToList().FindAll(p => p.IsCreated == true);
            var updatedArticles = _data.ToList().FindAll(p => p.IsUpdated == true);
            var deletedArticles = _data.ToList().FindAll(p => p.IsDeleted == true);
            if ((addedArticles != null && addedArticles.Count > 0))
            {
                await _commandService.CreateBulkArticles(addedArticles);
            }
            if ((updatedArticles != null && updatedArticles.Count > 0))
            {
                await _commandService.UpdateBulkArticles(updatedArticles);
            }
            if ((deletedArticles != null && deletedArticles.Count > 0))
            {
                foreach (var article in deletedArticles)
                {
                    await _commandService.DeleteArticle(article);
                }
            }
            UIUtility.AppShowMsg(CustomErrorMessage.APP_ARTICLE_UPDATED_SUCCESS);
            //reload data on gridview again
            refreshData();
        }
        private void ucArticles_Load(object sender, EventArgs e)
        {
            configGridView();
            InitDataAsync();
            refreshData();
            uiCommon.IsImplementedUIPermision(this, nameof(MenuEnums.Articles));
        }


        //manually select row in datagridview
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this._refreshGrid)
            {
                this._refreshGrid = false;
                this.reloadGridView();
            }

            var targetGridView = sender as DataGridView;
            if (targetGridView.SelectedRows.Count > 0)
            {
                var selectedRow = targetGridView.SelectedRows[0];
                if (selectedRow != null && selectedRow.Selected)
                {
                    //MessageBox.Show($"onGridViewSelectionChanged: {selectedRow.Index} - {selectedRow.Selected} - grid count:: {this.mainGridView.Rows.Count}");
                    this._selectedRowIdx = selectedRow.Index;
                    this.onRowChange(selectedRow);
                }
            }

        }

        public void updateSelectedDTOData(ArticleDto articleDto)
        {
            articleDto = _data[_selectedRowIdx];
            articleDto.Code = txtArticleCode.Text;
            articleDto.Name = txtArticleName.Text;
            articleDto.FreeSeamCountStart = txtNumberOfFreeSeam.Text;
            articleDto.MaxStitchesFreeSeam = txtMaxNumberOfStitchesPerSeam.Text;
            articleDto.IsUpdated = true;
            articleDto.StatusChange = getStatusChangeBitmap(_data[_selectedRowIdx]);
            ucSewingMachineParameter.updateDataForDto();
            _refreshGrid = true;
        }


        private void onRowChange(DataGridViewRow selectedRow)
        {
            if (selectedRow != null)
            {
                //MessageBox.Show($"onRowChange: selectedRow = {this._selectedRowIdx}");
                this.updateFormData(this.getCurrentRowData());
            }
        }


        private void updateFormData(ArticleDto model)
        {
            if (model != null && model.Automat != null)
            {
                txtArticleCode.Text = model.Code;
                txtArticleName.Text = model.Name;
                txtNumberOfFreeSeam.Text = model.FreeSeamCountStart;
                txtMaxNumberOfStitchesPerSeam.Text = model.MaxStitchesFreeSeam;
                showSeamProfile(model);
                showEndLabelPanel(model);
                ucSewingMachineParameter.dto = model;
                ucSewingMachineParameter.updateFormData();
                ucStitchSection1.dto = model;
                ucStitchSection1.updateFormData();
                ucStitchSection3.dto = model;
                ucStitchSection3.updateFormData();
                ucStitchSection5.dto = model;
                ucStitchSection5.updateFormData();
                ucSeamProfile.dto = model;
                ucSeamProfile.updateFormData();
                ucThreadsPartsEndlabelInformation.dto = model;
                ucThreadsPartsEndlabelInformation.loadThreadFromDB();
                ucThreadsPartsEndlabelInformation.updateFormData();

            }
        }

        private ArticleDto getCurrentRowData()
        {
            ArticleDto ret = null;
            if (_selectedRowIdx != -1)
            {
                ret = this._data[_selectedRowIdx];
            }
            return ret;
        }


        private void configGridView()
        {
            this.drgArticle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.drgArticle.ScrollBars = ScrollBars.Both;
            this.drgArticle.AutoGenerateColumns = false;
            this.drgArticle.ReadOnly = false;

            // config gridview display columns
            this.configGridViewColumn(this.drgArticle, "", "StatusChange", "DataGridViewImageColumn", 40);
            this.configGridViewColumn(this.drgArticle, "Artical Code", "Code", "DataGridViewTextBoxColumn", 220);
            this.configGridViewColumn(this.drgArticle, "Name", "Name", "DataGridViewTextBoxColumn", 450);
            this.configGridViewColumn(this.drgArticle, "Automat", "AutomatCode", "DataGridViewTextBoxColumn", 80);
            this.configGridViewColumn(this.drgArticle, "", "ImageAutomat", "DataGridViewImageColumn", 40);
            this.configGridViewColumn(this.drgArticle, "Label Definition", "LabelDefinition", "DataGridViewTextBoxColumn");
            this.configGridViewColumn(this.drgArticle, "", "ImageLabelDefinition", "DataGridViewImageColumn", 60);
            this.configGridViewColumn(this.drgArticle, "Endlabel Script", "Endlabel", "DataGridViewTextBoxColumn");
            this.configGridViewColumn(this.drgArticle, "", "ImageEndlabel", "DataGridViewImageColumn", 60);
            this.configGridViewColumn(this.drgArticle, "Version", "Version", "DataGridViewTextBoxColumn", 125, true);
            this.configGridViewColumn(this.drgArticle, "Created By", "CreatedBy", "DataGridViewTextBoxColumn", 125, true);
            for (int i = 0; i < drgArticle.Columns.Count; i++)
            {
                drgArticle.Columns[i].ReadOnly = false;
            }

        }

        private void configGridViewColumn(DataGridView dataGridView,
            string header, string property, string type, int width = 150, bool isHightlight = false)
        {
            DataGridViewColumn column;
            switch (type)
            {
                case "DataGridViewImageColumn":
                    column = new DataGridViewImageColumn();
                    break;
                default:
                    column = new DataGridViewTextBoxColumn();
                    break;

            }
            column.HeaderText = header;
            column.DataPropertyName = property;
            column.Tag = property;
            column.Width = width;
            column.ReadOnly = false;
            column.DefaultCellStyle.BackColor = isHightlight ? Color.LightYellow : Color.White;
            dataGridView.Columns.Add(column);
        }

        private void showAutomatDiaglog()
        {
            //prepair data
            List<InputDataStep> steps = new List<InputDataStep>();
            steps.Add(new InputDataStep
            {
                PropertyName = "Automat",
                ControllType = EInputDataType.DATAGRIDVIEW,
                ExtraData = _dataAutomat

            });
            selectedDto = getCurrentRowData();
            selectedDto.IsUpdated = true;
            ArticleDto articleDto = selectedDto;
            InputDataForm inputDataForm = new InputDataForm(steps, articleDto, EInputDataForm.ARTICLE);
            inputDataForm.OnFormClose += OnClosingDataInputForm;
            inputDataForm.ShowDialog();
        }

        private void showInputDataDiaglog()
        {
            //prepair data
            List<InputDataStep> steps = new List<InputDataStep>();
            steps.Add(new InputDataStep
            {
                PropertyName = "Code",
                ControllType = EInputDataType.TEXTBOX
            });
            steps.Add(new InputDataStep
            {
                PropertyName = "Name",
                ControllType = EInputDataType.TEXTBOX
            });

            ArticleDto articleDto = new ArticleDto()
            {
                IsActive = true,
                IsCreated = true
            };
            _data.Add(articleDto);
            reloadGridView();
            _selectedRowIdx = _data.Count - 1;
            //this.drgArticle.Rows[_selectedRowIdx].Selected = true;
            this.drgArticle.CurrentCell = this.drgArticle.Rows[_selectedRowIdx].Cells[0];
            this.onRowChange(drgArticle.Rows[_selectedRowIdx]);
            if (_dataAutomat.Count == 1)
            {
                articleDto.Automat = _dataAutomat[0];
            }
            else
            {
                steps.Add(new InputDataStep
                {
                    PropertyName = "Automat",
                    ControllType = EInputDataType.DATAGRIDVIEW,
                    ExtraData = _dataAutomat

                });
            }
            InputDataForm inputDataForm = new InputDataForm(steps, articleDto, EInputDataForm.ARTICLE);
            inputDataForm.OnFormClose += OnClosingDataInputForm;
            inputDataForm.ShowDialog();
        }


        private void OnClosingDataInputForm(Object inputObject, string status)
        {
            switch (status)
            {
                case CommonConstant.InputDataFinished:
                    selectedDto = (ArticleDto)inputObject;
                    this.handleDataCallback(selectedDto);
                    //this.drgArticle.Rows[_selectedRowIdx].Selected = true;
                    this.drgArticle.CurrentCell = this.drgArticle.Rows[_selectedRowIdx].Cells[0];
                    this.onRowChange(drgArticle.Rows[_selectedRowIdx]);
                    break;
                default:
                    //close form
                    _selectedRowIdx = 0;
                    selectedDto = (ArticleDto)inputObject;
                    if (selectedDto.ID == 0)
                    {
                        _data.RemoveAt(_data.Count - 1);

                    }
                    reloadGridView();
                    break;
            }
        }
        private void OnDataChange()
        {
            reloadGridView();
        }
        bool isReloadStitchSection = true;
        private void OnDataStitchSectionChange()
        {
            isReloadStitchSection = false;
            reloadGridView();
            isReloadStitchSection = true;
        }
        private void handleDataCallback(ArticleDto dto)
        {
            txtArticleCode.Text = dto.Code;
            txtArticleName.Text = dto.Name;
            this.reloadGridView();
        }

        private void changeProfileButtonSelection(int index)
        {
            switch (index)
            {
                case 1:
                    btn1Critical2notches.BackColor = Color.LightSteelBlue;
                    btn1Critical0notches.BackColor = SystemColors.ButtonFace;
                    btn1Critical0notches.UseVisualStyleBackColor = true;
                    btn1Critical4notches.BackColor = SystemColors.ButtonFace;
                    btn1Critical4notches.UseVisualStyleBackColor = true;
                    btnCustomSeam.BackColor = SystemColors.ButtonFace;
                    btnCustomSeam.UseVisualStyleBackColor = true;
                    break;
                case 2:
                    btn1Critical4notches.BackColor = Color.LightSteelBlue;
                    btn1Critical0notches.BackColor = SystemColors.ButtonFace;
                    btn1Critical0notches.UseVisualStyleBackColor = true;
                    btn1Critical2notches.BackColor = SystemColors.ButtonFace;
                    btn1Critical2notches.UseVisualStyleBackColor = true;
                    btnCustomSeam.BackColor = SystemColors.ButtonFace;
                    btnCustomSeam.UseVisualStyleBackColor = true;
                    break;
                case 3:
                    btnCustomSeam.BackColor = Color.LightSteelBlue;
                    btn1Critical0notches.BackColor = SystemColors.ButtonFace;
                    btn1Critical0notches.UseVisualStyleBackColor = true;
                    btn1Critical2notches.BackColor = SystemColors.ButtonFace;
                    btn1Critical2notches.UseVisualStyleBackColor = true;
                    btn1Critical4notches.BackColor = SystemColors.ButtonFace;
                    btn1Critical4notches.UseVisualStyleBackColor = true;
                    break;
                default:
                    btn1Critical0notches.BackColor = Color.LightSteelBlue;
                    btn1Critical2notches.BackColor = SystemColors.ButtonFace;
                    btn1Critical2notches.UseVisualStyleBackColor = true;
                    btn1Critical4notches.BackColor = SystemColors.ButtonFace;
                    btn1Critical4notches.UseVisualStyleBackColor = true;
                    btnCustomSeam.BackColor = SystemColors.ButtonFace;
                    btnCustomSeam.UseVisualStyleBackColor = true;
                    break;
            }
        }

        private void btn1Critical0notches_Click(object sender, EventArgs e)
        {
            changeProfileButtonSelection(0);
            ucStitchSection1.updateFormData();
            ucStitchSection1.Visible = true;
            ucStitchSection3.Visible = false;
            ucStitchSection5.Visible = false;
            ucSeamProfile.ShowProfile(0);
        }

        private void btn1Critical2notches_Click(object sender, EventArgs e)
        {
            changeProfileButtonSelection(1);
            ucStitchSection3.updateFormData();
            ucStitchSection1.Visible = false;
            ucStitchSection3.Visible = true;
            ucStitchSection5.Visible = false;
            ucSeamProfile.ShowProfile(1);
        }

        private void btn1Critical4notches_Click(object sender, EventArgs e)
        {
            changeProfileButtonSelection(2);
            ucStitchSection5.updateFormData();
            ucStitchSection1.Visible = false;
            ucStitchSection3.Visible = false;
            ucStitchSection5.Visible = true;
            ucSeamProfile.ShowProfile(2);
        }

        private void btnCustomSeam_Click(object sender, EventArgs e)
        {

            changeProfileButtonSelection(3);
            ucSeamProfile.ShowProfile(3);
        }

        private void btnSeamProfile_Click(object sender, EventArgs e)
        {
            pnlProfileDetail.Visible = true;
            ucSewingMachineParameter.Visible = false;
            ucThreadsPartsEndlabelInformation.Visible = false;

            btnSeamProfile.BackColor = Color.LightSteelBlue;

            btnSewingMachineParameter.BackColor = SystemColors.ButtonFace;
            btnSewingMachineParameter.UseVisualStyleBackColor = true;

            btnMaterialMiscellaneousParameter.BackColor = SystemColors.ButtonFace;
            btnMaterialMiscellaneousParameter.UseVisualStyleBackColor = true;
        }

        private void btnSewingMachineParameter_Click(object sender, EventArgs e)
        {

            btnSewingMachineParameter.BackColor = Color.LightSteelBlue;

            btnSeamProfile.BackColor = SystemColors.ButtonFace;
            btnSeamProfile.UseVisualStyleBackColor = true;

            btnMaterialMiscellaneousParameter.BackColor = SystemColors.ButtonFace;
            btnMaterialMiscellaneousParameter.UseVisualStyleBackColor = true;

            pnlProfileDetail.Visible = false;
            ucSewingMachineParameter.Visible = true;
            ucThreadsPartsEndlabelInformation.Visible = false;

        }

        private void btnMaterialMiscellaneousParameter_Click(object sender, EventArgs e)
        {

            btnMaterialMiscellaneousParameter.BackColor = Color.LightSteelBlue;

            btnSeamProfile.BackColor = SystemColors.ButtonFace;
            btnSeamProfile.UseVisualStyleBackColor = true;

            btnSewingMachineParameter.BackColor = SystemColors.ButtonFace;
            btnSewingMachineParameter.UseVisualStyleBackColor = true;

            pnlProfileDetail.Visible = false;
            ucSewingMachineParameter.Visible = false;
            ucThreadsPartsEndlabelInformation.Visible = true;
        }

        private void drgArticle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIdx = e.ColumnIndex;

            if (columnIdx != -1)
            {
                var dataGridViewColumn = drgArticle.Columns[e.ColumnIndex];
                if (dataGridViewColumn.Tag == "ImageAutomat")
                {
                    showAutomatDiaglog();
                }
            }

            if (columnIdx == 0 && this.drgArticle.Columns[columnIdx] is DataGridViewImageColumn)
            {
                //MessageBox.Show($"on click on reset {this._selectedRowIdx}");
                var selectedData = this._data[this._selectedRowIdx];
                if (selectedData != null && selectedData.IsUpdated)
                {
                    var originalData = this.getByIdAsync(selectedData.ID);
                    if (originalData != null)
                    {
                        this._data[this._selectedRowIdx] = originalData.Result;
                        this.reloadGridView();
                    }
                }
            }

        }
        private async Task<ArticleDto> getByIdAsync(long id)
        {
            return await _queryService.GetArticleById(id);
        }

        private void drgArticle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var targetGridView = sender as DataGridView;
            int rowIdx = targetGridView.CurrentCell.RowIndex;
            _data[rowIdx].IsUpdated = true;
            _data[rowIdx].StatusChange = getStatusChangeBitmap(_data[rowIdx]);
            _refreshGrid = true;

        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (sender is TextBox)
            {
                var dto = getCurrentRowData();
                if (dto != null)
                {
                    updateSelectedDTOData(dto);
                    if (!dto.IsCreated)
                    {
                        dto.IsUpdated = true;
                        _refreshGrid = true;
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Set properties for the SaveFileDialog
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.Title = "Save File";
                saveFileDialog.DefaultExt = "xlsx";

                // Show the SaveFileDialog
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file name
                    string filePath = saveFileDialog.FileName;
                    List<string> selectedIndices = new List<string>();

                    foreach (DataGridViewRow row in drgArticle.SelectedRows)
                    {
                        int rowIndex = row.Index;
                        selectedIndices.Add(rowIndex.ToString());
                    }
                    List<ArticleDto> exportData = new List<ArticleDto>();
                    for (int i = 0; i < _data.Count; i++)
                    {
                        if (selectedIndices.Contains(i.ToString()))
                        {
                            exportData.Add(_data[i]);
                        }
                    }
                    _commandService.ExportBulkArticles(exportData, filePath);
                    MessageBox.Show("File exported successfully.", "Export");
                }
            }

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set properties of the dialog
            openFileDialog.Title = "Open File";
            openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";

            // Show the dialog and get the result
            DialogResult result = openFileDialog.ShowDialog();

            // Check if the user clicked OK in the dialog
            if (result == DialogResult.OK)
            {
                // Get the selected file's path
                string selectedFilePath = openFileDialog.FileName;

                List<ArticleDto> rs = _commandService.ImportBulkArticles(_data, _dataAutomat, _dataThread, _dataPart, selectedFilePath);

                if (rs.Count > 0)
                {
                    MessageBox.Show("Import File: " + selectedFilePath + " succeed", "Import");
                    _data.AddRange(rs);
                    reloadGridView();
                }
                else
                {
                    MessageBox.Show("Import failed", "Import");
                }
            }
        }
    }
}
