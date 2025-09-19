using Microsoft.EntityFrameworkCore;
using InfrastructureFaultAPI.Data;
using InfrastructureFaultAPI.Models;


namespace InfrastructureFaultAPI.Services
{
    public class FaultReportService : IFaultReportService
    {
        public readonly FaultReportContext _context;

        public FaultReportService(FaultReportContext context) { _context = context; }

        public async Task<IEnumerable<FaultReport>> GetAllFaultReportsAsync()
        {
            return await _context.FaultReports
                .OrderByDescending(f => f.ReportedAt)
                .ToListAsync();
        }
        public async Task<FaultReport> CreateFaultReportAsync(CreateFaultReportDto createDto)
        {
            var faultReport = new FaultReport
            {
                FaultType = createDto.FaultType,
                Description = createDto.Description,
                Latitude = createDto.Latitude,
                Longitude = createDto.Longitude,
                ReportedAt = DateTime.UtcNow
            };

            _context.FaultReports.Add(faultReport);

            await _context.SaveChangesAsync();

            return faultReport;
        }
    }
}
