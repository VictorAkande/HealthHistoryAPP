using HealthHistory.Model;
using Microsoft.EntityFrameworkCore;

namespace HealthHistory.Context
{
    public class MedicDBContext : DbContext
    {
        private readonly DbContextOptions<MedicDBContext> options;

        public MedicDBContext(DbContextOptions<MedicDBContext> options) :base(options)
        {
            this.options = options;
        }

        public DbSet<HealthRecord> HealthRecords { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
