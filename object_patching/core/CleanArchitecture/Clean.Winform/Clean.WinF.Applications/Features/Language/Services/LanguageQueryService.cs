using Clean.WinF.Applications.Features.Language.DTOs;
using Clean.WinF.Applications.Features.Language.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Language.Services
{
    public class LanguageQueryService : ILanguageQueryServices
    {
        private readonly IAsyncRepository<Clean.WinF.Domain.Entities.Languages.Language> _langRepository;
        private readonly IAsyncRepository<Clean.WinF.Domain.Entities.Languages.ApplicationDefinition> _appDefinitionRepository;
        private readonly IAsyncRepository<Clean.WinF.Domain.Entities.Languages.AppGroupGUIDefinition> _appGroupGUIRepository;
        private readonly IAsyncRepository<Clean.WinF.Domain.Entities.Languages.AppCodeGUIDefinition> _appCodeGUIRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;//implement automapper
        public LanguageQueryService(
            IAsyncRepository<Clean.WinF.Domain.Entities.Languages.Language> langRepository,
            IAsyncRepository<Clean.WinF.Domain.Entities.Languages.ApplicationDefinition> appDefinitionRepository,
            IAsyncRepository<Clean.WinF.Domain.Entities.Languages.AppGroupGUIDefinition> appGroupGUIDefinition,
            IAsyncRepository<Clean.WinF.Domain.Entities.Languages.AppCodeGUIDefinition> appCodeGUIRepository,
            IUnitOfWork unitOfWork)
        {
            _appDefinitionRepository = appDefinitionRepository;
            _appGroupGUIRepository = appGroupGUIDefinition;
            _appCodeGUIRepository = appCodeGUIRepository;
            _langRepository = langRepository;
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<List<LanguageDto>> GetAllLanguages(string displayCode)
        {
            var result = new List<LanguageDto>();

            try
            {
                IQueryable<Clean.WinF.Domain.Entities.Languages.Language> existedLangs = null;
                existedLangs = (IQueryable<Clean.WinF.Domain.Entities.Languages.Language>)_langRepository.Query().Where(p => p.DisplayCode.Equals(displayCode)).AsQueryable();

                if (existedLangs != null && existedLangs.Count() > 0)
                {
                    foreach (var lang in existedLangs)
                    {
                        var langDto = _mapper.Map<Clean.WinF.Domain.Entities.Languages.Language, LanguageDto>(lang);
                        result.Add(langDto);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetAllLanguages() ", ex.ToString()));
                return null;
            }

            return result;
        }

        public async Task<List<AppCodeGUIDefinitionDto>> GetAllLanguagesByCodeDefinition(int appID, string codeGroup, string langCode)
        {
            var result = new List<AppCodeGUIDefinitionDto>();

            try
            {
                IQueryable<Clean.WinF.Domain.Entities.Languages.AppCodeGUIDefinition> existedCodeGUIs = null;
                existedCodeGUIs = (IQueryable<Clean.WinF.Domain.Entities.Languages.AppCodeGUIDefinition>)_appCodeGUIRepository.Query().Where(p => p.AppID == appID
                && p.CodeGroupGUI.Equals(codeGroup)
                && p.Languages.Equals(langCode)
                && p.IsActive == true).AsQueryable();

                if (existedCodeGUIs != null && existedCodeGUIs.Count() > 0)
                {
                    foreach (var codeGUI in existedCodeGUIs)
                    {
                        var codeGUIDto = new AppCodeGUIDefinitionDto()
                        {
                            CodeGUI = codeGUI.CodeGUI,
                            Description = codeGUI.Description
                        };
                        result.Add(codeGUIDto);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetAllLanguagesByCodeDefinition() ", ex.ToString()));
                return null;
            }

            return result;
        }

        public int GetApplicationIDByName(string appName)
        {
            var result = 0;
            IQueryable<Clean.WinF.Domain.Entities.Languages.ApplicationDefinition> existedApps = null;
            existedApps = (IQueryable<Clean.WinF.Domain.Entities.Languages.ApplicationDefinition>)_appDefinitionRepository.Query().Where(p => p.Name.Equals(appName) && p.IsActive == true).AsQueryable();

            if (existedApps != null && existedApps.Count() > 0)
            {
                foreach (var app in existedApps)
                {
                    if (appName.Equals(app.Name))
                    {
                        result = app.AppID;
                        break;
                    }

                }
            }
            return result;
        }

        public string GetGroupNameByCodeGroup(int appID, string codeGroup)
        {
            string groupName = string.Empty;
            IQueryable<Clean.WinF.Domain.Entities.Languages.AppGroupGUIDefinition> existedGroups = null;
            existedGroups = (IQueryable<Clean.WinF.Domain.Entities.Languages.AppGroupGUIDefinition>)_appGroupGUIRepository.Query()
                            .Where(p => p.AppID == appID && p.CodeGroup.Equals(codeGroup) && p.IsActive == true).AsQueryable();

            if (existedGroups != null && existedGroups.Count() > 0)
            {
                foreach (var group in existedGroups)
                {
                    if (group.AppID == appID && group.CodeGroup.Equals(codeGroup))
                    {
                        groupName = group.CodeGroup;
                        break;
                    }

                }
            }
            return groupName;
        }

        public async Task<List<LanguageDto>> GetAlls()
        {
            var result = new List<LanguageDto>();

            try
            {
                IEnumerable<Domain.Entities.Languages.Language> existedEntities = null;
                existedEntities = _unitOfWork.LanguageRepository.Query();
                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        var dto = _mapper.Map<Clean.WinF.Domain.Entities.Languages.Language, LanguageDto>(entity);
                        result.Add(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetAllSuppliers() ", ex.ToString()));
                return null;
            }
            return result;
        }

    }
}
