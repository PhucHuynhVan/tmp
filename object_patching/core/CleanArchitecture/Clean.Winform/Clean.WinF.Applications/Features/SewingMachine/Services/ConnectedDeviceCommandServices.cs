using Clean.WinF.Applications.Features.SewingMachine.DTOs;
using Clean.WinF.Applications.Features.SewingMachine.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.Entities.SewingMachine.ConnectedDevice;
using Clean.WinF.Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.SewingMachine.Services
{
    public class ConnectedDeviceCommandServices : IConnectedDeviceCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public ConnectedDeviceCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<List<ConnectedDeviceDto>> ListAllAsync()
        {
            var result = new List<ConnectedDeviceDto>();
            try
            {
                IEnumerable<ConnectedDevice> existedEntities = null;
                existedEntities = await _unitOfWork.ConnectedDeviceRepository.Query().ToListAsync();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<ConnectedDevice, ConnectedDeviceDto>(entity));
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

        public async Task<bool> UpdateBulk(List<ConnectedDeviceDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<ConnectedDevice>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<ConnectedDevice>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.ConnectedDeviceRepository.UpdateBulkEntitiesAsync(bulks);
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
