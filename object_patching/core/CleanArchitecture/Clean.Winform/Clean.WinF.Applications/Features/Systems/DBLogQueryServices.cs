using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Clean.WinF.Shared.Constants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Systems.Log
{
    public class DBLogQueryServices : IDBLogQueryServices
    {
        private readonly int maxRecs = 20;
        private readonly IAsyncRepository<Clean.WinF.Domain.Entities.Log.DBLog> _dbLogRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;
        public DBLogQueryServices(IAsyncRepository<Clean.WinF.Domain.Entities.Log.DBLog> dbLogRepository, IUnitOfWork unitOfWork)
        {
            _dbLogRepository = dbLogRepository;
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<DBLogDto> GetDBLogById(long id)
        {
            var result = new DBLogDto();

            if (id <= 0) return null;

            try
            {
                var existedDBLog = await _unitOfWork.DBLogRepository.Query().FirstOrDefaultAsync(p => p.Id == id);
                if (existedDBLog != null)
                {
                    return _mapper.Map<Clean.WinF.Domain.Entities.Log.DBLog, DBLogDto>(existedDBLog);
                }
            }
            catch (Exception ex)
            {
                Serilog.Log.Error(string.Concat("GetDBLogById() ", ex.ToString()));
                return null;
            }

            return result;
        }
        public async Task<List<DBLogDto>> GetDBLogByConditions(string appName, string logLevel, DateTime from, DateTime to)
        {
            var result = new List<DBLogDto>();
            var fromValue = from.ToString("yyyy-MM-ddTHH:mm:ss.fff");
            var toValue = to.ToString("yyyy-MM-ddTHH:mm:ss.fff");
            try
            {
                IEnumerable<Clean.WinF.Domain.Entities.Log.DBLog> existedDBLogs = null;
                if (!string.IsNullOrEmpty(appName) && !string.IsNullOrEmpty(logLevel))
                {
                    existedDBLogs = _dbLogRepository.Query().Where(p => p.Properties.Contains(appName) && p.Level.Equals(logLevel) && string.Compare(p.TimeStamp, fromValue) >= 0 && string.Compare(p.TimeStamp, toValue) <= 0).OrderByDescending(p => p.TimeStamp).Take(maxRecs).ToList();
                }
                else
                {
                    if (!string.IsNullOrEmpty(appName))
                    {
                        existedDBLogs = _dbLogRepository.Query().Where(p => p.Properties.Contains(appName) && string.Compare(p.TimeStamp, fromValue) >= 0 && string.Compare(p.TimeStamp, toValue) <= 0).OrderByDescending(p => p.TimeStamp).Take(maxRecs).ToList();
                    }
                    else if (!string.IsNullOrEmpty(logLevel))
                    {
                        existedDBLogs = _dbLogRepository.Query().Where(p => p.Level.Equals(logLevel) && string.Compare(p.TimeStamp, fromValue) >= 0 && string.Compare(p.TimeStamp, toValue) <= 0).OrderByDescending(p => p.TimeStamp).Take(maxRecs).ToList();
                    }
                    else
                    {
                        existedDBLogs = _dbLogRepository.Query().Where(p => string.Compare(p.TimeStamp, fromValue) >= 0 && string.Compare(p.TimeStamp, toValue) <= 0).OrderByDescending(p => p.TimeStamp).Take(maxRecs).ToList();
                    }
                }

                if (existedDBLogs != null)
                {
                    foreach (var log in existedDBLogs)
                    {
                        var dbLogDto = new DBLogDto()
                        {
                            Id = log.Id,
                            Exception = log.Exception,
                            RenderedMessage = log.RenderedMessage,
                            Level = log.Level,
                            TimeStamp = log.TimeStamp,
                            Properties = log.Properties
                        };
                        result.Add(dbLogDto);
                    }
                }
            }
            catch (Exception ex)
            {
                Serilog.Log.Error(string.Concat("GetDBLogByConditions() ", ex.ToString()));
                throw ex;
            }

            return result;
        }
        public async Task<List<DBLogDto>> GetAllDBLogs()
        {
            var result = new List<DBLogDto>();

            try
            {
                IEnumerable<Clean.WinF.Domain.Entities.Log.DBLog> existedDBLogs = null;
                existedDBLogs = _dbLogRepository.Query().OrderByDescending(p => p.TimeStamp).Take(20).ToList();
                if (existedDBLogs != null)
                {
                    foreach (var dbLog in existedDBLogs)
                    {
                        var dbLogDto = new DBLogDto()
                        {
                            Id = dbLog.Id,
                            Exception = dbLog.Exception,
                            RenderedMessage = dbLog.RenderedMessage,
                            Level = dbLog.Level,
                            TimeStamp = dbLog.TimeStamp,
                            Properties = dbLog.Properties
                        };
                        result.Add(dbLogDto);
                    }
                }
            }
            catch (Exception ex)
            {
                Serilog.Log.Error(string.Concat("GetAllDBLogs() ", ex.ToString(), Environment.NewLine, "{@CustomValue}", RegistryKeyConstants.ProductName));
                throw ex;
            }
            return result;
        }
    }
}
