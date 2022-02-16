using System;
using System.Collections.Generic;

namespace HealthHistory.Model
{
    public class Patient :Auditable
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NIN { get; set; }
        public string Address { get; set; }
     
        public ICollection<HealthRecord> HealthRecord { get; set; }
            = new List<HealthRecord>();

    }
}
