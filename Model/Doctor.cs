using System;

namespace HealthHistory.Model
{
    public class Doctor :Auditable
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public HealthRecord HealthRecord { get; set; }



    }
}
