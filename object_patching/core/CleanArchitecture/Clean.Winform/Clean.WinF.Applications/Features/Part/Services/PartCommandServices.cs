using Clean.WinF.Applications.Features.Part.DTOs;
using Clean.WinF.Applications.Features.Part.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Part.Services
{
    public class PartCommandServices : IPartCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public PartCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<bool> CreateBulk(List<PartDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.Part>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.Part>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.PartRepository.AddBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"CreateBulkParts() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<bool> UpdateBulk(List<PartDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.Part>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.Part>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.PartRepository.UpdateBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"UpdateBulkParts() error: {ex.ToString()}");
                return result;
            }

            return result;
        }
    }
}
