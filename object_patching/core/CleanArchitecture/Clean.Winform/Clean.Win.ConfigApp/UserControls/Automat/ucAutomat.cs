using Clean.WinF.Applications.Features.Article.DTOs;
using Clean.WinF.Applications.Features.Automat.Interfaces;
using Clean.WinF.Applications.Features.SerialNumber.DTOs;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Clean.Win.AppConfigUI.UserControls.Automat
{
    public partial class ucAutomat : UserControl
    {
        AutomatDto automatDto;
        IAutomatCommandServices _automatCommandServices;
        IAutomatQueryServices _automatQueryServices;
        List<SerialNumberDto> serialNumberDtos = new List<SerialNumberDto>() { new SerialNumberDto
                {
                    ID = 112234,
                    Name = "SADE_01",
                    InternalName = "SADE:Max1336335;ResetWhenExceed"
                }};

        public ucAutomat(
        IAutomatCommandServices _automatCommandServices,
        IAutomatQueryServices _automatQueryServices,
        AutomatDto automatDto)
        {
            InitializeComponent();
            this.automatDto = automatDto;

            this.ucAutomatdb1.automatDto = automatDto;
            this.ucAutomatdb1.UpdateUI();
            this.ucAutomatControl1.automatDto = automatDto;
            this.ucAutomatControl1.serialNumberDtos = serialNumberDtos;
            this.ucAutomatControl1.UpdateUI();

            this._automatQueryServices = _automatQueryServices;
            this._automatCommandServices = _automatCommandServices;
            txtID.Text = automatDto.ID.ToString();
            txtName.Text = automatDto.Name;
            txtAutomat.Text = automatDto.Code;
            txtAutomat.Text = automatDto.Code;
            cbActive.Checked = automatDto.IsActive;

            txtName.KeyUp += onKeyUp;
            txtAutomat.KeyUp += onKeyUp;
            cbActive.CheckedChanged += CheckedChanged;

        }

        private async void tsbSave_Click(object sender, System.EventArgs e)
        {
            AutomatDto automatDto2 = await _automatCommandServices.UpdateAutomat(automatDto);

            Console.WriteLine(automatDto2);
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
    }
}
