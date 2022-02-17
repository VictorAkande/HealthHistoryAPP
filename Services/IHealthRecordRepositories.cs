using HealthHistory.DTOs;
using HealthHistory.Model;
using System;
using System.Collections.Generic;

namespace HealthHistory.Services
{
    public interface IHealthRecordRepositories
    {
        IEnumerable<HealthRecord> GetHealthRecords();
        IEnumerable<HealthRecord> GetRecord(Guid patientId);
        void CreateRecord(Guid patientId, HealthRecord healthRecord);
        bool Save();
        //public IEnumerable<HealthRecord> GetRecord(Guid patientId);
    }
}
