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
        public Patient Patient { get; set; }
        
        public Guid PatientId { get; set; }
       
      
      






    }
}
