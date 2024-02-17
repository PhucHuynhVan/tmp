using Clean.WinF.Applications.DTOs;
using Clean.WinF.Applications.Features.Language.DTOs;
using Clean.WinF.Applications.Features.SystemConfiguration.DTOs;
using System.Collections.Generic;
using System.Drawing;

namespace Clean.WinF.Applications.Features.Computer.DTOs
{
    public class ComputerDto : BaseDTO
    {
        public string Name { get; set; }
        public int MachineNumber { get; set; }
        public List<SystemConfigurationDtos> systemConfigs { get; set; }
        public int LanguagueForBiasysControlId { get; set; }
        public int LanguagueForBiasysDBId { get; set; }
        public LanguageDto LanguageForBiasysControl { get; set; }
        public LanguageDto LanguageForBiasysDB { get; set; }
        public string LanguageForBiasysControlName { get; set; }
        public string LanguageForBiasysDBName { get; set; }

        public bool IsEdit { get; set; }
        public Image StatusIcon { get; set; }
        public bool IsAdd { get; set; }

        public SystemConfigurationDtos FindSystemConfigurationValue(string key)
        {
            if (systemConfigs != null)
            {
                foreach (var dto in systemConfigs)
                {
                    if (dto.FeatureKey.Equals(key))
                    {
                        return dto;
                    }
                }
            }
            return null;
        }

        public void UpdateLanguageForBiasysControl()
        {
            if (LanguageForBiasysControl != null)
            {
                UpdateLanguageForBiasysControl(LanguageForBiasysControl);
            }
        }

        public void UpdateLanguageForBiasysControl(LanguageDto languageForBiasysControl)
        {
            LanguageForBiasysControl = languageForBiasysControl;
            LanguageForBiasysControlName = languageForBiasysControl.Lang;
        }

        public void UpdateLanguageForBiasysDB()
        {
            if (LanguageForBiasysDB != null)
            {
                UpdateLanguageForBiasysDB(LanguageForBiasysDB);
            }
        }

        public void UpdateLanguageForBiasysDB(LanguageDto languageForBiasysDB)
        {
            LanguageForBiasysDB = languageForBiasysDB;
            LanguageForBiasysDBName = languageForBiasysDB.Lang;
        }
    }
}
