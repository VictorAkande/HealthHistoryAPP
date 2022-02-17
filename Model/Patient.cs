using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthHistory.Model
{
    public class Patient : Auditable
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NIN { get; set; }
        public string Address { get; set; }
        public ICollection<HealthRecord> HealthRecords { get; set; } 

    }
}
