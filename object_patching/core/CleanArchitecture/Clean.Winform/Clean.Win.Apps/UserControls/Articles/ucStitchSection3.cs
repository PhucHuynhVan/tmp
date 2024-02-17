using Clean.WinF.Applications.Features.Article.DTOs;
using System.Windows.Forms;

namespace Clean.Win.AppUI.UserControls.Articles
{
    public partial class ucStitchSection3 : UserControl
    {
        public delegate void DataChange();
        public event DataChange OnDataChange;
        public ArticleDto dto { get; set; }
        public ucStitchSection3()
        {
            InitializeComponent();

            txtReference1.KeyUp += onKeyUp;
            txtMinTolerance1.KeyUp += onKeyUp;
            txtMaxTolerance1.KeyUp += onKeyUp;
            txtStitchLength1.KeyUp += onKeyUp;
            txtStepForward1.KeyUp += onKeyUp;
            txtStepBackward1.KeyUp += onKeyUp;

            txtReference2.KeyUp += onKeyUp;
            txtMinTolerance2.KeyUp += onKeyUp;
            txtMaxTolerance2.KeyUp += onKeyUp;
            txtStitchLength2.KeyUp += onKeyUp;
            txtStepForward2.KeyUp += onKeyUp;
            txtStepBackward2.KeyUp += onKeyUp;

            txtReference3.KeyUp += onKeyUp;
            txtMinTolerance3.KeyUp += onKeyUp;
            txtMaxTolerance3.KeyUp += onKeyUp;
            txtStitchLength3.KeyUp += onKeyUp;
            txtStepForward3.KeyUp += onKeyUp;
            txtStepBackward3.KeyUp += onKeyUp;


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


            if (!txtReference2.Equals("")
                || !txtMinTolerance2.Equals("")
                  || !txtMaxTolerance2.Equals("")
                  || !txtStitchLength2.Equals("")
                  || !txtStepForward2.Equals("")
                  || !txtStepBackward2.Equals("")
                  )
            {
                txtReference2.Text = dto.Section2Reference != null && !dto.Section2Reference.Equals("") ? dto.Section2Reference : "0";
                txtMinTolerance2.Text = dto.Section2Min != null && !dto.Section2Min.Equals("") ? dto.Section2Min : "0";
                txtMaxTolerance2.Text = dto.Section2Max != null && !dto.Section2Max.Equals("") ? dto.Section2Max : "0";
                txtStitchLength2.Text = dto.Section2StitchLength != null && !dto.Section2StitchLength.Equals("") ? dto.Section2StitchLength : "0";
                txtStepForward2.Text = dto.Section2StepForw != null && !dto.Section2StepForw.Equals("") ? dto.Section2StepForw : "0";
                txtStepBackward2.Text = dto.Section2StepBackw != null && !dto.Section2StepBackw.Equals("") ? dto.Section2StepBackw : "0";
            }


            if (!txtReference3.Equals("")
                || !txtMinTolerance3.Equals("")
                  || !txtMaxTolerance3.Equals("")
                  || !txtStitchLength3.Equals("")
                  || !txtStepForward3.Equals("")
                  || !txtStepBackward3.Equals("")
                  )
            {
                txtReference3.Text = dto.Section3Reference != null && !dto.Section3Reference.Equals("") ? dto.Section3Reference : "0";
                txtMinTolerance3.Text = dto.Section3Min != null && !dto.Section3Min.Equals("") ? dto.Section3Min : "0";
                txtMaxTolerance3.Text = dto.Section3Max != null && !dto.Section3Max.Equals("") ? dto.Section3Max : "0";
                txtStitchLength3.Text = dto.Section3StitchLength != null && !dto.Section3StitchLength.Equals("") ? dto.Section3StitchLength : "0";
                txtStepForward3.Text = dto.Section3StepForw != null && !dto.Section3StepForw.Equals("") ? dto.Section3StepForw : "0";
                txtStepBackward3.Text = dto.Section3StepBackw != null && !dto.Section3StepBackw.Equals("") ? dto.Section3StepBackw : "0";
            }
            cbTolErrorAllowed1.Checked = dto.Section1TolErrAllowed;
            cbTolErrorAllowed3.Checked = dto.Section3TolErrAllowed;


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

            dto.Section2Reference = txtReference2.Text;
            dto.Section2Min = txtMinTolerance2.Text;
            dto.Section2Max = txtMaxTolerance2.Text;
            dto.Section2StitchLength = txtStitchLength2.Text;
            dto.Section2StepForw = txtStepForward2.Text;
            dto.Section2StepBackw = txtStepBackward2.Text;

            dto.Section3Reference = txtReference3.Text;
            dto.Section3Min = txtMinTolerance3.Text;
            dto.Section3Max = txtMaxTolerance3.Text;
            dto.Section3StitchLength = txtStitchLength3.Text;
            dto.Section3StepForw = txtStepForward3.Text;
            dto.Section3StepBackw = txtStepBackward3.Text;

        }

        private void cbTolErrorAllowed1_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is System.Windows.Forms.CheckBox)
            {
                System.Windows.Forms.CheckBox checkbox = (System.Windows.Forms.CheckBox)sender;
                if (!dto.IsCreated)
                {
                    dto.IsUpdated = true;
                }
                switch (checkbox.Tag)
                {
                    case "cbTolErrorAllowed1":
                        dto.Section1TolErrAllowed = checkbox.Checked;
                        break;
                    case "cbTolErrorAllowed3":
                        dto.Section3TolErrAllowed = checkbox.Checked;
                        break;
                    case "cbTolErrorAllowed5":
                        dto.Section5TolErrAllowed = checkbox.Checked;
                        break;

                }


                OnDataChange.Invoke();
            }
        }
    }
}
