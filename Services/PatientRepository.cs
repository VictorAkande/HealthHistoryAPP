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

        public void CreatePatient(Patient patient)
        {
            //var Patient = medicDBContext.Patients.FindAsync(patient.Id);
            if (patient == null)
            {
                 throw new ArgumentNullException(nameof(patient));
            }

            medicDBContext.Patients.Add(patient);
            medicDBContext.SaveChanges();

        }

        public Patient GetPatient(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Patient> GetPatients()
        {
            return medicDBContext.Patients.ToList();
        }


        public  bool Save()
        {
            return (medicDBContext.SaveChanges() >= 0);
        }

      
    }
}
