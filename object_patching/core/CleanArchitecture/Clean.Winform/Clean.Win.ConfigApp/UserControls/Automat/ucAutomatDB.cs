using Clean.WinF.Applications.Features.Article.DTOs;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Control = System.Windows.Forms.Control;

namespace Clean.Win.AppConfigUI.UserControls.Automat
{
    public partial class ucAutomatDB : UserControl
    {
        public AutomatDto automatDto;
        public ucAutomatDB()
        {
            InitializeComponent();
            cb1Crit1.CheckedChanged += CheckedChanged;
            cb1Crit2.CheckedChanged += CheckedChanged;

            cbSab21.CheckedChanged += CheckedChanged;
            cbSab22.CheckedChanged += CheckedChanged;
            cbSab23.CheckedChanged += CheckedChanged;
            cbSab24.CheckedChanged += CheckedChanged;
            cbSab25.CheckedChanged += CheckedChanged;

            cbSab41.CheckedChanged += CheckedChanged;
            cbSab42.CheckedChanged += CheckedChanged;
            cbSab43.CheckedChanged += CheckedChanged;
            cbSab44.CheckedChanged += CheckedChanged;
            cbSab45.CheckedChanged += CheckedChanged;
            cbSab46.CheckedChanged += CheckedChanged;


            cbSabCustom1.CheckedChanged += CheckedChanged;
            cbSabCustom2.CheckedChanged += CheckedChanged;
            cbSabCustom3.CheckedChanged += CheckedChanged;
            cbSabCustom4.CheckedChanged += CheckedChanged;

            cbPart1.CheckedChanged += CheckedChanged;
            cbPart2.CheckedChanged += CheckedChanged;
            cbPart3.CheckedChanged += CheckedChanged;
            cbPart4.CheckedChanged += CheckedChanged;
            cbPart5.CheckedChanged += CheckedChanged;

            cbUpperThread.CheckedChanged += CheckedChanged;
            cbLowerThread.CheckedChanged += CheckedChanged;

            cbAutoCrit.CheckedChanged += CheckedChanged;
            cbAutoNotCrit.CheckedChanged += CheckedChanged;

            cbStitchLength.CheckedChanged += CheckedChanged;

            cbInfo1.CheckedChanged += CheckedChanged;
            cbInfo2.CheckedChanged += CheckedChanged;
            cbInfo3.CheckedChanged += CheckedChanged;
            cbInfo4.CheckedChanged += CheckedChanged;
            cbInfo5.CheckedChanged += CheckedChanged;
            cbInfo6.CheckedChanged += CheckedChanged;
            cbInfo7.CheckedChanged += CheckedChanged;

            cbExactLength1.CheckedChanged += CheckedChanged;
            cbExactLength2.CheckedChanged += CheckedChanged;
            cbExactLength3.CheckedChanged += CheckedChanged;
            cbExactLength4.CheckedChanged += CheckedChanged;
            cbExactLength5.CheckedChanged += CheckedChanged;
            cbExactLength6.CheckedChanged += CheckedChanged;
            cbExactLength7.CheckedChanged += CheckedChanged;

            cbExactLengthArticleCode.CheckedChanged += CheckedChanged;

            cbEMT422.CheckedChanged += CheckedChanged;
            cbETM14600.CheckedChanged += CheckedChanged;
            cbPrintArticleLabelEnabled.CheckedChanged += CheckedChanged;
            cbEtm14600ValuesEditable.CheckedChanged += CheckedChanged;

            txtTolInCrit.KeyUp += onKeyUp;
            txtTolNotInCrit.KeyUp += onKeyUp;

            txtStitchLengthMin.KeyUp += onKeyUp;
            txtStitchLengthMax.KeyUp += onKeyUp;

            txtMaxLength1.KeyUp += onKeyUp;
            txtMaxLength2.KeyUp += onKeyUp;
            txtMaxLength3.KeyUp += onKeyUp;
            txtMaxLength4.KeyUp += onKeyUp;
            txtMaxLength5.KeyUp += onKeyUp;
            txtMaxLength6.KeyUp += onKeyUp;
            txtMaxLength7.KeyUp += onKeyUp;
            txtMaxLengthArticleCode.KeyUp += onKeyUp;

            txtLabelText1.KeyUp += onKeyUp;
            txtLabelText2.KeyUp += onKeyUp;
            txtLabelText3.KeyUp += onKeyUp;
            txtLabelText4.KeyUp += onKeyUp;
            txtLabelText5.KeyUp += onKeyUp;
            txtLabelText6.KeyUp += onKeyUp;
            txtLabelText7.KeyUp += onKeyUp;





        }

        public void UpdateUI()
        {
            Control[] controls = new Control[] { pnlContent };

            var rest = controls.SelectMany(ctrl => ctrl
                 .Controls
                 .OfType<CheckBox>());
            foreach (var cb in rest)
            {
                if (cb.Tag != null)
                {
                    PropertyInfo propertyInfo = automatDto.GetType().GetProperty(cb.Tag.ToString());
                    if (propertyInfo != null)
                    {
                        bool value = (bool)propertyInfo.GetValue(automatDto, null);
                        cb.Checked = value;
                    }
                }

                Console.WriteLine(cb.Tag);
            }

            var tbrest = controls.SelectMany(ctrl => ctrl
                 .Controls
                 .OfType<TextBox>());
            foreach (var textBox in tbrest)
            {
                if (textBox.Tag != null)
                {
                    PropertyInfo propertyInfo = automatDto.GetType().GetProperty(textBox.Tag.ToString());
                    if (propertyInfo != null)
                    {
                        String value = (String)propertyInfo.GetValue(automatDto, null);
                        textBox.Text = value;
                    }
                }
            }
        }


        private void CheckedChanged(object sender, System.EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            PropertyInfo propertyInfo = automatDto.GetType().GetProperty(cb.Tag.ToString());
            if (propertyInfo != null)
            {
                propertyInfo.SetValue(automatDto, Convert.ChangeType(cb.Checked, propertyInfo.PropertyType), null);
                Console.WriteLine(cb.Tag);
            }

        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox textBox = sender as TextBox;
                PropertyInfo propertyInfo = automatDto.GetType().GetProperty(textBox.Tag.ToString());
                if (propertyInfo != null)
                {
                    propertyInfo.SetValue(automatDto, Convert.ChangeType(textBox.Text, propertyInfo.PropertyType), null);
                }
            }
        }
    }
}
