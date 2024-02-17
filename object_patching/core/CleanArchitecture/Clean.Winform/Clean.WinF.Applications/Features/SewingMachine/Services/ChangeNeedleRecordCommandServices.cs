using Clean.WinF.Applications.Features.SewingMachine.DTOs;
using Clean.WinF.Applications.Features.SewingMachine.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.Entities.SewingMachine;
using Clean.WinF.Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.SewingMachine.Services
{
    public class ChangeNeedleRecordCommandServices : IChangeNeedleRecordCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public ChangeNeedleRecordCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<bool> CreateBulk(List<ChangeNeedleRecordDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<ChangeOfNeedlesRecords>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<ChangeOfNeedlesRecords>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.ChangeNeedleRecordRepository.AddBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"CreateBulkT() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<List<ChangeNeedleRecordDto>> ListAllAsync()
        {
            var result = new List<ChangeNeedleRecordDto>();
            try
            {
                IEnumerable<ChangeOfNeedlesRecords> existedEntities = null;
                existedEntities = await _unitOfWork.ChangeNeedleRecordRepository.Query().ToListAsync();

                if (existedEntities != null)
                {
                    foreach (var entity in existedEntities)
                    {
                        result.Add(_mapper.Map<ChangeOfNeedlesRecords, ChangeNeedleRecordDto>(entity));
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
        public async Task<List<ChangeNeedleRecordDto>> GetByTimeRange(long user_id, int machine_number, DateTime start_date, DateTime end_date)
        {
            var result = new List<ChangeNeedleRecordDto>();

            if (user_id <= 0 || machine_number <= 0)
            {
                var errorDto = new ChangeNeedleRecordDto
                {
                    MessageRet = "Invalid ID"
                };
                result.Add(errorDto);
                return result;
            }

            try
            {
                var dtos = await _unitOfWork.ChangeNeedleRecordRepository.Query()
                    .Where(ug => ug.UserID == user_id && ug.MachineNumber == machine_number && ug.CreatedOn >= start_date && ug.CreatedOn <= end_date && ug.IsActive)
                    .ToListAsync();

                if (dtos != null && dtos.Count > 0)
                {
                    result = dtos.Select(ug => _mapper.Map<ChangeNeedleRecordDto>(ug)).ToList();
                }
            }
            catch (Exception ex)
            {
                Log.Error($"GetAllById() error: {ex.ToString()}");
                var errorDto = new ChangeNeedleRecordDto
                {
                    MessageRet = "Error"
                };
                result.Add(errorDto);
            }
            return result;
        }

        public Task<List<ChangeNeedleRecordDto>> GetByUserIdAndMachineNumber(long user_id, int machine_number)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateBulk(List<ChangeNeedleRecordDto> dtos)
        {
            throw new NotImplementedException();
        }
    }
}
