using Clean.WinF.Applications.Features.SystemConfiguration.DTOs;
using Clean.WinF.Applications.Features.SystemConfiguration.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.SystemConfiguration.Services
{
    public class SystemConfigurationCommandServices : ISystemConfigurationCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public SystemConfigurationCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<bool> CreateBulk(List<SystemConfigurationDtos> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.SystemConfiguration>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.SystemConfiguration>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.SystemConfigurationRepository.AddBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"CreateBulk() error: {ex.ToString()}");
                return result;
            }

            return result;
        }
        public async Task<List<SystemConfigurationDtos>> ListAllAsync()
        {
            var result = new List<SystemConfigurationDtos>();
            try
            {
                IEnumerable<Domain.Entities.SystemConfiguration> existedEntities = null;
                existedEntities = await _unitOfWork.SystemConfigurationRepository.Query().ToListAsync();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<Domain.Entities.SystemConfiguration, SystemConfigurationDtos>(entity));
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

        public async Task<bool> UpdateBulk(List<SystemConfigurationDtos> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.SystemConfiguration>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.SystemConfiguration>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.SystemConfigurationRepository.UpdateBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"UpdateBulk() error: {ex.ToString()}");
                return result;
            }

            return result;
        }
        public async Task<SystemConfigurationDtos> GetByFeatureKey(string key)
        {
            var result = new SystemConfigurationDtos();

            if (string.IsNullOrEmpty(key))
            {
                result.MessageRet = "Invalid FeatureKey";
                return result;
            }

            try
            {
                var existedSupplier = await _unitOfWork.SystemConfigurationRepository.Query().FirstOrDefaultAsync(x => x.FeatureKey == key);
                if (existedSupplier != null)
                {
                    return _mapper.Map<Clean.WinF.Domain.Entities.SystemConfiguration, SystemConfigurationDtos>(existedSupplier);
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetByFeatureKey() ", ex.ToString()));
                result.MessageRet = "FeatureKey not found";
                return result;
            }

            return result;
        }
    }
}
