using Clean.WinF.Applications.Features.Report.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Clean.WinF.Applications.Features.Report.Interfaces
{
    public interface IReportQueryServices
    {
        Task<ReportDto> GetReportById(int id);
        Task<List<ReportDto>> GetReportByName(string name);
        Task<List<ReportDto>> GetAllReports();
        Task<IEnumerable<ReportDto>> ListAllAsync();
    }
}
