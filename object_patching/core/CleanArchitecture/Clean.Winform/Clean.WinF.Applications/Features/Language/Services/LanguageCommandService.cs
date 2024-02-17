using Clean.WinF.Applications.Features.Language.DTOs;
using Clean.WinF.Applications.Features.Language.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Language.Services
{
    public class LanguageCommandService : ILanguageCommandServices
    {
        private readonly IAsyncRepository<Clean.WinF.Domain.Entities.Languages.Language> _langRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public LanguageCommandService(IAsyncRepository<Clean.WinF.Domain.Entities.Languages.Language> langRepository,
            IUnitOfWork unitOfWork)
        {
            _langRepository = langRepository;
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<LanguageDto> CreateNewLanguage(LanguageDto addLang)
        {
            var result = new LanguageDto();

            if (string.IsNullOrEmpty(addLang.Code.Trim()))
            {
                //result.MessageRet = string.Format(CustomErrorMessage.APP_GROUP_NAME_EMPTY);
                return null;
            }

            if (string.IsNullOrEmpty(addLang.Lang.Trim()))
            {
                //result.CustomErrorCode = CustomErrorCode.APP_PART_NAME_EMPTY;
                //result.MessageRet = string.Format(CustomErrorMessage.APP_GROUP_NAME_EMPTY);
                return result;
            }

            //var existedLang = await _unitOfWork.LanguageRepository.Query().FirstOrDefault(p=>p.Code.Equals(addLang.Code));
            //if (existedLang != null)
            //{
            //    //result.MessageRet = string.Format(CustomErrorMessage.APP_PART_CODE_EXISTED_ALREADY);
            //    return result;
            //}                        

            //add new to db
            var newLang = new Clean.WinF.Domain.Entities.Languages.Language()
            {
                Code = addLang.Code,
                Lang = addLang.Lang,
                IconImg = addLang.IconImg
            };

            try
            {
                var langResult = await _unitOfWork.LanguageRepository.AddAsync(newLang);
                var resultAdd = _unitOfWork.Complete();
                //if (resultAdd > 0)
                //{
                //    result.CustomErrorCode = CustomOperationCodes.APP_PART_ADD_SUCCESS;
                //}
                //else
                //{
                //    result.CustomErrorCode = CustomOperationCodes.APP_PART_ADD_FAIL;
                //    result.MessageRet = CustomOperationCodes.APP_PART_ADD_FAIL;
                //}
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("CreateNewPart() ", ex.ToString()));
                //result.MessageRet = CustomOperationCodes.APP_PART_ADD_FAIL;
                return result;
            }

            return result;
        }

        public async Task<bool> CreateBulkLanguages(IList<LanguageDto> addLangs)
        {
            var result = true;
            try
            {
                if (addLangs != null)
                {
                    var bulkLangs = new List<Domain.Entities.Languages.Language>();
                    foreach (var langDto in addLangs)
                    {
                        var langEntity = _mapper.Map<LanguageDto, Domain.Entities.Languages.Language>(langDto);
                        bulkLangs.Add(langEntity);
                    }

                    if (bulkLangs != null && bulkLangs.Count > 0)
                        result = await _unitOfWork.LanguageRepository.AddBulkEntitiesAsync(bulkLangs);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"AddBulkEntitiesAsync() error: {ex.ToString()}");
                return result;
            }

            return result;
        }
    }
}
