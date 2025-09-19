using InfrastructureFaultAPI.Models;

namespace InfrastructureFaultAPI.Services
{
    public interface IFaultReportService
    {
        Task<IEnumerable<FaultReport>> GetAllFaultReportsAsync();
        Task<FaultReport> CreateFaultReportAsync(CreateFaultReportDto createDto);
    }
}
