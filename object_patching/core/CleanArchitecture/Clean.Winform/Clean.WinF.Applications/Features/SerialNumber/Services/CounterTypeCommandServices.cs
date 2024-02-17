﻿using Clean.WinF.Applications.Features.SerialNumber.DTOs;
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
    public class CounterTypeCommandServices : ICounterTypeCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public CounterTypeCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<List<CounterTypeDto>> ListAllAsync()
        {
            var result = new List<CounterTypeDto>();
            try
            {
                IEnumerable<CounterType> existedEntities = null;
                existedEntities = await _unitOfWork.CounterTypeRepository.Query().ToListAsync();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<CounterType, CounterTypeDto>(entity));
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
