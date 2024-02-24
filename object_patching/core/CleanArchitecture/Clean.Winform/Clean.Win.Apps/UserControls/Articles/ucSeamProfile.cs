using Clean.WinF.Applications.Features.Article.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Clean.Win.AppUI.UserControls
{
    public partial class ucSeamProfile : UserControl
    {
        public delegate void DataChange();
        public event DataChange OnDataChange;
        public ArticleDto dto { get; set; }
        public List<RadioButton> radioButtons = new List<RadioButton>();
        public ucSeamProfile()
        {
            InitializeComponent();
            InitEvent();

        }

        private void InitEvent()
        {
            radioButtons.Add(rbCustomSeam1);
            radioButtons.Add(rbCustomSeam2);
            radioButtons.Add(rbCustomSeam3);

            radioButtons.Add(rb1Critical4Notches1);
            radioButtons.Add(rb1Critical4Notches2);
            radioButtons.Add(rb1Critical4Notches3);
            radioButtons.Add(rb1Critical4Notches4);
            radioButtons.Add(rb1Critical4Notches5);
            radioButtons.Add(rb1Critical4Notches6);

            radioButtons.Add(rb1Critical2Notches1);
            radioButtons.Add(rb1Critical2Notches2);
            radioButtons.Add(rb1Critical2Notches3);
            radioButtons.Add(rb1Critical2Notches4);
            radioButtons.Add(rb1Critical2Notches5);

            radioButtons.Add(rb1Critical0Notches1);
            radioButtons.Add(rb1Critical0Notches2);

            foreach (RadioButton radioButton in radioButtons)
            {
                radioButton.MouseUp += new MouseEventHandler(radioButtons_MouseUp);
            }


        }

        private void radioButtons_MouseUp(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (!dto.IsCreated)
            {
                dto.IsUpdated = true;
            }
            dto.SeamProfile = radioButton.Tag as string;

            if (sender is RadioButton current && current.Checked)
            {
                // We should remove Check from the rest RadioButtons:
                var rest = new Control[] { pnl1Critical0Notches, pnl1Critical2Notches, pnl1Critical4Notches, pnlCustomSeam }
                  .SelectMany(ctrl => ctrl             // all radiobuttons on panel1, panel2
                     .Controls
                     .OfType<RadioButton>())
                  .Where(button => button != current); // don't touch current it should stay checked

                foreach (var button in rest)
                    button.Checked = false;
            }
            OnDataChange.Invoke();
        }

        public void updateFormData()
        {
            foreach (RadioButton radioButton in radioButtons)
            {
                radioButton.Checked = radioButton.Tag.Equals(dto.SeamProfile);
            }
            if (dto.Automat != null)
            {
                AutomatDto automatDto = dto.Automat;

                //OneCriticalSectionNoSeamsWithFLPart
                rb1Critical0Notches2.Enabled = automatDto.OneCriticalSectionNoSeamsWithFLPart;
                pictureBox1.Enabled = automatDto.OneCriticalSectionNoSeamsWithFLPart;

                //OneCriticalSectionNoSeamsWithEndLabel
                rb1Critical0Notches1.Enabled = automatDto.OneCriticalSectionNoSeamsWithEndLabel;
                pictureBox5.Enabled = automatDto.OneCriticalSectionNoSeamsWithEndLabel;
                //OneCriticalSectionTwoSeamsWithFLPart
                rb1Critical2Notches3.Enabled = automatDto.OneCriticalSectionTwoSeamsWithFLPart;
                pictureBox4.Enabled = automatDto.OneCriticalSectionTwoSeamsWithFLPart;



                //OneCriticalSectionTwoSeamsWithEndLabelBehind
                rb1Critical2Notches1.Enabled = automatDto.OneCriticalSectionTwoSeamsWithEndLabelBehind;
                pictureBox2.Enabled = automatDto.OneCriticalSectionTwoSeamsWithEndLabelBehind;

                //OneCriticalSectionTwoSeamsWithEndLabel
                rb1Critical2Notches2.Enabled = automatDto.OneCriticalSectionTwoSeamsWithEndLabel;
                pictureBox3.Enabled = automatDto.OneCriticalSectionTwoSeamsWithEndLabel;

                //ThreeCriticalSectionTwoSeamsWithFLPart
                rb1Critical2Notches5.Enabled = automatDto.ThreeCriticalSectionTwoSeamsWithFLPart;
                pictureBox6.Enabled = automatDto.ThreeCriticalSectionTwoSeamsWithFLPart;
                //ThreeCriticalSectionTwoSeamsWithEndLabel
                rb1Critical2Notches4.Enabled = automatDto.ThreeCriticalSectionTwoSeamsWithEndLabel;
                pictureBox7.Enabled = automatDto.ThreeCriticalSectionTwoSeamsWithEndLabel;


                //TwoCriticalSectionFourSeamsWithFLPart
                rb1Critical4Notches3.Enabled = automatDto.TwoCriticalSectionFourSeamsWithFLPart;
                pictureBox10.Enabled = automatDto.TwoCriticalSectionFourSeamsWithFLPart;
                //TwoCriticalSectionFourSeamsWithEndLabelBehind
                rb1Critical4Notches1.Enabled = automatDto.TwoCriticalSectionFourSeamsWithEndLabelBehind;
                pictureBox12.Enabled = automatDto.TwoCriticalSectionFourSeamsWithEndLabelBehind;
                //TwoCriticalSectionFourSeamsWithEndLabel
                rb1Critical4Notches2.Enabled = automatDto.TwoCriticalSectionFourSeamsWithEndLabel;
                pictureBox11.Enabled = automatDto.TwoCriticalSectionFourSeamsWithEndLabel;

                //ThreeCriticalSectionFourSeamsWithFLPart
                rb1Critical4Notches6.Enabled = automatDto.ThreeCriticalSectionFourSeamsWithFLPart;
                pictureBox13.Enabled = automatDto.ThreeCriticalSectionFourSeamsWithFLPart;

                //ThreeCriticalSectionFourSeamsWithEndLabelBehind
                rb1Critical4Notches4.Enabled = automatDto.ThreeCriticalSectionFourSeamsWithEndLabelBehind;
                pictureBox9.Enabled = automatDto.ThreeCriticalSectionFourSeamsWithEndLabelBehind;

                //ThreeCriticalSectionFourSeamsWithEndLabel
                rb1Critical4Notches5.Enabled = automatDto.ThreeCriticalSectionFourSeamsWithEndLabel;
                pictureBox8.Enabled = automatDto.ThreeCriticalSectionFourSeamsWithEndLabel;

                //OneCriticalSectionTwoSeamsWithTwoEndLabel
                rbCustomSeam2.Enabled = automatDto.OneCriticalSectionTwoSeamsWithTwoEndLabel;
                pictureBox16.Enabled = automatDto.OneCriticalSectionTwoSeamsWithTwoEndLabel;

                //TwoCriticalSectionFourSeamsWithTwoEndLabel
                rbCustomSeam1.Enabled = automatDto.TwoCriticalSectionFourSeamsWithTwoEndLabel;
                pictureBox14.Enabled = automatDto.TwoCriticalSectionFourSeamsWithTwoEndLabel;

                //ThreeCriticalSectionFourSeamsWithTwoEndLabel
                rbCustomSeam1.Enabled = automatDto.ThreeCriticalSectionFourSeamsWithTwoEndLabel;
                pictureBox14.Enabled = automatDto.ThreeCriticalSectionFourSeamsWithTwoEndLabel;
            }

        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (!dto.IsCreated)
            {
                dto.IsUpdated = true;
            }
            dto.SeamProfile = radioButton.Tag as string;

            if (sender is RadioButton current && current.Checked)
            {
                // We should remove Check from the rest RadioButtons:
                var rest = new Control[] { pnl1Critical0Notches, pnl1Critical2Notches, pnl1Critical4Notches, pnlCustomSeam }
                  .SelectMany(ctrl => ctrl             // all radiobuttons on panel1, panel2
                     .Controls
                     .OfType<RadioButton>())
                  .Where(button => button != current); // don't touch current it should stay checked

                foreach (var button in rest)
                    button.Checked = false;
            }
            OnDataChange.Invoke();
        }

        public void ShowProfile(int profileId)
        {
            switch (profileId)
            {
                case 1:
                    pnl1Critical0Notches.Visible = false;
                    pnl1Critical2Notches.Visible = true;
                    pnl1Critical4Notches.Visible = false;
                    pnlCustomSeam.Visible = false;
                    break;
                case 2:
                    pnl1Critical0Notches.Visible = false;
                    pnl1Critical2Notches.Visible = false;
                    pnl1Critical4Notches.Visible = true;
                    pnlCustomSeam.Visible = false;
                    break;
                case 3:
                    pnl1Critical0Notches.Visible = false;
                    pnl1Critical2Notches.Visible = false;
                    pnl1Critical4Notches.Visible = false;
                    pnlCustomSeam.Visible = true;
                    break;
                default:
                    pnl1Critical0Notches.Visible = true;
                    pnl1Critical2Notches.Visible = false;
                    pnl1Critical4Notches.Visible = false;
                    pnlCustomSeam.Visible = false;
                    break;
            }
        }
    }


}
