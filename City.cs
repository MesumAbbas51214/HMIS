using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientRegistration.Data.Entity
{
    public class City : Base
    {
        public City()
        {
            this.Country = new Country();
        }

        public string Name { get; set; }
        public string Code { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
    }
}
