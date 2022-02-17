using HealthHistory.Context;
using HealthHistory.DTOs;
using HealthHistory.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthHistory.Services
{
    public class HealthRecordRepository : IHealthRecordRepositories
    {
        private readonly MedicDBContext medicDBContext;

        public HealthRecordRepository(MedicDBContext medicDBContext)
        {
            this.medicDBContext = medicDBContext;
        }
        public  void CreateRecord(Guid patientId, HealthRecord healthRecord)
        {
            

            medicDBContext.HealthRecords.Add(healthRecord);
            medicDBContext.SaveChanges();
        }

        public IEnumerable<HealthRecord> GetHealthRecords()
        {
           return  medicDBContext.HealthRecords.ToList();
        }

        public IEnumerable<HealthRecord> GetRecord(Guid patientId)
        {
           
            return medicDBContext.HealthRecords.Where(o => o.PatientId == patientId).ToList();
        }

        public bool Save()
        {
            return (medicDBContext.SaveChanges() >= 0);
        }

        
    }
}
