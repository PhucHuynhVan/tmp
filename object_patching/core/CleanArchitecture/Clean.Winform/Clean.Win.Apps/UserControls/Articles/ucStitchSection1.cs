using Clean.WinF.Applications.Features.Article.DTOs;
using System.Windows.Forms;

namespace Clean.Win.AppUI.UserControls.Articles
{
    public partial class ucStitchSection1 : UserControl
    {
        public delegate void DataChange();
        public event DataChange OnDataChange;
        public ArticleDto dto { get; set; }
        public ucStitchSection1()
        {
            InitializeComponent();
            txtReference1.KeyUp += onKeyUp;
            txtMinTolerance1.KeyUp += onKeyUp;
            txtMaxTolerance1.KeyUp += onKeyUp;
            txtStitchLength1.KeyUp += onKeyUp;
            txtStepForward1.KeyUp += onKeyUp;
            txtStepBackward1.KeyUp += onKeyUp;
            txtStitches.KeyUp += onKeyUp;

        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (sender is TextBox)
            {
                updateDataForDto();

                OnDataChange.Invoke();
            }
        }

        public void updateFormData()
        {
            if (!txtReference1.Equals("")
                   || !txtMinTolerance1.Equals("")
                  || !txtMaxTolerance1.Equals("")
                  || !txtStitchLength1.Equals("")
                  || !txtStepForward1.Equals("")
                  || !txtStepBackward1.Equals("")
                  )
            {
                txtReference1.Text = dto.Section1Reference != null && !dto.Section1Reference.Equals("") ? dto.Section1Reference : "0";
                txtMinTolerance1.Text = dto.Section1Min != null && !dto.Section1Min.Equals("") ? dto.Section1Min : "0";
                txtMaxTolerance1.Text = dto.Section1Max != null && !dto.Section1Max.Equals("") ? dto.Section1Max : "0";
                txtStitchLength1.Text = dto.Section1StitchLength != null && !dto.Section1StitchLength.Equals("") ? dto.Section1StitchLength : "0";
                txtStepForward1.Text = dto.Section1StepForw != null && !dto.Section1StepForw.Equals("") ? dto.Section1StepForw : "0";
                txtStepBackward1.Text = dto.Section1StepBackw != null && !dto.Section1StepBackw.Equals("") ? dto.Section1StepBackw : "0";
            }

            dto.Section1StitchLength = txtStitchLength1.Text;
            dto.Section1StepForw = txtStepForward1.Text;
            dto.Section1StepBackw = txtStepBackward1.Text;

        }

        public void updateDataForDto()
        {
            if (!dto.IsCreated)
            {
                dto.IsUpdated = true;
            }
            dto.Section1Reference = txtReference1.Text;
            dto.Section1Min = txtMinTolerance1.Text;
            dto.Section1Max = txtMaxTolerance1.Text;
            dto.Section1StitchLength = txtStitchLength1.Text;
            dto.Section1StepForw = txtStepForward1.Text;
            dto.Section1StepBackw = txtStepBackward1.Text;
        }
    }
}
