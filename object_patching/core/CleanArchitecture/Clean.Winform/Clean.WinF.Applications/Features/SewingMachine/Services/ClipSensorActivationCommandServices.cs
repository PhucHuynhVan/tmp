using Clean.WinF.Applications.Features.SewingMachine.DTOs;
using Clean.WinF.Applications.Features.SewingMachine.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.Entities.SewingMachine;
using Clean.WinF.Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.SewingMachine.Services
{
    public class ClipSensorActivationCommandServices : IClipSensorActivationCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public ClipSensorActivationCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<bool> CreateBulk(List<ClipSensorActivationDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<ClipSenSorActivation>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<ClipSenSorActivation>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.ClipSenSorActivationRepository.AddBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"CreateBulkT() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<List<ClipSensorActivationDto>> ListAllAsync()
        {
            var result = new List<ClipSensorActivationDto>();
            try
            {
                IEnumerable<ClipSenSorActivation> existedEntities = null;
                existedEntities = await _unitOfWork.ClipSenSorActivationRepository.Query().ToListAsync();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<ClipSenSorActivation, ClipSensorActivationDto>(entity));
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
