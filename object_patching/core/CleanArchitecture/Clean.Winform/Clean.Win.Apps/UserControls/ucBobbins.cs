using Clean.WinF.Applications.Features.Bobbin.DTOs;
using Clean.WinF.Applications.Features.Bobbin.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clean.Win.AppUI.UserControls
{
    public partial class ucBobbins : UserControl
    {
        private readonly IBobbinQueryServices _queryService;
        private readonly IBobbinCommandServices _commandService;

        private readonly UICommon.UICommon uiCommon = UICommon.UICommon.Instance;

        List<BobbinDto> _data = new List<BobbinDto>();
        int _selectedRowIdx = -1;

        public ucBobbins(IBobbinCommandServices commandService, IBobbinQueryServices queryServices)
        {
            _commandService = commandService;
            _queryService = queryServices;
            InitializeComponent();
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            // config grid view columns
            this.configGridView();

            // config form
            this.configForm();

            // load gridview data
            this.refreshData();
        }

        private void configForm()
        {
            this.txtBobbinNo.Enabled = false;
            this.txtBobbinLabel.Enabled = false;
            this.txtThreadLabel.Enabled = false;
            this.txtStitchCount.Enabled = false;
            this.txtMachine.Enabled = false;
        }

        private void configGridView()
        {
            this.mainGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.mainGridView.ScrollBars = ScrollBars.Both;
            this.mainGridView.AutoGenerateColumns = false;
            this.mainGridView.MultiSelect = false;

            var dto = new BobbinDto();

            // config gridview display columns
            this.configGridViewColumn(this.mainGridView, "Bobbin No.", GetPropertyName(() => dto.BobbinNo));
            this.configGridViewColumn(this.mainGridView, "Bobbin label", GetPropertyName(() => dto.BobbinLabel));
            this.configGridViewColumn(this.mainGridView, "Thread label", GetPropertyName(() => dto.ThreadLabel));
            this.configGridViewColumn(this.mainGridView, "Stitch count", GetPropertyName(() => dto.StitchCount));
            this.configGridViewColumn(this.mainGridView, "Machine", GetPropertyName(() => dto.Machine));

            // register gridview event handler
            this.mainGridView.SelectionChanged += onGridViewSelectionChanged;
        }

        static string GetPropertyName<T>(System.Linq.Expressions.Expression<Func<T>> propertyExpression)
        {
            var memberExpression = (System.Linq.Expressions.MemberExpression)propertyExpression.Body;
            return memberExpression.Member.Name;
        }

        private void configGridViewColumn(DataGridView dataGridView,
            String header, String property)
        {
            var column = new DataGridViewTextBoxColumn();
            column.HeaderText = header;
            column.DataPropertyName = property;

            dataGridView.Columns.Add(column);
        }

        private async void refreshData()
        {
            var result = await _queryService.ListAllAsync();
            var dbData = (List<BobbinDto>)result;

            this._data = dbData;

            if (dbData.Count == 0)
            {
                this.InitDataAsync();
            }

            this.reloadGridView();
        }

        private async Task InitDataAsync()
        {
            var mockData = this.mockData();
            var rs = await _commandService.CreateBulk(mockData);
            if (rs)
            {
                this._data = await _queryService.ListAllAsync();
                await Console.Out.WriteLineAsync();
            }
        }

        private void reloadGridView()
        {
            this.updateGridViewData(this._data);
        }

        private void updateGridViewData(List<BobbinDto> data)
        {
            this.mainGridView.DataSource = null;
            this.mainGridView.DataSource = data;
            this.mainGridView.Refresh();
        }

        private void updateFormData(BobbinDto model)
        {
            if (model != null)
            {
                this.txtBobbinNo.Text = model.BobbinNo.ToString();
                this.txtBobbinLabel.Text = model.BobbinLabel;
                this.txtThreadLabel.Text = model.ThreadLabel;
                this.txtStitchCount.Text = model.StitchCount;
                this.txtMachine.Text = model.Machine;
            }
        }

        private BobbinDto getCurrentRowData()
        {
            BobbinDto ret = null;
            if (_selectedRowIdx != -1)
            {
                ret = this._data[_selectedRowIdx];
            }
            return ret;
        }

        private void onGridViewSelectionChanged(object sender, EventArgs e)
        {
            var targetGridView = sender as DataGridView;
            var selectedRow = targetGridView.CurrentRow;

            this.onRowChange(selectedRow);
        }

        private void onRowChange(DataGridViewRow selectedRow)
        {
            if (selectedRow != null && selectedRow.Selected)
            {
                this._selectedRowIdx = selectedRow.Index;
                //MessageBox.Show($"onRowChange: selectedRow = {this._selectedRowIdx}");
                this.updateFormData(this.getCurrentRowData());
            }
        }

        private void btnRejectChanges_Click(object sender, EventArgs e)
        {
            this.refreshData();
        }

        // debug code begin
        private List<BobbinDto> mockData()
        {
            var ret = new List<BobbinDto>();

            for (int i = 1; i <= 20; i++)
            {
                var dto = new BobbinDto();
                dto.ID = i;
                dto.BobbinNo = i;
                dto.BobbinLabel = "BobbinLabel " + i;
                dto.ThreadLabel = "ThreadLabel " + i;
                dto.StitchCount = "StitchCount " + i;
                dto.Machine = "Machine " + i;
                ret.Add(dto);
            }
            return ret;
        }
        // debug code end
    }
}