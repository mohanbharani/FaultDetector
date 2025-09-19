using System.ComponentModel.DataAnnotations;

namespace InfrastructureFaultAPI.Models
{
    public class FaultReport
    {
        public int Id { get; set; }

        [Required]
        public string FaultType { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        public DateTime ReportedAt { get; set; } = DateTime.UtcNow;
    }

    public class CreateFaultReportDto
    {
        [Required]
        public string FaultType { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }
    }
}
