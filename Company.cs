using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientRegistration.Data.Entity
{
    public class Company : Base
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string GLECODE { get; set; }
        public string ShowName { get; set; }
        public string SidatCustomerID { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime WEF { get; set; }
        public int PatientCategoryID { get; set; }
        public virtual PatientCategory PatientCategory { get; set; }

    }
}
