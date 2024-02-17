using Clean.WinF.Applications.Features.Bobbin.DTOs;
using Clean.WinF.Applications.Features.Bobbin.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Supplier.Services
{
    public class BobbinCommandServices : IBobbinCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public BobbinCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<bool> CreateBulk(List<BobbinDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.Bobbin>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.Bobbin>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.BobbinRepository.AddBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"CreateBulkBobbins() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<bool> UpdateBulk(List<BobbinDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.Bobbin>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.Bobbin>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.BobbinRepository.UpdateBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"UpdateBulkBobbins() error: {ex.ToString()}");
                return result;
            }

            return result;
        }
    }
}
