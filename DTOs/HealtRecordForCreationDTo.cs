using HealthHistory.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthHistory.DTOs
{
    public class HealtRecordForCreationDTo
    {
        public Guid Id { get; set; }
        public string Diagnosis { get; set; }
        public String TreatmentAdministered { get; set; }

        public Guid PatientId { get; set; }
    }
}
