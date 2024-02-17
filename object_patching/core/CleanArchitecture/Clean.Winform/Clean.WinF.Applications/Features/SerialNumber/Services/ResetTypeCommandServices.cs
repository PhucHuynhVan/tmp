using Clean.WinF.Applications.Features.SerialNumber.DTOs;
using Clean.WinF.Applications.Features.SerialNumber.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.Entities.SerialNumber;
using Clean.WinF.Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.SerialNumber.Services
{
    public class ResetTypeCommandServices : IResetTypeCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public ResetTypeCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<List<ResetTypeDto>> ListAllAsync()
        {
            var result = new List<ResetTypeDto>();
            try
            {
                IEnumerable<ResetType> existedEntities = null;
                existedEntities = await _unitOfWork.ResetTypeRepository.Query().ToListAsync();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<ResetType, ResetTypeDto>(entity));
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
