using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Systems.Log
{
    public interface IDBLogQueryServices
    {
        Task<DBLogDto> GetDBLogById(long id);
        Task<List<DBLogDto>> GetDBLogByConditions(string appName, string logLevel, DateTime from, DateTime to);
        Task<List<DBLogDto>> GetAllDBLogs();
    }
}
