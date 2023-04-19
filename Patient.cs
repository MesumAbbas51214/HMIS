using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientRegistration.Data.Entity
{
    public class Patient : Base
    {
        public Patient()
        {
            this.Country = new Country();
            this.Company = new Company();
            this.City = new City();
            this.PatientCategory = new PatientCategory();
        }

        public string Name { get; set; }
        public string RegNo { get; set; }
        public string Prefix { get; set; }
        public string RelationName { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string OtherNo { get; set; }
        public string EmailAddress { get; set; }
        public string DOB { get; set; }
        public string BirthPlace { get; set; }
        public string CNIC { get; set; }
        public int PatientStatusBy { get; set; }
        public DateTime PatientStatusOn { get; set; }
        public int PatientStatusComputerID { get; set; }
        public string Remarks { get; set; }
        public string OnHoldRemarks { get; set; }
        public int BloodGroup { get; set; }
        public int OccupationID { get; set; }
        public int BranchID { get; set; }
        public int ReligionID { get; set; }
        public int NationalityID { get; set; }
        public int MaritalStatusID { get; set; }
        public int RegistrationTypeID { get; set; }
        public int FileStatusID { get; set; }
        public int GenderID { get; set; }
        public int RelationTitleID { get; set; }
        public int? CountryID { get; set; }
        public virtual Country Country { get; set; }
        public int? CompanyID { get; set; }
        public virtual Company Company { get; set; }
        public int? CityID { get; set; }
        public virtual City City { get; set; }
        public int? PatientCategoryID { get; set; }
        public virtual PatientCategory PatientCategory { get; set; }

    }
}
