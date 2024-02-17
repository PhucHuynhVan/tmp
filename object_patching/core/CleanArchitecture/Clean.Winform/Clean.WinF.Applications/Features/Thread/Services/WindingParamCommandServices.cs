using Clean.WinF.Applications.Features.Thread.DTOs;
using Clean.WinF.Applications.Features.Users.Interfaces;
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
    public class WindingParamCommandServices : IWindingParamCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public WindingParamCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<bool> CreateBulk(List<ThreadWindingParamDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.WindingParamter>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.WindingParamter>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.WindingParameterRepository.AddBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"CreateBulkWindingParams() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<bool> UpdateBulk(List<ThreadWindingParamDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.WindingParamter>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.WindingParamter>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.WindingParameterRepository.UpdateBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"UpdateBulkWindingParams() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<ThreadWindingParamDto> GetById(long id)
        {
            var result = new ThreadWindingParamDto();

            if (id <= 0)
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_THREAD_NOT_FOUND);
                return result;
            }

            try
            {
                var existedEntity = await _unitOfWork.WindingParameterRepository.Query().FirstOrDefaultAsync(x => x.ID == id && x.IsActive == true);
                if (existedEntity != null)
                {
                    return _mapper.Map<Clean.WinF.Domain.Entities.WindingParamter, ThreadWindingParamDto>(existedEntity);
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

        public async Task<List<ThreadWindingParamDto>> ListAllAsync()
        {
            var result = new List<ThreadWindingParamDto>();
            try
            {
                IEnumerable<Domain.Entities.WindingParamter> existedEntities = null;
                existedEntities = _unitOfWork.WindingParameterRepository.Query();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<Clean.WinF.Domain.Entities.WindingParamter, ThreadWindingParamDto>(entity));
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
