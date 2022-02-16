using HealthHistory.Context;
using HealthHistory.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthHistory.Services
{
    public class PatientRepository : IPatientRepositories
    {
        private readonly MedicDBContext medicDBContext;

        public PatientRepository( MedicDBContext medicDBContext)
        {
            this.medicDBContext = medicDBContext;
        }
        public Patient GetPatient(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Patient> GetPatients()
        {
            return medicDBContext.Patients.ToList();
        }
    }
}
