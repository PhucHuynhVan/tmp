using Clean.Win.Apps;
using Clean.Win.AppUI.UICommon;
using Clean.WinF.Applications.Features.Bobbin.DTOs;
using Clean.WinF.Applications.Features.Bobbin.Interfaces;
using Clean.WinF.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace Clean.Win.AppUI.UserControls
{
    public partial class ucBobbinConfig : UserControl
    {
        private readonly IBobbinQueryServices _queryService;
        private readonly IBobbinCommandServices _commandService;

        private readonly UICommon.UICommon uiCommon = UICommon.UICommon.Instance;

        List<BobbinDto> _data = new List<BobbinDto>();
        int _selectedRowIdx = -1;

        bool isLoadData = false;

        public MainForm _mainForm = null;
        public ucBobbinConfig(MainForm mainForm)
        {
            isLoadData = true;
            _mainForm = mainForm;
            _commandService = mainForm._bobbinCommandServices;
            _queryService = mainForm._bobbinQueryServices;
            InitializeComponent();
        }

        private void ConfigGridView()
        {
            this.dgrBobbins.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.dgrBobbins.ScrollBars = ScrollBars.Both;
            this.dgrBobbins.AutoGenerateColumns = false;
            this.dgrBobbins.MultiSelect = false;
        }

        private void ucBobbinConfig_Load(object sender, EventArgs e)
        {
            ConfigGridView();
            LoadBobbinConfigData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBobbinConfigData();
            btnSave.Enabled = false;
        }

        private async void LoadBobbinConfigData()
        {
            isLoadData = true;
            var result = await _queryService.ListAllAsync();
            var datasources = (List<BobbinDto>)result;
            GridviewDataSource(datasources);
            var dataSource = (List<BobbinDto>)dgrBobbins.DataSource;
            GetInitialBobbinRows(dataSource);

            isLoadData = false;
        }

        private void GetInitialBobbinRows(List<BobbinDto> dataSources)
        {
            var rowNumbers = ConfigurationManager.AppSettings[AppConfigurationConstants.InitialBobbinRowGridView];
            int.TryParse(rowNumbers.ToString(), out int initRow);

            var lastAvailableRows = GetLastAvailableRows(dataSources);
            initRow = initRow - lastAvailableRows;

            if (initRow > 0 && dataSources != null)
            {
                for (var i = 0; i < initRow; i++)
                {
                    var newDataRow = new BobbinDto()
                    {
                        BobbinNo = dgrBobbins.RowCount + i + 1,
                        BobbinLabel = string.Empty,
                        ThreadLabel = string.Empty,
                        StitchCount = "0",
                        Machine = string.Empty
                    };
                    dataSources.Add(newDataRow);
                }

                GridviewDataSource(dataSources);
            }
        }

        private int GetLastAvailableRows(List<BobbinDto> sources)
        {
            var result = 0;
            if (sources != null && sources.Count > 0)
            {
                for (var i = sources.Count - 1; i >= 0; i--)
                {
                    var currBobbinDto = sources[i];
                    if (!string.IsNullOrEmpty(currBobbinDto.BobbinLabel) ||
                        !string.IsNullOrEmpty(currBobbinDto.ThreadLabel) ||
                        !string.IsNullOrEmpty(currBobbinDto.Machine) ||
                        currBobbinDto.StitchCount != "0")
                    {
                        break;
                    }
                    result++;
                }
            }

            return result;
        }

        private void GridviewDataSource(List<BobbinDto> sources)
        {
            if (sources != null)
            {
                dgrBobbins.DataSource = null;
                dgrBobbins.DataSource = sources;
                dgrBobbins.Refresh();
            }
        }

        private List<BobbinDto> _updatedBobbins = new List<BobbinDto>();
        private void dgrBobbins_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!isLoadData)//ensure working fine with loaded data
            {
                ChangeButtonStatus(true);
                var currID = dgrBobbins.Rows[e.RowIndex].Cells["colID"].Value is null ? 0 : (long)dgrBobbins.Rows[e.RowIndex].Cells["colID"].Value;

                var currBobbinNo = 0;
                if (dgrBobbins.Rows[e.RowIndex].Cells["colBobbinNo"].Value != null)
                    int.TryParse(dgrBobbins.Rows[e.RowIndex].Cells["colBobbinNo"].Value.ToString(), out currBobbinNo);

                var stitchCount = 0;
                if (dgrBobbins.Rows[e.RowIndex].Cells["colStitchCount"].Value != null)
                    int.TryParse(dgrBobbins.Rows[e.RowIndex].Cells["colStitchCount"].Value.ToString(), out stitchCount);

                if (e.ColumnIndex == 0)
                {
                    var existedBobbinNo = Array.Find(((List<BobbinDto>)dgrBobbins.DataSource).ToArray(), p => p.BobbinNo == currBobbinNo);
                    if (existedBobbinNo != null)
                    {
                        UIUtility.AppShowMsg("Please enter other Bobbin value due to duplicate Bobbin number");
                        return;
                    }
                }

                if (currID > 0)
                {
                    var existedBobbin = Array.Find(_updatedBobbins.ToArray(), p => p.ID == currID);
                    if (existedBobbin != null)
                    {
                        existedBobbin.BobbinNo = currBobbinNo;
                        existedBobbin.BobbinLabel = dgrBobbins.Rows[e.RowIndex].Cells["colBobbinLabel"].Value.ToString();
                        existedBobbin.ThreadLabel = dgrBobbins.Rows[e.RowIndex].Cells["colThreadLabel"].Value.ToString();
                        existedBobbin.StitchCount = stitchCount.ToString();
                        existedBobbin.Machine = dgrBobbins.Rows[e.RowIndex].Cells["colMachine"].Value.ToString();
                    }
                    else
                    {
                        var currBobbin = new BobbinDto()
                        {
                            BobbinNo = currBobbinNo,
                            BobbinLabel = dgrBobbins.Rows[e.RowIndex].Cells["colBobbinLabel"].Value.ToString(),
                            ThreadLabel = dgrBobbins.Rows[e.RowIndex].Cells["colThreadLabel"].Value.ToString(),
                            StitchCount = stitchCount.ToString(),
                            Machine = dgrBobbins.Rows[e.RowIndex].Cells["colMachine"].Value.ToString(),
                            ID = currID
                        };
                        _updatedBobbins.Add(currBobbin);
                    }
                }
            }
        }

        private void ChangeButtonStatus(bool isEnable)
        {
            btnSave.Enabled = isEnable;
            btnRefresh.Enabled = isEnable;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ChangeButtonStatus(false);
            SaveBobbinData();
            btnRefresh.Enabled = true;
        }

        private async void SaveBobbinData()
        {
            var isSuccess = false;
            var updatedBobbins = _updatedBobbins is null ? null : _updatedBobbins;
            var newBobbins = GetNewBobbins();
            //updated data
            if (updatedBobbins != null && updatedBobbins.Count > 0)
            {
                var res = await _commandService.UpdateBulk(updatedBobbins);
                isSuccess = res;
            }

            //added new data
            if (newBobbins != null && newBobbins.Count > 0)
            {
                var resAddingNew = await _commandService.CreateBulk(newBobbins);
                isSuccess = resAddingNew;
            }

            if (isSuccess)
            {
                UIUtility.AppShowMsg("Bobbin data is updated sucessful");
            }
        }

        private List<BobbinDto> GetNewBobbins()
        {
            var result = new List<BobbinDto>();
            for (var i = 0; i < dgrBobbins.Rows.Count; i++)
            {
                if (dgrBobbins.Rows[i].Cells["colID"].Value.ToString().Equals("0"))
                {
                    var newBobbin = new BobbinDto()
                    {
                        BobbinNo = (int)dgrBobbins.Rows[i].Cells["colBobbinNo"].Value,
                        BobbinLabel = dgrBobbins.Rows[i].Cells["colBobbinLabel"].Value.ToString(),
                        ThreadLabel = dgrBobbins.Rows[i].Cells["colThreadLabel"].Value.ToString(),
                        StitchCount = dgrBobbins.Rows[i].Cells["colStitchCount"].Value.ToString(),
                        Machine = dgrBobbins.Rows[i].Cells["colMachine"].Value.ToString()
                    };
                    result.Add(newBobbin);
                }
            }
            return result;
        }

        private void dgrBobbins_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                var currentSelectedRow = dgrBobbins.CurrentRow;
                if (currentSelectedRow != null && currentSelectedRow.Index == dgrBobbins.Rows.Count - 1)
                {
                    var dataSources = (List<BobbinDto>)dgrBobbins.DataSource;
                    var newDataRow = new BobbinDto()
                    {
                        BobbinNo = dgrBobbins.RowCount + 1,
                        BobbinLabel = string.Empty,
                        ThreadLabel = string.Empty,
                        StitchCount = "0",
                        Machine = string.Empty
                    };
                    dataSources.Add(newDataRow);
                    dgrBobbins.DataSource = dataSources;
                    dgrBobbins.Refresh();
                }
            }
        }


    }
}