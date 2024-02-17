using Clean.WinF.Applications.Features.SerialNumber.DTOs;
using Clean.WinF.Applications.Features.SerialNumber.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.SerialNumber.Services
{
    public class SerialNumberCommandServices : ISerialNumberCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public SerialNumberCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<SerialNumberDto> GetById(long id)
        {
            var result = new SerialNumberDto();

            if (id <= 0)
            {
                result.MessageRet = "Serial Number Not Found";
                return result;
            }

            try
            {
                var exixtedEntity = await _unitOfWork.SerialNumberRepository.Query().FirstOrDefaultAsync(x => x.ID == id);
                if (exixtedEntity != null)
                {
                    return _mapper.Map<Clean.WinF.Domain.Entities.SerialNumber.SerialNumber, SerialNumberDto>(exixtedEntity);
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetById() ", ex.ToString()));
                result.MessageRet = "Serial Number Not Found";
                return result;
            }

            return result;
        }

        public async Task<List<SerialNumberDto>> ListAllAsync()
        {
            var result = new List<SerialNumberDto>();
            try
            {
                IEnumerable<Clean.WinF.Domain.Entities.SerialNumber.SerialNumber> existedEntities = null;
                existedEntities = await _unitOfWork.SerialNumberRepository.Query().ToListAsync();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<Clean.WinF.Domain.Entities.SerialNumber.SerialNumber, SerialNumberDto>(entity));
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

        public async Task<bool> UpdateBulk(List<SerialNumberDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Clean.WinF.Domain.Entities.SerialNumber.SerialNumber>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Clean.WinF.Domain.Entities.SerialNumber.SerialNumber>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.SerialNumberRepository.UpdateBulkEntitiesAsync(bulks);
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
