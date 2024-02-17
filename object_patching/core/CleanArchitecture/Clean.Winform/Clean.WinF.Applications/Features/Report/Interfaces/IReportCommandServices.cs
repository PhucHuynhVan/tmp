using Clean.WinF.Applications.Features.Report.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Report.Interfaces
{
    public interface IReportCommandServices
    {
        Task<List<ReportDto>> CreateNewReport(ReportDto addedReport);
        Task<ReportDto> UpdateReport(ReportDto updateReport);
        Task<List<ReportDto>> DeleteReport(ReportDto deletedReport);
    }
}
