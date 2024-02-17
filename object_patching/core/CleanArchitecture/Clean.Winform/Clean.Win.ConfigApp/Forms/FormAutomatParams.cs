using Clean.WinF.Applications.Features.Article.DTOs;
using System.Windows.Forms;

namespace Clean.Win.AppConfigUI.Forms
{
    public partial class FormAutomatParams : Form
    {
        public AutomatDto automatDto;
        public FormAutomatParams(AutomatDto automatDto)
        {
            InitializeComponent();
            this.automatDto = automatDto;
            txtID.Text = this.automatDto.ID.ToString();
            txtName.Text = this.automatDto.Name.ToString();
        }
    }
}
