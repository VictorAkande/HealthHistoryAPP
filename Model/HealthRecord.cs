using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthHistory.Model
{
    public class HealthRecord :Auditable
    {
        public Guid Id { get; set; }
        public string Diagnosis { get; set; }
        public String TreatmentAdministered { get; set; }

        Patient Patient { get; set; }
      
        [ForeignKey("PatientID")]
        public Guid PatientId { get; set; }






    }
}
