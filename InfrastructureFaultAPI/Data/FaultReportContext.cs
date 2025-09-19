using InfrastructureFaultAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureFaultAPI.Data
{
    public class FaultReportContext : DbContext
    {
        public FaultReportContext(DbContextOptions<FaultReportContext> options) : base(options) { }

        public DbSet<FaultReport> FaultReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FaultReport>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FaultType).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).IsRequired().HasMaxLength(500);
                entity.Property(e => e.Latitude).IsRequired();
                entity.Property(e => e.Longitude).IsRequired();
                entity.Property(e => e.ReportedAt).IsRequired();
            });
        }
    }
}
