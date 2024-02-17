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
    public class PermissionCommandServices : IPermissionCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public PermissionCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }


        public async Task<bool> CreateBulk(List<PermissionDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.Users.Permission>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.Users.Permission>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.PermissionRepository.AddBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"CreateBulkT() error: {ex.ToString()}");
                return result;
            }

            return result;
        }
        public async Task<bool> UpdateBulk(List<PermissionDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.Users.Permission>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.Users.Permission>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.PermissionRepository.UpdateBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"UpdateBulk() error: {ex.ToString()}");
                return result;
            }

            return result;
        }
        public async Task<List<PermissionDto>> ListAllAsync()
        {
            var result = new List<PermissionDto>();
            try
            {
                IEnumerable<Domain.Entities.Users.Permission> existedEntities = null;
                existedEntities = await _unitOfWork.PermissionRepository.Query().ToListAsync();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<Clean.WinF.Domain.Entities.Users.Permission, PermissionDto>(entity));
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

        public async Task<List<PermissionDto>> GetAllsActive()
        {
            var result = new List<PermissionDto>();
            try
            {
                IEnumerable<Domain.Entities.Users.Permission> existedEntities = null;
                existedEntities = await _unitOfWork.PermissionRepository.Query()
                                                                   .Where(p => p.IsActive)
                                                                   .ToListAsync();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<Clean.WinF.Domain.Entities.Users.Permission, PermissionDto>(entity));
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetAllsActive() ", ex.ToString()));
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
