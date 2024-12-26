using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using PeopleMangDataLayer;


namespace PeopleManagBusinessLayer
{
    public class clsPeople
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int ID { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string NationalNo { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string Gender { set; get; }
        public string Phone { set; get; }

        public string Email { set; get; }
       
        public int CountryID { set; get; }

        public string ImagePath { set; get; }

        public string Address { set; get; }


        public clsPeople() {

            this.ID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.NationalNo = "";
            this.Gender = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now;
            this.CountryID = -1;
            this.ImagePath = "";

            Mode = enMode.AddNew;


        }


       private clsPeople (int iD, string firstName, string secondName, string thirdName, string lastName, string nationalNo, DateTime dateOfBirth, 
            string gender, string phone, string email, int countryID, string imagePath, string address)
        {
            
            ID = iD;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            NationalNo = nationalNo;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Phone = phone;
            Email = email;
            CountryID = countryID;
            ImagePath = imagePath;
            Address = address;

            Mode = enMode.Update;
        }


        private bool _AddNewContact()
        {
            //call DataAccess Layer 

            this.ID = clsManagePeopleData.AddNewContact(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalNo,
                this.DateOfBirth, this.Gender, this.Phone, this.Email, this.CountryID, this.ImagePath, this.Address);

            return (this.ID != -1);
        }


        private bool _UpdateContact()
        {
            //call DataAccess Layer 

           return (clsManagePeopleData.UpdateContact(this.ID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalNo,
                this.DateOfBirth, this.Gender, this.Phone, this.Email, this.CountryID, this.ImagePath, this.Address));

           
        }

        public static DataTable GetAllPeople()
        {

            return clsManagePeopleData.GetAllPeople();

        }

        public static DataTable GetAllCountries()
        {

            return clsManagePeopleData.GetAllCountries();

        }


        public static clsPeople Find(int ID)
        {

            string firstName = "", secondName = "", thirdName = "", lastName = "", nationalNo = "", email = "", phone = "", address = "", imagePath = "", gender = "";
            DateTime dateOfBirth = DateTime.Now;
            int countryID = -1;


            if (clsManagePeopleData.GetPersonInfoByID( ID, ref  firstName, ref  secondName, ref  thirdName, ref  lastName,
            ref  nationalNo, ref  dateOfBirth, ref  gender, ref  phone, ref  email, ref  countryID, ref  imagePath, ref  address))

                return new clsPeople( ID,  firstName,  secondName,  thirdName,  lastName,  nationalNo,
                     dateOfBirth,  gender,  phone,  email,  countryID, imagePath, address);
            else
                return null;
        }


        public static bool isNationalUsed(string NationalNo)
        {
            if (!clsManagePeopleData.IsNationalUsed(NationalNo))
            {
                return false;
            }
            return true;
        }


        


        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewContact())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateContact();

            }

            return false;
        }



        public static bool DeletePerson(int ID)
        {
            return clsManagePeopleData.DeletePerson(ID);
        }

        public static bool isPersonExist(int ID)
        {
            return clsManagePeopleData.IsPersonExist(ID);
        }



    }
    }
