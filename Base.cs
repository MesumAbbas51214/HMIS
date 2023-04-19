using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PatientRegistration.Data.Entity
{
    public class Base
    {
        public long Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public long CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public long? DeletedBy { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
