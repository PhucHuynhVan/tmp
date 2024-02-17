﻿using Clean.WinF.Applications.Features.Users.DTOs;
using Clean.WinF.Applications.Features.Users.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clean.Win.AppUI.UserControls
{
    public partial class ucUserConfig : UserControl
    {
        //private readonly IComputerCommandServices _computerCommandServices;
        //private readonly ISystemConfigurationCommandServices _systemConfigurationCommandServices;
        //private readonly ILanguageQueryServices _languageQueryServices;

        //ComputerDto _computerData = new ComputerDto();
        //List<LanguageDto> _languageData = new List<LanguageDto>();

        ////public ucComputerConfig(ISystemConfigurationCommandServices systemConfigurationCommandServices, ILanguageQueryServices languageQueryService, ComputerDto dto)
        //public ucUserConfig(IComputerCommandServices computerCommandServices, ISystemConfigurationCommandServices systemConfigurationCommandServices, ILanguageQueryServices languageQueryService)
        //{
        //    _computerCommandServices = computerCommandServices;
        //    _systemConfigurationCommandServices = systemConfigurationCommandServices;
        //    _languageQueryServices = languageQueryService;
        //    InitializeComponent();
        //    MessageBox.Show($"ucUserConfig");
        //}

        private readonly IUserCommandServices _commandService;

        List<UserDto> _data = new List<UserDto>();

        public ucUserConfig(IUserCommandServices commandService)
        {
            _commandService = commandService;
            InitializeComponent();
            //MessageBox.Show($"ucWindingParamConfig");
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            // config grid view columns
            this.configGridView();

            // load gridview data
            this.refreshData();
        }

        private void configGridView()
        {
            this.mainGridView.ReadOnly = false;
            this.mainGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.mainGridView.ScrollBars = ScrollBars.Both;
            this.mainGridView.AutoGenerateColumns = false;
            this.mainGridView.MultiSelect = true;

            //this.mainGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // config gridview display columns
            this.configGridViewCheckBoxColumn(this.mainGridView, "Active", "IsActive", false);
            this.configGridViewColumn(this.mainGridView, "user id", "UserID", false);
            this.configGridViewColumn(this.mainGridView, "name", "Name", false);
            this.configGridViewColumn(this.mainGridView, "first name", "FirstName", false);
            this.configGridViewColumn(this.mainGridView, "ZK Teco Fingerprint allowed", "", true);
            this.configGridViewColumn(this.mainGridView, "Change Password", "", true);
            //this.configGridViewColumn(this.mainGridView, "first name", "WindingDurationOnMachine", false);
            //this.configGridViewColumn(this.mainGridView, "Remark", "Remark", false);

            // register gridview event handler
            //this.mainGridView.SelectionChanged += onGridViewSelectionChanged;
            //this.mainGridView.CellEndEdit += onGridViewCellEndEdit;

            //this.mainGridView.CellClick += onCellClick;
            //mainGridView.CellValueChanged += DataGridView1_CellValueChanged;
        }

        //private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex == mainGridView.RowCount - 1 && e.RowIndex >= 0)
        //    {
        //        this.addEmptyRowForInsert();

        //        this._data[e.RowIndex].ID = 0;

        //        //MessageBox.Show($"addEmptyRowForInsert");
        //        this.reloadGridView();
        //    }
        //}

        private void configGridViewColumn(DataGridView dataGridView,
            String header, String property, Boolean readOnly = true, int width = 150)
        {
            var column = new DataGridViewTextBoxColumn()
            {
                HeaderText = header,
                DataPropertyName = property,
                Width = width,
                ReadOnly = readOnly,
            };

            dataGridView.Columns.Add(column);
        }

        private void configGridViewCheckBoxColumn(DataGridView dataGridView,
            String header, String property, Boolean readOnly = true, int width = 150)
        {
            var column = new DataGridViewCheckBoxColumn
            {
                HeaderText = header,
                DataPropertyName = property,
                ReadOnly = readOnly,
                Width = width,
            };
            dataGridView.Columns.Add(column);
        }

        private void configGridViewIconColumn(DataGridView dataGridView,
            String header, String property, Boolean readOnly = true, int width = 50)
        {
            var column = new DataGridViewImageColumn
            {
                HeaderText = header,
                DataPropertyName = property,
                ImageLayout = DataGridViewImageCellLayout.Normal,
                Width = width,
            };
            dataGridView.Columns.Add(column);
        }

        private async void refreshData()
        {
            var result = await this._commandService.ListAllAsync();
            var dbData = (List<UserDto>)result;

            this._data = dbData;

            this.reloadGridView();
        }

        private void reloadGridView()
        {
            //MessageBox.Show($"reloadGridView");
            this.updateDataSource();

            // config datasource
            this.mainGridView.DataSource = null;
            this.mainGridView.DataSource = this._data;
            this.mainGridView.Refresh();
        }

        private void updateDataSource()
        {
            ////var defaultIcon = new Bitmap(1, 1);
            //foreach (ThreadWindingParamDto dto in this._data)
            //{
            //    string IDStr = "";
            //    if (dto.ID > 0)
            //    {
            //        IDStr = dto.ID.ToString();
            //    }
            //    dto.IDStr = IDStr;
            //}
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.refreshData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.handleSave();
        }

        private async void handleSave()
        {

            //var insertList = new List<ThreadWindingParamDto>();
            var updateList = new List<UserDto>();
            foreach (UserDto item in this._data)
            {
                //if (item.ID == 0)
                //{
                //    insertList.Add(item);
                //}

                //if (item.ID > 0)
                //{
                //    updateList.Add(item);
                //}
                updateList.Add(item);
            }

            //MessageBox.Show($"handleSave: insertList:: count:: {insertList.Count} - updateList:: count:: {updateList.Count}");

            //MessageBox.Show($"handleSave: updateList:: count:: {updateList.Count}");

            //if (insertList.Count > 0)
            //{
            //    // insert
            //    await _commandService.CreateBulk(insertList);
            //}
            if (updateList.Count > 0)
            {
                // update
                await _commandService.UpdateBulk(updateList);
            }
            this.refreshData();

        }
    }
}
