using Clean.Win.AppConfigUI.Forms;
using Clean.WinF.Applications.Features.Article.DTOs;
using Clean.WinF.Applications.Features.SerialNumber.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Clean.Win.AppConfigUI.UserControls.Automat
{
    public partial class ucAutomatControl : UserControl
    {
        public AutomatDto automatDto;
        public List<SerialNumberDto> serialNumberDtos;
        bool isInit = true;
        public ucAutomatControl()
        {
            InitializeComponent();
            cbxSerial.DataSource = serialNumberDtos;
            cbxSerial.DisplayMember = "InternalName";
            txtDescription.KeyUp += onKeyUp;
            txtAutoLogout.KeyUp += onKeyUp;
            txtMinETMMeasVal.KeyUp += onKeyUp;

        }

        public void UpdateUI()
        {

            isInit = true;
            cbxSerial.DataSource = serialNumberDtos;
            cbxSerial.DisplayMember = "InternalName";
            isInit = false;
            if (automatDto != null)
            {
                txtDescription.Text = automatDto.ControllDescription;
                txtAutoLogout.Text = automatDto.AutoLogout.ToString();
                txtMinETMMeasVal.Text = automatDto.MinETMMeasVal.ToString();
                cbIsAutoLogout.Checked = automatDto.IsAutoLogout;
                SerialNumberDto serialNumberDto = serialNumberDtos.FirstOrDefault(item => item.ID == automatDto.SerialId);
                if (serialNumberDto != null)
                {
                    cbxSerial.SelectedItem = serialNumberDto;
                }
                else
                {
                    cbxSerial.SelectedItem = null;
                }
            }
        }

        private void cbxSerial_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!isInit && cbxSerial.SelectedIndex != -1)
                automatDto.SerialId = serialNumberDtos[cbxSerial.SelectedIndex].ID;
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

        private void cbIsAutoLogout_CheckedChanged(object sender, EventArgs e)
        {
            automatDto.IsAutoLogout = cbIsAutoLogout.Checked;
        }

        private void btnAutomatParam_Click(object sender, EventArgs e)
        {
            FormAutomatParams formAutomatParams = new FormAutomatParams(automatDto);
            formAutomatParams.Show();
        }
    }
}
