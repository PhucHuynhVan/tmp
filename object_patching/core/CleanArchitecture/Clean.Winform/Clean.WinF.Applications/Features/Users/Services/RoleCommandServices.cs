using Clean.WinF.Applications.Features.Users.DTOs;
using Clean.WinF.Applications.Features.Users.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Users.Services
{
    public class RoleCommandServices : IRoleCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public RoleCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }
        public async Task<RoleDto> GetById(long id)
        {
            var result = new RoleDto();

            if (id <= 0)
            {
                result.MessageRet = string.Format("Not Found");
                return result;
            }

            try
            {
                var existedEntity = await _unitOfWork.RoleRepository.Query().FirstOrDefaultAsync(x => x.ID == id && x.IsActive == true);
                if (existedEntity != null)
                {
                    return _mapper.Map<Clean.WinF.Domain.Entities.Users.Role, RoleDto>(existedEntity);
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
        public async Task<bool> CreateBulk(List<RoleDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.Users.Role>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.Users.Role>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.RoleRepository.AddBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"CreateBulkT() error: {ex.ToString()}");
                return result;
            }

            return result;
        }
        public async Task<bool> UpdateBulk(List<RoleDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.Users.Role>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.Users.Role>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.RoleRepository.UpdateBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"UpdateBulk() error: {ex.ToString()}");
                return result;
            }

            return result;
        }
        public async Task<List<RoleDto>> ListAllAsync()
        {
            var result = new List<RoleDto>();
            try
            {
                IEnumerable<Domain.Entities.Users.Role> existedEntities = null;
                existedEntities = await _unitOfWork.RoleRepository.Query().ToListAsync();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<Clean.WinF.Domain.Entities.Users.Role, RoleDto>(entity));
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
