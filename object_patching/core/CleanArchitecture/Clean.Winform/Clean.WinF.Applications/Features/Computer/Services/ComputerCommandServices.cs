using Clean.WinF.Applications.Features.Computer.DTOs;
using Clean.WinF.Applications.Features.Computer.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Computer.Services
{
    public class ComputerCommandServices : IComputerCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public ComputerCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<bool> CreateBulk(List<ComputerDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.Computer>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.Computer>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.ComputerRepository.AddBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"CreateBulkT() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<ComputerDto> GetById(long id)
        {
            var result = new ComputerDto();

            if (id <= 0)
            {
                result.MessageRet = "Invalid";
                return result;
            }

            try
            {
                var existedEntity = await _unitOfWork.ComputerRepository.Query().FirstOrDefaultAsync(x => x.ID == id && x.IsActive == true);
                if (existedEntity != null)
                {
                    return _mapper.Map<Clean.WinF.Domain.Entities.Computer, ComputerDto>(existedEntity);
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

        public async Task<List<ComputerDto>> ListAllAsync()
        {
            var result = new List<ComputerDto>();
            try
            {
                IEnumerable<Domain.Entities.Computer> existedEntities = null;
                existedEntities = await _unitOfWork.ComputerRepository.Query().ToListAsync();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<Clean.WinF.Domain.Entities.Computer, ComputerDto>(entity));
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

        public async Task<bool> UpdateBulk(List<ComputerDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.Computer>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.Computer>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.ComputerRepository.UpdateBulkEntitiesAsync(bulks);
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
