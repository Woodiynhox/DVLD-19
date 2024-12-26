using PeopleMangDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleMangDataLayer;


namespace PeopleManagBusinessLayer
{
    public class clsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountry(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }


        public static clsCountry FindCountry(string CountryName)
        {
            int countryID = -1;

            if (clsManagePeopleData.GetCountryInfoByName(CountryName, ref countryID))
            {
                return new clsCountry(countryID, CountryName);
            }

            return null; // Return null if the country is not found
        }

    }
}
