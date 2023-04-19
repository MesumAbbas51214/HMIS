using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PatientRegistration.Data.DBContext;
using PatientRegistration.Data.Entity;
using PatientRegistration.Settings;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PatientRegistration.Extensions
{
    public static class SeedExtension
    {
        public static void Seed(this PatientDBContext context, AppSettings appsettings)
        {


            #region PATIENT CATEGORY SECTION

            if (context.PatientCategory.Count() == 0)
            {

                List<PatientCategory> toAddPatientCategory = new List<PatientCategory>();
                toAddPatientCategory.AddRange(new List<PatientCategory>() {
                     new PatientCategory()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Private",
                         Code = "4"
                     },
                     new PatientCategory()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Sponsored",
                         Code = "6"

                     },
                     new PatientCategory()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Company",
                         Code = "7"

                     }
                });

                context.PatientCategory.AddRange(toAddPatientCategory);
                context.SaveChanges();
            }

            if (context.Company.Count() == 0)
            {

                List<Company> toAddCompany = new List<Company>();
                toAddCompany.AddRange(new List<Company>() {
                     new Company()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "A.D.B.P.",
                         Code = "ADBP",
                         GLECODE="12020014",
                         ShowName= "A.D.B.P.",
                         SidatCustomerID = "-1",
                         PatientCategoryID = 3,
                         Address = "",
                         Phone = "",
                         WEF = Convert.ToDateTime("2012-09-27 09:54:00")



                     },
                     new Company()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Sponsor",
                         Code = "CSM",
                         GLECODE="20200042",
                         ShowName= "CH. SHER MOHAMMAD",
                         SidatCustomerID = "-1",
                         PatientCategoryID = 2,
                         Address = "PWA (SPONSOR PATIENTS)",
                         Phone = "",
                         WEF =Convert.ToDateTime("2012-09-27 09:54:00")


                     },
                     new Company()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "United Bank Ltd",
                         Code = "UBL",
                         GLECODE="12020002",
                         ShowName= "United Bank Ltd",
                         SidatCustomerID = "1010034",
                         PatientCategoryID = 3,
                         Address = "",
                         Phone = "",
                         WEF = Convert.ToDateTime("2012-09-27 09:54:00")

                     },
                      new Company()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Sponsor",
                         Code = "ATRZ",
                         GLECODE="12020004",
                         ShowName= "ATEED RIAZ and Co.",
                         SidatCustomerID = "-1",
                         PatientCategoryID = 2,
                         Address = "",
                         Phone = "",
                         WEF = Convert.ToDateTime("2012-09-27 09:54:00")

                     }
                });

                context.Company.AddRange(toAddCompany);
                context.SaveChanges();







            }

            #endregion

            #region PATIENT DETAIL

            if (context.Country.Count() == 0)
            {

                List<Country> toAddCountry = new List<Country>();
                toAddCountry.AddRange(new List<Country>()
                {

                               new Country() {
                                  Code ="PAK",
                                  Name ="Pakistan"
                               },
                               new Country() {
                                  Code ="USA",
                                  Name ="United States of America"
                               },
                               new Country() {
                                  Code ="UK",
                                  Name ="United Kingdom"
                               },
                               new Country() {
                                  Code ="IND",
                                  Name ="India"
                               },
                               new Country() {
                                  Code ="UAE",
                                  Name ="United Arab Emirates"
                               },
                               new Country() {
                                  Code ="IRN",
                                  Name ="Iran"
                               },
                               new Country() {
                                  Code ="IRQ",
                                  Name ="Iraq"
                               },
                               new Country() {
                                  Code ="JPN",
                                  Name ="Japan"
                               },
                               new Country() {
                                  Code ="CHI",
                                  Name ="China"
                               },
                               new Country() {
                                  Code ="KSA",
                                  Name ="Saudi Arabia"
                               },
                               new Country() {
                                  Code ="AFG",
                                  Name ="Afghanistan"
                               },
                               new Country() {
                                  Code ="BAN",
                                  Name ="Bangladesh"
                               },
                               new Country() {
                                  Code ="MAL",
                                  Name ="Malaysia"
                               },
                               new Country() {
                                  Code ="INDO",
                                  Name ="Indonesia"
                               },
                               new Country() {
                                  Code ="SYR",
                                  Name ="Syria"
                               },
                               new Country() {
                                  Code ="FRA",
                                  Name ="France"
                               },
                               new Country() {
                                  Code ="GER",
                                  Name ="Germany"
                               },
                               new Country() {
                                  Code ="CAN",
                                  Name ="Canada"
                               },
                               new Country() {
                                  Code ="HOLL",
                                  Name ="Holland"
                               },
                               new Country() {
                                  Code ="AUT",
                                  Name ="Austria"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Australia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Nepal"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="South Afarica"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Sri Lanka"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Kuwait"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="New Zealand"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="West Indies"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Zimbabwe"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Kenya"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Spain"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Norway"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Albania"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Turkey"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Sweden"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Croatia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Italy"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Surbia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Romania"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Ireland"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Algeria"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="American Samoa"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Andorra"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Angola"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Antigua and Barbuda"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Argentina"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Armenia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Aruba"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Azerbaijan"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Bahamas, The"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Bahrain"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Barbados"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Belarus"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Belgium"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Belize"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Benin"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Bermuda"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Bhutan"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Bolivia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Bosnia and Herzegovina"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Botswana"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Brazil"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Brunei"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Bulgaria"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Burkina Faso"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Burundi"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Cambodia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Cameroon"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Cape Verde"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Cayman Islands"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Central African Republi"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Chad"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Channel Islands"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Chile"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Colombia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Comoros"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Congo, Dem. Rep."
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Congo, Rep."
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Costa Rica"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Cte d'Ivoire"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Cuba"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Cyprus"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Czech Republic"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Denmark"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Djibouti"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Dominica"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Dominican Republic"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Ecuador"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Egypt, Arab Rep."
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="El Salvador"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Equatorial Guinea"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Eritrea"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Estonia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Ethiopia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Faeroe Islands"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Fiji"
                               },
                               new Country() {
                                  Code ="FIN",
                                  Name ="Finland"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="French Polynesia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Gabon"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Gambia, The"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Georgia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Ghana"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Greece"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Greenland"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Grenada"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Guam"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Guatemala"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Guinea"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Guinea-Bissau"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Guyana"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Haiti"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Honduras"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Hong Kong, China"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Hungary"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Iceland"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Iran, Islamic Rep."
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Isle of Man"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Israel"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Jamaica"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Jordan"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Kazakhstan"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Kiribati"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Korea, Dem. Rep."
                               },
                               new Country() {
                                  Code ="KOR",
                                  Name ="Korea, Rep."
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Kyrgyz Republic"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Lao PDR"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Latvia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Lebanon"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Lesotho"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Liberia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Libya"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Liechtenstein"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Lithuania"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Luxembourg"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Macao, China"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Macedonia, FYR"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Madagascar"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Malawi"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Maldives"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Mali"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Malta"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Marshall Islands"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Mauritania"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Mauritius"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Mayotte"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Mexico"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Micronesia, Fed. Sts."
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Moldova"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Monaco"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Mongolia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Morocco"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Mozambique"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Myanmar"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Namibia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Netherlands"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Netherlands Antilles"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="New Caledonia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Nicaragua"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Niger"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Nigeria"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Northern Mariana Island"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Oman"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Palau"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Panama"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Papua New Guinea"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Paraguay"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Peru"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Philippines"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Poland"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Portugal"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Puerto Rico"
                               },
                               new Country() {
                                  Code ="QTR",
                                  Name ="Qatar"
                               },
                                  new Country() {
                                      Code ="XXX",
                                      Name ="Russian Federation"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Rwanda"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Samoa"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="San Marino"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="So Tom and Principe"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Senegal"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Serbia and Montenegro"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Seychelles"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Sierra Leone"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Singapore"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Slovak Republic"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Slovenia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Solomon Islands"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Somalia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="South Africa"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="St. Kitts and Nevis"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="St. Lucia "
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="St. Vincent and the Gre"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Sudan"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Suriname"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Swaziland"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Switzerland"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Syrian Arab Republic"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Tajikistan"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Tanzania"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Thailand"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Timor-Leste"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Togo"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Tonga"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Trinidad and Tobago"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Tunisia"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Turkmenistan"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Uganda"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Ukraine"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Uruguay"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Uzbekistan"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Vanuatu"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Venezuela, RB "
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Vietnam"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Virgin Islands (U.S.)"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="West Bank and Gaza"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Yemen, Rep."
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Zambia "
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Ukrain"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Taiwan"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Switzerland"
                               },
                               new Country() {
                                  Code ="XXX",
                                  Name ="Noshero Feroze"
                               }
                });


                context.Country.AddRange(toAddCountry);
                context.SaveChanges();
            }
            if (context.City.Count() == 0)
            {

                List<City> toAddCity = new List<City>();
                toAddCity.AddRange(new List<City>()
                {

                               new City() {
                                  CountryID = 1,
                                  Code = "ABB",
                                  Name ="Abbottabad"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "ALI",
                                  Name ="Ali Bandar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "ALI",
                                  Name ="Ali Masjid"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "AMI",
                                  Name ="Amir Chah"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "ASK",
                                  Name ="Askole"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "AST",
                                  Name ="Astore"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BAD",
                                  Name ="Baden"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BAG",
                                  Name ="Bagh"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BAG",
                                  Name ="Bagh"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BAH",
                                  Name ="Bahawalnagar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BAH",
                                  Name ="Bahawalpur"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BAN",
                                  Name ="Banda Daud Shah"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BAN",
                                  Name ="Bannu"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BAT",
                                  Name ="Batagram"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BAZ",
                                  Name ="Bazdar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BEL",
                                  Name ="Bela"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BEL",
                                  Name ="Bellpat"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BES",
                                  Name ="Besham"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BHA",
                                  Name ="Bhalwal"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BHI",
                                  Name ="Bhimber"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BUN",
                                  Name ="Buner"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BUN",
                                  Name ="Bunji (or Bungi)"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BUR",
                                  Name ="Burj"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "CHA",
                                  Name ="Chachro"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "CHA",
                                  Name ="Chagai"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "CHA",
                                  Name ="Chah Sandan"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "CHA",
                                  Name ="Chakku"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "CHA",
                                  Name ="Chaman"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "CHA",
                                  Name ="Charsadda"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "CHA",
                                  Name ="Charsadda"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "CHH",
                                  Name ="Chhatr"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "CHI",
                                  Name ="Chilas"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "CHI",
                                  Name ="Chillinji"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "CHI",
                                  Name ="Chitral"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "DAD",
                                  Name ="Dadu"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "DAL",
                                  Name ="Dalbandin"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "DAR",
                                  Name ="Dargai"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "DAR",
                                  Name ="Darra Adam Khel"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "DAS",
                                  Name ="Daska"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "DER",
                                  Name ="Dera Bugti"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "DER",
                                  Name ="Dera Ghazi Khan"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "DER",
                                  Name ="Dera Ismail Khan"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "DHA",
                                  Name ="Dhana Sar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "DIG",
                                  Name ="Digri"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "DIP",
                                  Name ="Diplo"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "DIW",
                                  Name ="Diwana"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "DOK",
                                  Name ="Dokri"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "DRO",
                                  Name ="Drosh"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "DUK",
                                  Name ="Duki"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "DUS",
                                  Name ="Dushi"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "DUZ",
                                  Name ="Duzab"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "FAI",
                                  Name ="Faisalabad"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GAD",
                                  Name ="Gadra"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GAJ",
                                  Name ="Gajar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GAK",
                                  Name ="Gakuch"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GAN",
                                  Name ="Gandava"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GAR",
                                  Name ="Garhi Khairo"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GAR",
                                  Name ="Garruck"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GHA",
                                  Name ="Ghanche"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GHA",
                                  Name ="Ghauspur"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GHA",
                                  Name ="Ghazluna"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GHI",
                                  Name ="Ghizer"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GHO",
                                  Name ="Ghotki"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GIL",
                                  Name ="Gilgit"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GIR",
                                  Name ="Girdan"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GUJ",
                                  Name ="Gujranwala"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GUJ",
                                  Name ="Gujrat"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GUL",
                                  Name ="Gulistan"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GWA",
                                  Name ="Gwadar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "GWA",
                                  Name ="Gwash"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "HAB",
                                  Name ="Hab Chauki"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "HAL",
                                  Name ="Hala"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "HAN",
                                  Name ="Hangu"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "HAR",
                                  Name ="Haripur"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "HAR",
                                  Name ="Harnai"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "HAS",
                                  Name ="Hasilpur"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "HAV",
                                  Name ="Haveli Lakha"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "HIN",
                                  Name ="Hinglaj"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "HOS",
                                  Name ="Hoshab"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "HYD",
                                  Name ="Hyderabad"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "ISH",
                                  Name ="Ishkuman"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "ISL",
                                  Name ="Islamabad"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "ISL",
                                  Name ="Islamkot"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "ISP",
                                  Name ="Ispikan"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "JAC",
                                  Name ="Jacobabad"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "JAM",
                                  Name ="Jamesabad"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "JAM",
                                  Name ="Jamrud"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "JAM",
                                  Name ="Jamshoro"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "JAN",
                                  Name ="Jandola"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "JAN",
                                  Name ="Janghar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "JAT",
                                  Name ="Jati (Mughalbhin)"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "JHA",
                                  Name ="Jhal"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "JHA",
                                  Name ="Jhal Jhao"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "JHA",
                                  Name ="Jhang"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "JHA",
                                  Name ="Jhatpat"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "JHE",
                                  Name ="Jhelum"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "JHU",
                                  Name ="Jhudo"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "JIW",
                                  Name ="Jiwani"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "JUN",
                                  Name ="Jungshahi"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAL",
                                  Name ="Kalam"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAL",
                                  Name ="Kalandi"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAL",
                                  Name ="Kalat"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAM",
                                  Name ="Kamararod"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAN",
                                  Name ="Kanak"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAN",
                                  Name ="Kandhura"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAN",
                                  Name ="Kandi"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAN",
                                  Name ="Kandiaro"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAN",
                                  Name ="Kanpur"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAP",
                                  Name ="Kapip"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAP",
                                  Name ="Kappar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KHI",
                                  Name ="Karachi"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAR",
                                  Name ="Karak"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAR",
                                  Name ="Karimabad (Hunza)"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAR",
                                  Name ="Karodi"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAS",
                                  Name ="Kashmor"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAS",
                                  Name ="Kasur"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAT",
                                  Name ="Katuri"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KET",
                                  Name ="Keti Bandar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KHA",
                                  Name ="Khairpur"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KHA",
                                  Name ="Khaplu"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KHA",
                                  Name ="Kharan"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KHO",
                                  Name ="Khokhropur"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KHO",
                                  Name ="Khora"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KHU",
                                  Name ="Khushab (Jauharabad)"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KHU",
                                  Name ="Khuzdar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KIK",
                                  Name ="Kikki"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KLU",
                                  Name ="Klupro"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KOH",
                                  Name ="Kohan"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KOH",
                                  Name ="Kohat"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KOH",
                                  Name ="Kohistan"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KOH",
                                  Name ="Kohlu"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KOR",
                                  Name ="Korak"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KOR",
                                  Name ="Korangi"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KOT",
                                  Name ="Kot Sarae"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KOT",
                                  Name ="Kotli"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KOT",
                                  Name ="Kotri"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "LHR",
                                  Name ="Lahore"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "LAH",
                                  Name ="Lahri"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "LAK",
                                  Name ="Lakki Marwat"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "LAN",
                                  Name ="Landi Kotal"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "LAR",
                                  Name ="Larkana"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "LAS",
                                  Name ="Lasbela"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "LAT",
                                  Name ="Latamber"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "LIA",
                                  Name ="Liari"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "LOR",
                                  Name ="Loralai"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "LOW",
                                  Name ="Lower Dir"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "LUN",
                                  Name ="Sweden Lend"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MAC",
                                  Name ="Mach"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MAD",
                                  Name ="Madyan"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MAL",
                                  Name ="Malakand"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MAN",
                                  Name ="Mand"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MAN",
                                  Name ="Manguchar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MAN",
                                  Name ="Mansehra"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MAR",
                                  Name ="Mardan"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MAS",
                                  Name ="Mashki Chah"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MAS",
                                  Name ="Maslti"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MAS",
                                  Name ="Mastuj"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MAS",
                                  Name ="Mastung"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MAT",
                                  Name ="Mathi"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MAT",
                                  Name ="Matiari"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MEH",
                                  Name ="Mehar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MEK",
                                  Name ="Mekhtar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MER",
                                  Name ="Merui"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MIA",
                                  Name ="Mianez"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MIA",
                                  Name ="Mianwali"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MIR",
                                  Name ="Miram Shah"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MIR",
                                  Name ="Mirpur"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MIR",
                                  Name ="Mirpur Batoro"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MIR",
                                  Name ="Mirpur Khas"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MIR",
                                  Name ="Mirpur Sakro"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MIS",
                                  Name ="Misgar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MIT",
                                  Name ="Mithi"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MON",
                                  Name ="Mongora"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MOR",
                                  Name ="Moro"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MUL",
                                  Name ="Multan"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MUR",
                                  Name ="Murgha Kibzai"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MUR",
                                  Name ="Muridke"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MUS",
                                  Name ="Musa Khel Bazar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "MUZ",
                                  Name ="Muzaffarabad"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "NAG",
                                  Name ="Nagar Parkar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "NAG",
                                  Name ="Nagha Kalat"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "NAL",
                                  Name ="Nal"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "NAO",
                                  Name ="Naokot"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "NAS",
                                  Name ="Nasirabad"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "NAU",
                                  Name ="Nauroz Kalat"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "NAU",
                                  Name ="Naushara"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "NAW",
                                  Name ="Nawabshah"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "NAZ",
                                  Name ="Nazimabad"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "NOW",
                                  Name ="Nowshera"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "NUR",
                                  Name ="Nur Gamma"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "NUS",
                                  Name ="Nushki"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "NUT",
                                  Name ="Nuttal"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "OKA",
                                  Name ="Okara"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "ORM",
                                  Name ="Ormara"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "PAH",
                                  Name ="Paharpur"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "PAL",
                                  Name ="Palantuk"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "PAN",
                                  Name ="Panjgur"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "PAR",
                                  Name ="Parachinar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "PAS",
                                  Name ="Pasni"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "PES",
                                  Name ="Peshawar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "PIH",
                                  Name ="Piharak"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "PIR",
                                  Name ="Pirmahal"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "PIS",
                                  Name ="Pishin"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "POK",
                                  Name ="Pokran"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "QAM",
                                  Name ="Qambar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "QAM",
                                  Name ="Qamruddin Karez"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "QAZ",
                                  Name ="Qazi Ahmad"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "QIL",
                                  Name ="Qila Abdullah"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "QIL",
                                  Name ="Qila Ladgasht"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "QIL",
                                  Name ="Qila Safed"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "QIL",
                                  Name ="Qila Saifullah"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "QUE",
                                  Name ="Quetta"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "RAB",
                                  Name ="Rabwah"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "RAH",
                                  Name ="Rahim Yar Khan"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "RAK",
                                  Name ="Rakhni"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "RAN",
                                  Name ="Ranipur"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "RAT",
                                  Name ="Ratodero"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "RAW",
                                  Name ="Rawalpindi"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "ROB",
                                  Name ="Robat Thana"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "ROD",
                                  Name ="Rodkhan"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "ROH",
                                  Name ="Rohri"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SAD",
                                  Name ="Sadiqabad"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SAF",
                                  Name ="Safdar Abad -- (Dhaban Sin"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SAH",
                                  Name ="Sahiwal"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SAI",
                                  Name ="Saidu Sharif"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SAI",
                                  Name ="Saindak"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SAK",
                                  Name ="Sakrand"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SAN",
                                  Name ="Sanjawi"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SAR",
                                  Name ="Sargodha"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SAR",
                                  Name ="Saruna"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SHA",
                                  Name ="Shabaz Kalat"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SHA",
                                  Name ="Shadadkhot"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SHA",
                                  Name ="Shahbandar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SHA",
                                  Name ="Shahpur"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SHA",
                                  Name ="Shangla"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SHA",
                                  Name ="Sharam Jogizai"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SHE",
                                  Name ="Sheikhupura"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SHI",
                                  Name ="Shikarpur"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SHI",
                                  Name ="Shimshal"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SHI",
                                  Name ="Shingar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SHO",
                                  Name ="Shorap"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SIA",
                                  Name ="Sialkot"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SIB",
                                  Name ="Sibi"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SKA",
                                  Name ="Skardu"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SON",
                                  Name ="Sonmiani"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SPE",
                                  Name ="Spezand"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SPI",
                                  Name ="Spintangi"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SUI",
                                  Name ="Sui"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SUJ",
                                  Name ="Sujawal"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SUK",
                                  Name ="Sukkur"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SUN",
                                  Name ="Suntsar"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SUR",
                                  Name ="Surab"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SWA",
                                  Name ="Swabi"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SWA",
                                  Name ="Swat"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "TAN",
                                  Name ="Tando Adam"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "TAN",
                                  Name ="Tando Bago"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "TAN",
                                  Name ="Tangi"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "TAN",
                                  Name ="Tank"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "TAR",
                                  Name ="Tar Ahamd Rind"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "THA",
                                  Name ="Thalo"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "THA",
                                  Name ="Thatta"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "TOB",
                                  Name ="Toba Tek Singh"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "TOR",
                                  Name ="Torkham"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "TUJ",
                                  Name ="Tujal"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "TUM",
                                  Name ="Tump"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "TUR",
                                  Name ="Turbat"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "UMA",
                                  Name ="Umarao"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "UMA",
                                  Name ="Umarkot"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "UPP",
                                  Name ="Upper Dir"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "UTH",
                                  Name ="Uthal"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "VEI",
                                  Name ="Veirwaro"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "VIR",
                                  Name ="Virawah"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "VIT",
                                  Name ="Vitakri"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "WAD",
                                  Name ="Wad"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "WAH",
                                  Name ="Wah Cantt"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "WAN",
                                  Name ="Wana"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "WAR",
                                  Name ="Warah"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "WAS",
                                  Name ="Washap"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "WAS",
                                  Name ="Wasjuk"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "WAZ",
                                  Name ="Wazirabad"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "YAK",
                                  Name ="Yakmach"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "ZHO",
                                  Name ="Zhob"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SIN",
                                  Name ="Sindh"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "INT",
                                  Name ="Interior Sindh"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "K.P",
                                  Name ="K.P.K (Khaber Pakhtoon Kha)"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "SIN",
                                  Name ="Sindh"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "AZA",
                                  Name ="Azad Kashmir"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "KAS",
                                  Name ="Kashmir"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BAL",
                                  Name ="Balochistan"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "PUN",
                                  Name ="Punjab"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "IRA",
                                  Name ="Iran"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "HYD",
                                  Name ="Hyderabad"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "BANG",
                                  Name ="Bangladesh"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "NFE",
                                  Name ="Noshero Feroz"
                               },
                               new City() {
                                  CountryID = 1,
                                  Code = "CHK",
                                  Name ="chakwal"
                               }

                });
                context.City.AddRange(toAddCity);
                context.SaveChanges();
            }
                #endregion

                #region Registration Section
                if (context.Relation.Count() == 0)
            {

                List<Relation> toAddRelation = new List<Relation>();
                toAddRelation.AddRange(new List<Relation>() {
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Not Specified",
                         Code = "RANOTS"
                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Father",
                         Code = "RAFATH"

                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Mother",
                         Code = "RAMOTH"

                     },
                      new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Brother",
                         Code = "RABRO"
                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Sister",
                         Code = "RASIST"

                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Son",
                         Code = "RASON"

                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Daughter",
                         Code = "RADOGT"
                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Husband",
                         Code = "RAHUSB"

                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Wife",
                         Code = "RAWIFE"

                     },
                      new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Brother In Law",
                         Code = "RABRLOW"
                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Son In Law",
                         Code = "RASONLO"

                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Uncle",
                         Code = "RAUNCLE"

                     },
                      new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Aunt",
                         Code = "RAAUNT"
                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Friend",
                         Code = "RAFRID"

                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Other",
                         Code = "RAOTHER"

                     },
                      new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Grand Father",
                         Code = "RAGRFAT"
                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Father In Law",
                         Code = "RAFATIN"

                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Sister In Law",
                         Code = "RASISLA"

                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Cousin",
                         Code = "RACOUSI"
                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Nephew",
                         Code = "RANEPHW"

                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         Name = "Niece",
                         Code = "RANIECE"

                     },
                      new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Daugter In Law",
                         Code = "RADIL    "
                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Mother In Law",
                         Code = "RALMOTH"

                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Grand Daughter",
                         Code = "RAGDOTE"

                     },  new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Grand Son",
                         Code = "RAGSON"
                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Self",
                         Code = "RASELF"

                     },
                     new Relation()
                     {

                         CreatedBy = 0,
                         //CreatedOn = DateTime.Now,
                         Name = "Grand Mother",
                         Code = "RAGMOTHER"

                     }

                });

                context.Relation.AddRange(toAddRelation);
                context.SaveChanges();


            }
            #endregion

        }
    }
}
