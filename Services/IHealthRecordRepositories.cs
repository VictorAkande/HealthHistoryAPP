using HealthHistory.Model;

namespace HealthHistory.Services
{
    public interface IHealthRecordRepositories
    {
        void CreatePatient(Patient patient);
    }
}
