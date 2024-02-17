using Clean.WinF.Applications.Features.Article.DTOs;
using Clean.WinF.Applications.Features.Automat.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Common.Utilities;
using Clean.WinF.Domain.IRepository;
using Clean.WinF.Shared.Constants;
using Clean.WinF.Shared.ErrorMessage;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Automat.Services
{
    public class AutomatCommandServices : IAutomatCommandServices
    {
        private readonly IAsyncRepository<Clean.WinF.Domain.Entities.Automat> _automatRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;//implement automapper

        public AutomatCommandServices(IAsyncRepository<Clean.WinF.Domain.Entities.Automat> automatRepository, IUnitOfWork unitOfWork)
        {
            _automatRepository = automatRepository;
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();

        }

        public async Task<AutomatDto> CreateNewAutomat(AutomatDto addAutomat)
        {
            var result = new AutomatDto();

            if (string.IsNullOrEmpty(addAutomat.Name.Trim()))
            {
                result.CustomErrorCode = CustomErrorCode.APP_PART_CODE_EMPTY;
                result.MessageRet = string.Format(CustomErrorMessage.APP_GROUP_NAME_EMPTY);
                return result;
            }

            if (string.IsNullOrEmpty(addAutomat.Code.Trim()))
            {
                result.CustomErrorCode = CustomErrorCode.APP_PART_NAME_EMPTY;
                result.MessageRet = string.Format(CustomErrorMessage.APP_GROUP_NAME_EMPTY);
                return result;
            }

            var existedAutomat = await _unitOfWork.AutomatRepository.Query().FirstOrDefaultAsync(x => x.Code.Equals(addAutomat.Code) && x.IsActive == true);
            if (existedAutomat != null)
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_PART_CODE_EXISTED_ALREADY);
                return result;
            }

            if (CleanWinFUtility.HasSpecialCharacters(addAutomat.Code.Trim()))
            {
                result.CustomErrorCode = CustomErrorCode.APP_PART_INVALID_NAME;
                result.MessageRet = CustomErrorMessage.APP_PART_INVALID_NAME;
                return result;
            }

            if (CleanWinFUtility.HasSpecialCharacters(addAutomat.Name.Trim()))
            {
                result.CustomErrorCode = CustomErrorCode.APP_PART_INVALID_CODE;
                result.MessageRet = CustomErrorMessage.APP_PART_INVALID_CODE;
                return result;
            }

            //add new to db
            var newAutomat = _mapper.Map<Domain.Entities.Automat>(addAutomat);


            try
            {
                var automatResult = await _unitOfWork.AutomatRepository.AddAsync(newAutomat);
                var resultAdd = _unitOfWork.Complete();
                if (resultAdd > 0)
                {
                    result.CustomErrorCode = CustomOperationCodes.APP_PART_ADD_SUCCESS;
                }
                else
                {
                    result.CustomErrorCode = CustomOperationCodes.APP_PART_ADD_FAIL;
                    result.MessageRet = CustomOperationCodes.APP_PART_ADD_FAIL;
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("CreateNewAutomat() ", ex.ToString()));
                result.MessageRet = CustomOperationCodes.APP_PART_ADD_FAIL;
                return result;
            }

            return result;
        }

        public async Task<bool> CreateBulkAutomats(List<AutomatDto> addedAutomats)
        {
            var result = true;
            try
            {
                if (addedAutomats != null)
                {
                    var bulkAutomats = new List<Domain.Entities.Automat>();
                    foreach (var automatDto in addedAutomats)
                    {
                        //var automat = new Domain.Entities.Automat()
                        //{
                        //    Name = automatDto.Name,
                        //    Code = automatDto.Code
                        //}; 
                        var automat = _mapper.Map<Domain.Entities.Automat>(automatDto);
                        bulkAutomats.Add(automat);
                    }

                    if (bulkAutomats != null && bulkAutomats.Count > 0)
                        result = await _unitOfWork.AutomatRepository.AddBulkEntitiesAsync(bulkAutomats);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"CreateBulkAutomats() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<AutomatDto> UpdateAutomat(AutomatDto updatedAutomat)
        {
            var result = new AutomatDto();

            if (string.IsNullOrEmpty(updatedAutomat.Name.Trim()))
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_GROUP_NAME_EMPTY);
                return result;
            }

            if (string.IsNullOrEmpty(updatedAutomat.Code.Trim()))
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_GROUP_NAME_EMPTY);
                return result;
            }

            //if (CleanWinFUtility.HasSpecialCharacters(updatedAutomat.Name) || CleanWinFUtility.HasSpecialCharacters(updatedAutomat.Code))
            //{
            //    result.MessageRet = string.Format(CustomErrorMessage.APP_GROUP_NAME_EMPTY);
            //    return result;
            //}

            var existedAutomat = await _unitOfWork.AutomatRepository.Query().FirstOrDefaultAsync(x => x.Code.Equals(updatedAutomat.Code) && x.IsActive == true);

            if (existedAutomat is null)
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_GROUP_NOT_FOUND, updatedAutomat.ID);
                return result;
            }

            existedAutomat = _mapper.Map<Domain.Entities.Automat>(updatedAutomat);
            existedAutomat.UpdatedOn = DateTime.Now;

            try
            {
                var resultUpdated = await _unitOfWork.AutomatRepository.UpdateAsync(existedAutomat);
                result = UpdateAutomatInfo(resultUpdated);
            }
            catch (Exception ex)
            {
                Log.Error($"UpdateGroup() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<bool> UpdateBulkAutomats(List<AutomatDto> updatedAutomats)
        {
            var result = true;
            try
            {
                if (updatedAutomats != null)
                {
                    var bulkAutomats = new List<Domain.Entities.Automat>();
                    foreach (var automatDto in updatedAutomats)
                    {
                        var automat = _mapper.Map<Domain.Entities.Automat>(automatDto);
                        bulkAutomats.Add(automat);
                    }

                    if (bulkAutomats != null && bulkAutomats.Count > 0)
                        result = await _unitOfWork.AutomatRepository.UpdateBulkEntitiesAsync(bulkAutomats);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"UpdateBulkAutomats() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<AutomatDto> DeleteAutomat(AutomatDto deletedAutomat)
        {
            var result = new AutomatDto();

            var existedAutomat = await _unitOfWork.AutomatRepository.Query().FirstOrDefaultAsync(x => x.ID == deletedAutomat.ID);

            if (existedAutomat is null || existedAutomat.IsActive == false)
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_GROUP_NOT_FOUND, deletedAutomat.ID);
                return result;
            }

            existedAutomat.UpdatedOn = DateTime.UtcNow;
            existedAutomat.UpdatedBy = "Test";
            existedAutomat.IsActive = false;

            try
            {
                var resultUpdated = await _unitOfWork.AutomatRepository.UpdateAsync(existedAutomat);
            }
            catch (Exception ex)
            {
                Log.Error($"DeleteAutomat() error: {ex.ToString()}");
                result.MessageRet = string.Format(CustomErrorMessage.APP_GROUP_REMOVED_FAIL, existedAutomat.Code);
                return result;
            }

            return result;
        }

        #region private functions
        private AutomatDto UpdateAutomatInfo(Domain.Entities.Automat automat)
        {
            if (automat is null) return null;
            var automatDTO = _mapper.Map<AutomatDto>(automat);
            automatDTO.CustomErrorCode = CustomOperationCodes.APP_ARTICLE_UPDATE_SUCCESS;
            automatDTO.MessageRet = CustomOperationCodes.APP_ARTICLE_UPDATE_SUCCESS;
            return automatDTO;
        }
        #endregion
    }
}
