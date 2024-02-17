using Clean.WinF.Applications.Features.Bobbin.DTOs;
using Clean.WinF.Applications.Features.Bobbin.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Clean.WinF.Shared.ErrorMessage;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Supplier.Services
{
    public sealed class BobbinQueryServices : IBobbinQueryServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;
        public BobbinQueryServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<BobbinDto> GetById(long id)
        {
            var result = new BobbinDto();

            if (id <= 0)
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_BOBBIN_NOT_FOUND);
                return result;
            }

            try
            {
                var existedEntity = await _unitOfWork.BobbinRepository.Query().FirstOrDefaultAsync(x => x.ID == id && x.IsActive == true);
                if (existedEntity != null)
                {
                    return _mapper.Map<Clean.WinF.Domain.Entities.Bobbin, BobbinDto>(existedEntity);
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetById() ", ex.ToString()));
                result.MessageRet = CustomErrorMessage.APP_THREAD_NOT_FOUND;
                return result;
            }

            return result;
        }

        public async Task<List<BobbinDto>> ListAllAsync()
        {
            var result = new List<BobbinDto>();
            try
            {
                IEnumerable<Domain.Entities.Bobbin> existedEntities = null;
                existedEntities = _unitOfWork.BobbinRepository.Query();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<Clean.WinF.Domain.Entities.Bobbin, BobbinDto>(entity));
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
