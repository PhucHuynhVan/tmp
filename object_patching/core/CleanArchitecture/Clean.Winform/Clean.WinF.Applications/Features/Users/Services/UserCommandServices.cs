using Clean.WinF.Applications.Features.Users.DTOs;
using Clean.WinF.Applications.Features.Users.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Clean.WinF.Shared.ErrorMessage;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Supplier.Services
{
    public class UserCommandServices : IUserCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public UserCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<bool> CreateBulk(List<UserDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.Users.User>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.Users.User>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.UserRepository.AddBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"CreateBulkThreads() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<bool> UpdateBulk(List<UserDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.Users.User>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.Users.User>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.UserRepository.UpdateBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"UpdateBulkThreads() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<UserDto> GetById(long id)
        {
            var result = new UserDto();

            if (id <= 0)
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_THREAD_NOT_FOUND);
                return result;
            }

            try
            {
                var existedEntity = await _unitOfWork.UserRepository.Query().FirstOrDefaultAsync(x => x.ID == id && x.IsActive == true);
                if (existedEntity != null)
                {
                    return _mapper.Map<Clean.WinF.Domain.Entities.Users.User, UserDto>(existedEntity);
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetById() ", ex.ToString()));
                result.MessageRet = CustomErrorMessage.APP_THREAD_NOT_FOUND;
                return result;
            }

            return result;
        }

        public async Task<List<UserDto>> ListAllAsync()
        {
            var result = new List<UserDto>();
            try
            {
                IEnumerable<Domain.Entities.Users.User> existedEntities = null;
                existedEntities = _unitOfWork.UserRepository.Query();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<Clean.WinF.Domain.Entities.Users.User, UserDto>(entity));
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("ListAllAsync() ", ex.ToString()));
                return null;
            }
            return result;
        }

        public async Task<UserDto> login(string userId, string password)
        {
            UserDto result = null;

            try
            {
                var existedEntity = await _unitOfWork.UserRepository.Query().FirstOrDefaultAsync(
                        x => x.UserID.Equals(userId)
                        && x.Password.Equals(password)
                        && x.IsActive == true);

                if (existedEntity != null)
                {
                    return _mapper.Map<Clean.WinF.Domain.Entities.Users.User, UserDto>(existedEntity);
                }
            }
            catch (Exception ex)
            {
                result = new UserDto();
                Log.Error(string.Concat("login() ", ex.ToString()));
                result.MessageRet = CustomErrorMessage.APP_USER_LOGIN_FAILED;
                return result;
            }

            return result;
        }

        #region private functions
        //private UserDto UpdateSuppilerInfo(Domain.Entities.Supplier supplier)
        //{
        //    if (supplier is null) return null;

        //    var supplierDTO = _mapper.Map<UserDto>(supplier);
        //    supplierDTO.CustomErrorCode = CustomOperationCodes.APP_SUPPLIER_UPDATE_SUCCESS;
        //    supplierDTO.MessageRet = CustomOperationCodes.APP_SUPPLIER_UPDATE_SUCCESS;
        //    return supplierDTO;
        //}
        #endregion
    }
}
