using InfrastructureFaultAPI.Models;
using InfrastructureFaultAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace InfrastructureFaultAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FaultReportsController : ControllerBase
    {
        private readonly IFaultReportService _faultReportService;
        public FaultReportsController(IFaultReportService faultReportService)
        {
            _faultReportService = faultReportService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FaultReport>>> GetFaultReports()
        {
            var reports = await _faultReportService.GetAllFaultReportsAsync();
            return Ok(reports);
        }

        [HttpPost]
        public async Task<ActionResult<FaultReport>> CreateFaultReport(CreateFaultReportDto createDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var faultReport = await _faultReportService.CreateFaultReportAsync(createDto);
            return CreatedAtAction(nameof(GetFaultReports), new { id = faultReport.Id }, faultReport);
        }
    }
}
