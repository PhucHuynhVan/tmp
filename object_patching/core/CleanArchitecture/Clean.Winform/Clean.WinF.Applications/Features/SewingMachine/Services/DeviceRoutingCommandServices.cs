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
    public class DeviceRoutingCommandServices : IDeviceRoutingCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public DeviceRoutingCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<List<DeviceRoutingDto>> ListAllAsync()
        {
            var result = new List<DeviceRoutingDto>();
            try
            {
                IEnumerable<DeviceRouting> existedEntities = null;
                existedEntities = await _unitOfWork.DeviceRoutingRepository.Query().ToListAsync();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<DeviceRouting, DeviceRoutingDto>(entity));
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
    }
}
