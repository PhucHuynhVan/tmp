using Clean.WinF.Applications.Features.Article.DTOs;
using System.Windows.Forms;

namespace Clean.Win.AppUI.UserControls
{
    public partial class ucSewingMachineParameter : UserControl
    {
        public delegate void DataChange();
        public event DataChange OnDataChange;
        private string threadTensionMonitoringType;
        private string threadTensionId;
        public ArticleDto dto { get; set; }
        public ucSewingMachineParameter()
        {
            InitializeComponent();
            txtCriticalSection.KeyUp += onKeyUp;
            txtNonCriticalSection.KeyUp += onKeyUp;

            txtMaxTolerance.KeyUp += onKeyUp;
            txtReferenceTension.KeyUp += onKeyUp;
            txtMinTolerance.KeyUp += onKeyUp;
            txtStopFilter.KeyUp += onKeyUp;
            txtStartMonitoring.KeyUp += onKeyUp;

            txtStitchForwardFreeSeamFront.KeyUp += onKeyUp;
            txtStitchBackwardFreeSeamFront.KeyUp += onKeyUp;
            txtStitchForwardFreeSeamEnd.KeyUp += onKeyUp;
            txtStitchBackwardFreeSeamEnd.KeyUp += onKeyUp;

            txtStitchForwardSABSeamFront.KeyUp += onKeyUp;
            txtStitchBackwardSABSeamFront.KeyUp += onKeyUp;
            txtStitchForwardSABSeamEnd.KeyUp += onKeyUp;
            txtStitchBackwardSABSeamEnd.KeyUp += onKeyUp;

            txtStitchForwardEndlabelSeamFront.KeyUp += onKeyUp;
            txtStitchBackwardEndlabelSeamFront.KeyUp += onKeyUp;
            txtStitchForwardEndlabelSeamEnd.KeyUp += onKeyUp;
            txtStitchBackwardEndlabelSeamEnd.KeyUp += onKeyUp;

        }

        private void cb_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is CheckBox)
            {
                CheckBox checkbox = (CheckBox)sender;
                if (!dto.IsCreated)
                {
                    dto.IsUpdated = true;
                }
                switch (checkbox.Tag)
                {
                    case "MonitoringFreeSeam":
                        dto.MonitoringFreeSeam = checkbox.Checked ? "1" : "0";
                        break;
                    case "MonitoringSeaction1":
                        dto.MonitoringSeaction1 = checkbox.Checked ? "1" : "0";
                        break;
                    case "MonitoringSeaction3":
                        dto.MonitoringSeaction3 = checkbox.Checked ? "1" : "0";
                        break;
                    case "MonitoringEndlabelSeam":
                        dto.MonitoringEndlabelSeam = checkbox.Checked ? "1" : "0";
                        break;

                }


                OnDataChange.Invoke();
            }
        }




        public void updateDataForDto()
        {
            if (!dto.IsCreated)
            {
                dto.IsUpdated = true;
            }

            dto.MaxSpeedCritSection = txtCriticalSection.Text;
            dto.MaxSpeedNotCritSection = txtNonCriticalSection.Text;

            dto.ThreadTensionMonitoringType = threadTensionMonitoringType;
            dto.ThreadTensionId = threadTensionId;

            dto.ThreadTensionSeam1Max = txtMaxTolerance.Text;
            dto.ThreadTensionSeam1Reference = txtReferenceTension.Text;
            dto.ThreadTensionSeam1Min = txtMinTolerance.Text;
            dto.ThreadTensionSeam1StopFilter = txtStopFilter.Text;
            dto.ThreadTensionSeam1StartMonitoring = txtStartMonitoring.Text;

            dto.BacktackStartFreeSeamForward = txtStitchForwardFreeSeamFront.Text;
            dto.BacktackStartFreeSeamBackward = txtStitchBackwardFreeSeamFront.Text;
            dto.BacktackEndFreeSeamForward = txtStitchForwardFreeSeamEnd.Text;
            dto.BacktackEndFreeSeamBackward = txtStitchBackwardFreeSeamEnd.Text;

            dto.BacktackStartSABSeamForward = txtStitchForwardSABSeamFront.Text;
            dto.BacktackStartSABSeamBackward = txtStitchBackwardSABSeamFront.Text;
            dto.BacktackEndSABSeamForward = txtStitchForwardSABSeamEnd.Text;
            dto.BacktackEndSABSeamBackward = txtStitchBackwardSABSeamEnd.Text;

            dto.BacktackStartEndlabelSeamForward = txtStitchForwardEndlabelSeamFront.Text;
            dto.BacktackEndEndlabelSeamForward = txtStitchBackwardEndlabelSeamFront.Text;
            dto.BacktackStartEndlabelSeamBackward = txtStitchForwardEndlabelSeamEnd.Text;
            dto.BacktackEndEndlabelSeamBackward = txtStitchBackwardEndlabelSeamEnd.Text;
            OnDataChange.Invoke();
        }

        public void updateFormData()
        {


            txtCriticalSection.Text = dto.MaxSpeedCritSection;
            txtNonCriticalSection.Text = dto.MaxSpeedNotCritSection;

            threadTensionMonitoringType = dto.ThreadTensionMonitoringType;
            threadTensionId = dto.ThreadTensionId;

            txtMaxTolerance.Text = dto.ThreadTensionSeam1Max;
            txtReferenceTension.Text = dto.ThreadTensionSeam1Reference;
            txtMinTolerance.Text = dto.ThreadTensionSeam1Min;
            txtStopFilter.Text = dto.ThreadTensionSeam1StopFilter;
            txtStartMonitoring.Text = dto.ThreadTensionSeam1StartMonitoring;

            txtStitchForwardFreeSeamFront.Text = dto.BacktackStartFreeSeamForward;
            txtStitchBackwardFreeSeamFront.Text = dto.BacktackStartFreeSeamBackward;
            txtStitchForwardFreeSeamEnd.Text = dto.BacktackEndFreeSeamForward;
            txtStitchBackwardFreeSeamEnd.Text = dto.BacktackEndFreeSeamBackward;

            txtStitchForwardSABSeamFront.Text = dto.BacktackStartSABSeamForward;
            txtStitchBackwardSABSeamFront.Text = dto.BacktackStartSABSeamBackward;
            txtStitchForwardSABSeamEnd.Text = dto.BacktackEndSABSeamForward;
            txtStitchBackwardSABSeamEnd.Text = dto.BacktackEndSABSeamBackward;

            txtStitchForwardEndlabelSeamFront.Text = dto.BacktackStartEndlabelSeamForward;
            txtStitchBackwardEndlabelSeamFront.Text = dto.BacktackEndEndlabelSeamForward;
            txtStitchForwardEndlabelSeamEnd.Text = dto.BacktackStartEndlabelSeamBackward;
            txtStitchBackwardEndlabelSeamEnd.Text = dto.BacktackEndEndlabelSeamBackward;

            if (dto.Automat != null)
            {
                AutomatDto automatDto = dto.Automat;
                txtCriticalSection.Enabled = automatDto.AutoTolCrit;
                txtNonCriticalSection.Enabled = automatDto.AutoTolNotCrit;
            }


            checkBox1.Checked = dto.MonitoringFreeSeam != null && dto.MonitoringFreeSeam.Equals("1");
            checkBox2.Checked = dto.MonitoringSeaction1 != null && dto.MonitoringSeaction1.Equals("1");
            checkBox3.Checked = dto.MonitoringSeaction3 != null && dto.MonitoringSeaction3.Equals("1");
            checkBox4.Checked = dto.MonitoringEndlabelSeam != null && dto.MonitoringEndlabelSeam.Equals("1");

        }


        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (sender is TextBox)
            {
                updateDataForDto();
            }
        }

    }
}
