using Clean.WinF.Applications.Features.Thread.DTOs;
using Clean.WinF.Applications.Features.Thread.Interfaces;
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
    public sealed class ThreadQueryServices : IThreadQueryServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;
        public ThreadQueryServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<ThreadDto> GetById(long id)
        {
            var result = new ThreadDto();

            if (id <= 0)
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_THREAD_NOT_FOUND);
                return result;
            }

            try
            {
                var existedEntity = await _unitOfWork.ThreadRepository.Query().FirstOrDefaultAsync(x => x.ID == id && x.IsActive == true);
                if (existedEntity != null)
                {
                    return _mapper.Map<Clean.WinF.Domain.Entities.Thread, ThreadDto>(existedEntity);
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

        public async Task<List<ThreadDto>> ListAllAsync()
        {
            var result = new List<ThreadDto>();
            try
            {
                IEnumerable<Domain.Entities.Thread> existedEntities = null;
                existedEntities = _unitOfWork.ThreadRepository.Query();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<Clean.WinF.Domain.Entities.Thread, ThreadDto>(entity));
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
