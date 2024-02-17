using Clean.WinF.Applications.Features.Users.DTOs;
using Clean.WinF.Applications.Features.Users.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Users.Services
{
    public class UserGroupCommandServices : IUserGroupCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public UserGroupCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }
        public async Task<UserGroupDto> GetById(long role_id, long permission_id)
        {
            var result = new UserGroupDto();

            if (role_id <= 0 || permission_id <= 0)
            {
                result.MessageRet = "Invalid";
                return result;
            }

            try
            {
                var existedEntity = await _unitOfWork.UserGroupRepository.Query().FirstOrDefaultAsync(x => x.RoleID == role_id && x.PermissionID == permission_id && x.IsActive == true);
                if (existedEntity != null)
                {
                    return _mapper.Map<Clean.WinF.Domain.Entities.Users.UserGroup, UserGroupDto>(existedEntity);
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetById() ", ex.ToString()));
                result.MessageRet = "Not Found";
                return result;
            }

            return result;
        }
        public async Task<bool> CreateBulk(List<UserGroupDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.Users.UserGroup>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.Users.UserGroup>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.UserGroupRepository.AddBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"CreateBulkT() error: {ex.ToString()}");
                return result;
            }

            return result;
        }
        public async Task<bool> UpdateBulk(List<UserGroupDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.Users.UserGroup>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.Users.UserGroup>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.UserGroupRepository.UpdateBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"UpdateBulk() error: {ex.ToString()}");
                return result;
            }

            return result;
        }
        public async Task<List<UserGroupDto>> ListAllAsync()
        {
            var result = new List<UserGroupDto>();
            try
            {
                IEnumerable<Domain.Entities.Users.UserGroup> existedEntities = null;
                existedEntities = await _unitOfWork.UserGroupRepository.Query().ToListAsync();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<Clean.WinF.Domain.Entities.Users.UserGroup, UserGroupDto>(entity));
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

        public async Task<List<UserGroupDto>> GetAllById(long id)
        {
            var result = new List<UserGroupDto>();

            if (id <= 0)
            {
                // Tạo một UserGroupDto mới với thông báo lỗi và thêm vào danh sách kết quả
                var errorDto = new UserGroupDto
                {
                    MessageRet = "Invalid ID"
                };
                result.Add(errorDto);
                return result;
            }

            try
            {
                // Lấy tất cả các UserGroup có RoleID bằng id và IsActive == true
                var userGroups = await _unitOfWork.UserGroupRepository.Query()
                    .Where(ug => ug.RoleID == id && ug.IsActive)
                    .ToListAsync();

                if (userGroups != null && userGroups.Count > 0)
                {
                    // Chuyển đổi danh sách các UserGroup thành UserGroupDto và thêm vào danh sách kết quả
                    result = userGroups.Select(ug => _mapper.Map<UserGroupDto>(ug)).ToList();
                }
            }
            catch (Exception ex)
            {
                Log.Error($"GetAllById() error: {ex.ToString()}");
                // Tạo một UserGroupDto mới với thông báo lỗi và thêm vào danh sách kết quả
                var errorDto = new UserGroupDto
                {
                    MessageRet = "Error"
                };
                result.Add(errorDto);
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
