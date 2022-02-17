using HealthHistory.Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace HealthHistory.Services
{
    public interface IPatientRepositories
    {
        IEnumerable<Patient> GetPatients();
        Patient GetPatient(Guid id);

        void CreatePatient(Patient patient);

         bool Save();

    }
}
