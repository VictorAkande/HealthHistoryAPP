using System;

namespace HealthHistory.Model
{
    public class HealthRecord :Auditable
    {
        public Guid Id { get; set; }
        public string Diagnosis { get; set; }
        public String TreatmentAdministered { get; set; }
       


       

        
    }
}
