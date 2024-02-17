using Clean.WinF.Applications.Features.Part.DTOs;
using Clean.WinF.Applications.Features.Part.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Clean.WinF.Shared.ErrorMessage;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Part.Services
{
    public sealed class PartQueryServices : IPartQueryServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;
        public PartQueryServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<PartDto> GetById(long id)
        {
            var result = new PartDto();

            if (id <= 0)
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_PART_NOT_FOUND);
                return result;
            }

            try
            {
                var existedEntity = await _unitOfWork.PartRepository.Query().FirstOrDefaultAsync(x => x.ID == id && x.IsActive == true);
                if (existedEntity != null)
                {
                    return _mapper.Map<Clean.WinF.Domain.Entities.Part, PartDto>(existedEntity);
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetById() ", ex.ToString()));
                result.MessageRet = CustomErrorMessage.APP_PART_NOT_FOUND;
                return result;
            }

            return result;
        }

        public async Task<List<PartDto>> ListAllAsync()
        {
            var result = new List<PartDto>();
            try
            {
                IEnumerable<Domain.Entities.Part> existedEntities = null;
                existedEntities = _unitOfWork.PartRepository.Query();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<Clean.WinF.Domain.Entities.Part, PartDto>(entity));
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
