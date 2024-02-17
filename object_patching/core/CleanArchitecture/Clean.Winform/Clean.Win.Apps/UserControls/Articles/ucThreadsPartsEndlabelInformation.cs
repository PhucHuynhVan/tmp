using Clean.Win.AppUI.Forms;
using Clean.Win.AppUI.UICommon.Entities;
using Clean.WinF.Applications.Features.Article.DTOs;
using Clean.WinF.Applications.Features.Part.DTOs;
using Clean.WinF.Applications.Features.Part.Interfaces;
using Clean.WinF.Applications.Features.Thread.DTOs;
using Clean.WinF.Applications.Features.Thread.Interfaces;
using Clean.WinF.Common.Enum;
using Clean.WinF.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Clean.Win.AppUI.UserControls.Articles
{
    public partial class ucThreadsPartsEndlabelInformation : UserControl
    {
        public delegate void DataChange();
        public event DataChange OnDataChange;
        private IPartCommandServices _commandPartService;
        private IPartQueryServices _queryPartService;
        private IThreadCommandServices _commandThreadService;
        private IThreadQueryServices _queryThreadService;
        public ArticleDto dto;
        private IEnumerable<PartDto> _partDatas;
        private IEnumerable<ThreadDto> _threadDatas;
        public ucThreadsPartsEndlabelInformation()
        {
            InitializeComponent();
            cbxPart1.SelectedIndex = 0;
            cbxPart2.SelectedIndex = 1;
            cbxPart3.SelectedIndex = 2;
            cbxPart4.SelectedIndex = 3;
            cbxPart5.SelectedIndex = 4;
            txtInfo1.KeyUp += onKeyUp;
            txtInfo2.KeyUp += onKeyUp;
            txtInfo3.KeyUp += onKeyUp;
            txtInfo4.KeyUp += onKeyUp;
            txtInfo5.KeyUp += onKeyUp;
            txtInfo6.KeyUp += onKeyUp;
            txtInfo7.KeyUp += onKeyUp;
            txtNeedleInfo1.KeyUp += onKeyUp;
            txtNeedleInfo2.KeyUp += onKeyUp;
            txtBobbinInfo1.KeyUp += onKeyUp;
            txtBobbinInfo2.KeyUp += onKeyUp;
        }




        public void setServiceFromDB(
            IPartCommandServices commandPartService,
            IPartQueryServices queryPartService,
            IThreadCommandServices commandThreadService,
            IThreadQueryServices queryThreadService)
        {
            _commandPartService = commandPartService;
            _queryPartService = queryPartService;
            _commandThreadService = commandThreadService;
            _queryThreadService = queryThreadService;

        }

        public async void loadThreadFromDB()
        {
            if (_queryPartService != null)
            {
                _partDatas = await _queryPartService.ListAllAsync();
            }
            if (_queryThreadService != null)
            {
                _threadDatas = await _queryThreadService.ListAllAsync();
            }
        }

        public void updateFormData(bool isChange = false)
        {
            if (dto.FabricLeather1ID != 0 && _partDatas.Count() > 0)
            {
                PartDto part1Dto = _partDatas.SingleOrDefault(part => part.ID == dto.FabricLeather1ID);
                dto.FabricLeather1Batch = "1";
                dto.FabricLeather1MaterialCode = part1Dto.Code;
                dto.FabricLeather1MaterialName = part1Dto.Name;
                txtPartCode1.Text = part1Dto.Code;
                txtPartName1.Text = part1Dto.Name;

            }
            else
            {
                txtPartCode1.Text = "";
                txtPartName1.Text = "";
            }
            if (dto.FabricLeather2ID != 0 && _partDatas.Count() > 0)
            {
                PartDto part2Dto = _partDatas.SingleOrDefault(part => part.ID == dto.FabricLeather2ID);
                dto.FabricLeather2Batch = "2";
                dto.FabricLeather2MaterialCode = part2Dto.Code;
                dto.FabricLeather2MaterialName = part2Dto.Name;
                txtPartCode2.Text = part2Dto.Code;
                txtPartName2.Text = part2Dto.Name;
            }
            else
            {
                txtPartCode2.Text = "";
                txtPartName2.Text = "";
            }
            if (dto.FabricLeather3ID != 0 && _partDatas.Count() > 0)
            {
                PartDto part3Dto = _partDatas.SingleOrDefault(part => part.ID == dto.FabricLeather3ID);
                dto.FabricLeather3Batch = "3";
                dto.FabricLeather3MaterialCode = part3Dto.Code;
                dto.FabricLeather3MaterialName = part3Dto.Name;
                txtPartCode3.Text = part3Dto.Code;
                txtPartName3.Text = part3Dto.Name;
            }
            else
            {
                txtPartCode3.Text = "";
                txtPartName3.Text = "";
            }
            if (dto.FabricLeather4ID != 0 && _partDatas.Count() > 0)
            {
                PartDto part4Dto = _partDatas.SingleOrDefault(part => part.ID == dto.FabricLeather4ID);
                dto.FabricLeather4Batch = "4";
                dto.FabricLeather4MaterialCode = part4Dto.Code;
                dto.FabricLeather4MaterialName = part4Dto.Name;
                txtPartCode4.Text = part4Dto.Code;
                txtPartName4.Text = part4Dto.Name;
            }
            else
            {
                txtPartCode4.Text = "";
                txtPartName4.Text = "";
            }
            if (dto.FabricLeather5ID != 0 && _partDatas.Count() > 0)
            {
                PartDto part5Dto = _partDatas.SingleOrDefault(part => part.ID == dto.FabricLeather5ID);
                dto.FabricLeather5Batch = "5";
                dto.FabricLeather5MaterialCode = part5Dto.Code;
                dto.FabricLeather5MaterialName = part5Dto.Name;
                txtPartCode5.Text = part5Dto.Code;
                txtPartName5.Text = part5Dto.Name;
            }
            else
            {
                txtPartCode5.Text = "";
                txtPartName5.Text = "";
            }
            if (dto.UpperThreadID != 0 && _threadDatas.Count() > 0)
            {
                ThreadDto upperDto = _threadDatas.SingleOrDefault(thread => thread.ID == dto.UpperThreadID);
                dto.UpperThreadMaterialCode = upperDto.Code;
                dto.UpperThreadMaterialName = upperDto.Name;
                txtNeedleCode.Text = upperDto.Code;
                txtNeedleName.Text = upperDto.Name;
            }
            else
            {
                txtNeedleCode.Text = "";
                txtNeedleName.Text = "";
            }
            if (dto.LowerThreadID != 0 && _threadDatas.Count() > 0)
            {
                ThreadDto lowerDto = _threadDatas.SingleOrDefault(thread => thread.ID == dto.LowerThreadID);
                dto.LowerThreadMaterialCode = lowerDto.Code;
                dto.LowerThreadMaterialName = lowerDto.Name;
                txtBobbinCode.Text = lowerDto.Code;
                txtBobbinName.Text = lowerDto.Name;
            }
            else
            {
                txtBobbinCode.Text = "";
                txtBobbinName.Text = "";
            }

            txtInfo1.Text = dto.MiscellaneousInfo1;
            txtInfo2.Text = dto.MiscellaneousInfo2;
            txtInfo3.Text = dto.MiscellaneousInfo3;
            txtInfo4.Text = dto.MiscellaneousInfo4;
            txtInfo5.Text = dto.MiscellaneousInfo5;
            txtInfo6.Text = dto.MiscellaneousInfo6;
            txtInfo7.Text = dto.MiscellaneousInfo7;


            if (isChange)
            {
                if (!dto.IsCreated)
                {
                    dto.IsUpdated = true;
                }
                OnDataChange.Invoke();
            }


            AutomatDto automatDto = dto.Automat;

            cbxPart1.Enabled = automatDto.Part1;
            txtPartCode1.Enabled = automatDto.Part1;
            txtPartName1.Enabled = automatDto.Part1;
            btnSelectPart1.Enabled = automatDto.Part1;

            cbxPart2.Enabled = automatDto.Part2;
            txtPartCode2.Enabled = automatDto.Part2;
            txtPartName2.Enabled = automatDto.Part2;
            btnSelectPart2.Enabled = automatDto.Part2;

            cbxPart3.Enabled = automatDto.Part3;
            txtPartCode3.Enabled = automatDto.Part3;
            txtPartName3.Enabled = automatDto.Part3;
            btnSelectPart3.Enabled = automatDto.Part3;

            cbxPart4.Enabled = automatDto.Part4;
            txtPartCode4.Enabled = automatDto.Part4;
            txtPartName4.Enabled = automatDto.Part4;
            btnSelectPart4.Enabled = automatDto.Part4;

            cbxPart5.Enabled = automatDto.Part5;
            txtPartCode5.Enabled = automatDto.Part5;
            txtPartName5.Enabled = automatDto.Part5;
            btnSelectPart5.Enabled = automatDto.Part5;



            txtNeedleCode.Enabled = automatDto.UpperThread;
            txtNeedleName.Enabled = automatDto.UpperThread;
            txtNeedleInfo1.Enabled = automatDto.UpperThread;
            txtNeedleInfo2.Enabled = automatDto.UpperThread;
            btnUpper.Enabled = automatDto.UpperThread;

            txtBobbinCode.Enabled = automatDto.UpperThread;
            txtBobbinName.Enabled = automatDto.UpperThread;
            txtBobbinInfo1.Enabled = automatDto.UpperThread;
            txtBobbinInfo2.Enabled = automatDto.UpperThread;
            btnLower.Enabled = automatDto.UpperThread;

            txtInfo1.Enabled = automatDto.Info1;
            txtInfo2.Enabled = automatDto.Info2;
            txtInfo3.Enabled = automatDto.Info3;
            txtInfo4.Enabled = automatDto.Info4;
            txtInfo5.Enabled = automatDto.Info5;
            txtInfo6.Enabled = automatDto.Info6;
            txtInfo7.Enabled = automatDto.Info7;





        }

        private void ucThreadsPartsEndlabelInformation_VisibleChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (Visible)
                {
                    loadThreadFromDB();
                    updateFormData(false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }


        public void OpenDialog(String propertyName, object datas)
        {
            List<InputDataStep> steps = new List<InputDataStep>();
            steps.Add(new InputDataStep
            {
                PropertyName = propertyName,
                ControllType = EInputDataType.DATAGRIDVIEW,
                ExtraData = datas

            });
            ArticleDto articleDto = dto;
            InputDataForm inputDataForm = new InputDataForm(steps, articleDto, EInputDataForm.ARTICLE);
            inputDataForm.OnFormClose += OnClosingDataInputForm;
            inputDataForm.ShowDialog();
        }

        private void OnClosingDataInputForm(object inputObject, string status)
        {
            switch (status)
            {
                case CommonConstant.InputDataFinished:
                    dto = (ArticleDto)inputObject;
                    updateFormData(true);
                    Console.WriteLine();
                    break;
                default:
                    //close form

                    break;
            }
        }
        private void btnSelectPart1_Click(object sender, EventArgs e)
        {
            OpenDialog("FabricLeather1ID", _partDatas);
        }

        private void btnSelectPart2_Click(object sender, EventArgs e)
        {
            OpenDialog("FabricLeather2ID", _partDatas);
        }

        private void btnSelectPart3_Click(object sender, EventArgs e)
        {
            OpenDialog("FabricLeather3ID", _partDatas);
        }

        private void btnSelectPart4_Click(object sender, EventArgs e)
        {
            OpenDialog("FabricLeather4ID", _partDatas);
        }

        private void btnSelectPart5_Click(object sender, EventArgs e)
        {
            OpenDialog("FabricLeather5ID", _partDatas);
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (sender is TextBox)
            {
                updateDataForDto();
            }
        }

        private void updateDataForDto()
        {
            if (!dto.IsCreated)
            {
                dto.IsUpdated = true;
            }
            dto.MiscellaneousInfo1 = txtInfo1.Text;
            dto.MiscellaneousInfo2 = txtInfo2.Text;
            dto.MiscellaneousInfo3 = txtInfo3.Text;
            dto.MiscellaneousInfo4 = txtInfo4.Text;
            dto.MiscellaneousInfo5 = txtInfo5.Text;
            dto.MiscellaneousInfo6 = txtInfo6.Text;
            dto.MiscellaneousInfo7 = txtInfo7.Text;
            dto.UpperThreadInfo1 = txtNeedleInfo1.Text;
            dto.UpperThreadInfo2 = txtNeedleInfo2.Text;
            dto.LowerThreadInfo1 = txtBobbinInfo1.Text;
            dto.LowerThreadInfo2 = txtBobbinInfo2.Text;

            OnDataChange.Invoke();
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {

            OpenDialog("UpperThreadID", _threadDatas);
        }

        private void btnLower_Click(object sender, EventArgs e)
        {

            OpenDialog("LowerThreadID", _threadDatas);
        }
    }
}
