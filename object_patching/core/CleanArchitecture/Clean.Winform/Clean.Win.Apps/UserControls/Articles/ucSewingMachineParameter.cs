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

            txtStitchForwardSeam1Front.KeyUp += onKeyUp;
            txtStitchBackwardSeam1Front.KeyUp += onKeyUp;
            txtRepetitionSeam1Front.KeyUp += onKeyUp;
            txtStitchForwardSeam1End.KeyUp += onKeyUp;
            txtStitchBackwardSeam1End.KeyUp += onKeyUp;
            txtRepetitionSeam1End.KeyUp += onKeyUp;
            txtStitchForwardSeam2Front.KeyUp += onKeyUp;
            txtStitchBackwardSeam2Front.KeyUp += onKeyUp;
            txtRepetitionSeam2Front.KeyUp += onKeyUp;
            txtStitchForwardSeam2End.KeyUp += onKeyUp;
            txtStitchBackwardSeam2End.KeyUp += onKeyUp;
            txtRepetitionSeam2End.KeyUp += onKeyUp;

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

            dto.BacktackStartSeam1Forward = txtStitchForwardSeam1Front.Text;
            dto.BacktackStartSeam1Backward = txtStitchBackwardSeam1Front.Text;
            dto.BacktackStartSeam1Repetition = txtRepetitionSeam1Front.Text;
            dto.BacktackEndSeam1Forward = txtStitchForwardSeam1End.Text;
            dto.BacktackEndSeam1Backward = txtStitchBackwardSeam1End.Text;
            dto.BacktackEndSeam1Repetition = txtRepetitionSeam1End.Text;

            dto.BacktackStartSeam2Forward = txtStitchForwardSeam2Front.Text;
            dto.BacktackStartSeam2Backward = txtStitchBackwardSeam2Front.Text;
            dto.BacktackStartSeam2Repetition = txtRepetitionSeam2Front.Text;
            dto.BacktackEndSeam2Forward = txtStitchForwardSeam2End.Text;
            dto.BacktackEndSeam2Backward = txtStitchBackwardSeam2End.Text;
            dto.BacktackEndSeam2Repetition = txtRepetitionSeam2End.Text;
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

            txtStitchForwardSeam1Front.Text = dto.BacktackStartSeam1Forward;
            txtStitchBackwardSeam1Front.Text = dto.BacktackStartSeam1Backward;
            txtRepetitionSeam1Front.Text = dto.BacktackStartSeam1Repetition;
            txtStitchForwardSeam1End.Text = dto.BacktackEndSeam1Forward;
            txtStitchBackwardSeam1End.Text = dto.BacktackEndSeam1Backward;
            txtRepetitionSeam1End.Text = dto.BacktackEndSeam1Repetition;

            txtStitchForwardSeam2Front.Text = dto.BacktackStartSeam2Forward;
            txtStitchBackwardSeam2Front.Text = dto.BacktackStartSeam2Backward;
            txtRepetitionSeam2Front.Text = dto.BacktackStartSeam2Repetition;
            txtStitchForwardSeam2End.Text = dto.BacktackEndSeam2Forward;
            txtStitchBackwardSeam2End.Text = dto.BacktackEndSeam2Backward;
            txtRepetitionSeam2End.Text = dto.BacktackEndSeam2Repetition;


            AutomatDto automatDto = dto.Automat;
            txtCriticalSection.Enabled = automatDto.AutoTolCrit;
            txtNonCriticalSection.Enabled = automatDto.AutoTolNotCrit;


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
