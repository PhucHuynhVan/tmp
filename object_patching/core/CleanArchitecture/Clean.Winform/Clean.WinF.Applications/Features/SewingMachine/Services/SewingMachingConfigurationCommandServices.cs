using Clean.WinF.Applications.Features.SewingMachine.DTOs;
using Clean.WinF.Applications.Features.SewingMachine.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.Entities.SewingMachine;
using Clean.WinF.Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.SewingMachine.Services
{
    public class SewingMachingConfigurationCommandServices : ISewingMachingConfigurationCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public SewingMachingConfigurationCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<bool> CreateBulk(List<SewingMachineConfigurationDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<SewingMachineConfiguration>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<SewingMachineConfiguration>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.SewingMachineConfigurationRepository.AddBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"CreateBulkT() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<SewingMachineConfigurationDto> GetById(long id)
        {
            var result = new SewingMachineConfigurationDto();

            if (id <= 0)
            {
                result.MessageRet = string.Format("Not Found");
                return result;
            }

            try
            {
                var existedEntity = await _unitOfWork.SewingMachineConfigurationRepository.Query().FirstOrDefaultAsync(x => x.ID == id && x.IsActive == true);
                if (existedEntity != null)
                {
                    return _mapper.Map<SewingMachineConfiguration, SewingMachineConfigurationDto>(existedEntity);
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
        public async Task<List<SewingMachineConfigurationDto>> GetBySewingMachineNumber(int id)
        {
            var result = new List<SewingMachineConfigurationDto>();
            try
            {
                IEnumerable<SewingMachineConfiguration> existedEntities = await _unitOfWork.SewingMachineConfigurationRepository
                    .Query()
                    .Where(entity => entity.MachineNumber == id)
                    .ToListAsync();

                result.AddRange(existedEntities.Select(entity => _mapper.Map<SewingMachineConfiguration, SewingMachineConfigurationDto>(entity)));
            }
            catch (Exception ex)
            {
                Log.Error($"GetBySewingMachineNumber({id}) {ex.ToString()}");
                return null;
            }
            return result;
        }


        public async Task<List<SewingMachineConfigurationDto>> ListAllAsync()
        {
            var result = new List<SewingMachineConfigurationDto>();
            try
            {
                IEnumerable<SewingMachineConfiguration> existedEntities = null;
                existedEntities = await _unitOfWork.SewingMachineConfigurationRepository.Query().ToListAsync();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<SewingMachineConfiguration, SewingMachineConfigurationDto>(entity));
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

        public async Task<bool> UpdateBulk(List<SewingMachineConfigurationDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<SewingMachineConfiguration>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<SewingMachineConfiguration>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.SewingMachineConfigurationRepository.UpdateBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"UpdateBulk() error: {ex.ToString()}");
                return result;
            }

            return result;
        }
    }
}
