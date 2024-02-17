using Clean.WinF.Applications.Features.Thread.DTOs;
using Clean.WinF.Applications.Features.Users.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clean.Win.AppUI.UserControls
{
    public partial class ucWindingParamConfig : UserControl
    {
        private readonly IWindingParamCommandServices _commandService;

        List<ThreadWindingParamDto> _data = new List<ThreadWindingParamDto>();

        public ucWindingParamConfig(IWindingParamCommandServices commandService)
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
            this.configGridViewColumn(this.mainGridView, "ID", "IDStr", true);
            this.configGridViewColumn(this.mainGridView, "Name", "Name", false);
            this.configGridViewCheckBoxColumn(this.mainGridView, "Upper Thread", "NeedleThread", false);
            this.configGridViewCheckBoxColumn(this.mainGridView, "Lower Thread", "BobbinThread", false);
            this.configGridViewColumn(this.mainGridView, "Stitches on Full Bobbin (0...30000)", "StitchesOnFullBobbin", false);
            this.configGridViewColumn(this.mainGridView, "Winding Duration [ms] (1000...65535)", "WindingDurationOnMachine", false);
            this.configGridViewColumn(this.mainGridView, "Remark", "Remark", false);

            // register gridview event handler
            //this.mainGridView.SelectionChanged += onGridViewSelectionChanged;
            //this.mainGridView.CellEndEdit += onGridViewCellEndEdit;

            //this.mainGridView.CellClick += onCellClick;
            mainGridView.CellValueChanged += DataGridView1_CellValueChanged;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == mainGridView.RowCount - 1 && e.RowIndex >= 0)
            {
                this.addEmptyRowForInsert();

                this._data[e.RowIndex].ID = 0;

                //MessageBox.Show($"addEmptyRowForInsert");
                this.reloadGridView();
            }
        }

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
            var dbData = (List<ThreadWindingParamDto>)result;

            this._data = dbData;

            if (dbData.Count == 0)
            {
                this.InitDataAsync();
            }

            this.addEmptyRowForInsert();
            this.reloadGridView();
        }

        private async Task InitDataAsync()
        {
            var rs = await this._commandService.CreateBulk(this.mockWindingParamsData());
            if (rs)
            {
                this._data = await this._commandService.ListAllAsync();
                await Console.Out.WriteLineAsync();
            }
        }

        private void addEmptyRowForInsert()
        {
            this._data.Add(new ThreadWindingParamDto()
            {
                ID = -1,
                Name = "",
                NeedleThread = false,
                BobbinThread = false,
                StitchesOnFullBobbin = "",
                WindingDurationOnMachine = "",
                Remark = "",
                IsActive = true,
            });
        }

        private List<ThreadWindingParamDto> mockWindingParamsData()
        {
            var ret = new List<ThreadWindingParamDto>();
            ret.Add(new ThreadWindingParamDto()
            {
                Name = "20 TEX",
                NeedleThread = false,
                BobbinThread = true,
                StitchesOnFullBobbin = "25000",
                WindingDurationOnMachine = "30000",
                Remark = "Heavy (Weight...)",
                IsActive = true,
            });
            ret.Add(new ThreadWindingParamDto()
            {
                Name = "30 TEX",
                NeedleThread = false,
                BobbinThread = true,
                StitchesOnFullBobbin = "25000",
                WindingDurationOnMachine = "30000",
                Remark = "Upholstery (Weight...)",
                IsActive = true,
            });
            ret.Add(new ThreadWindingParamDto()
            {
                Name = "40 TEX",
                NeedleThread = true,
                BobbinThread = false,
                StitchesOnFullBobbin = "25000",
                WindingDurationOnMachine = "30000",
                Remark = "Regular (Weight...)",
                IsActive = true,
            });

            for (int i = ret.Count + 1; i < 20; i++)
            {
                ret.Add(this.mockWindingParfamDto(i));
            }
            return ret;
        }

        private ThreadWindingParamDto mockWindingParfamDto(int count)
        {
            var dto = new ThreadWindingParamDto()
            {
                ID = count,
                Name = "Name " + count,
                NeedleThread = true,
                BobbinThread = false,
                StitchesOnFullBobbin = count.ToString(),
                WindingDurationOnMachine = count.ToString(),
                Remark = "Remard " + count.ToString(),
                IsActive = true,
            };
            return dto;
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
            //var defaultIcon = new Bitmap(1, 1);
            foreach (ThreadWindingParamDto dto in this._data)
            {
                string IDStr = "";
                if (dto.ID > 0)
                {
                    IDStr = dto.ID.ToString();
                }
                dto.IDStr = IDStr;
            }
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

            var insertList = new List<ThreadWindingParamDto>();
            var updateList = new List<ThreadWindingParamDto>();
            foreach (ThreadWindingParamDto item in this._data)
            {
                if (item.ID == 0)
                {
                    insertList.Add(item);
                }

                if (item.ID > 0)
                {
                    updateList.Add(item);
                }
            }

            //MessageBox.Show($"handleSave: insertList:: count:: {insertList.Count} - updateList:: count:: {updateList.Count}");

            if (insertList.Count > 0)
            {
                // insert
                await _commandService.CreateBulk(insertList);
            }
            if (updateList.Count > 0)
            {
                // update
                await _commandService.UpdateBulk(updateList);
            }
            this.refreshData();

        }
    }
}
