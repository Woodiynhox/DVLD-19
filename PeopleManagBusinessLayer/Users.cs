using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleMangDataLayer;

namespace PeopleManagBusinessLayer
{
    public class clsUsers
    {
        public int Id { get; set; } 
        public string username {  get; set; }
        public string password { get; set; }
        public string isActive { get; set; }


        public clsUsers() { }

        public clsUsers(int Id, string username, string isActive) { 
                    
            this.Id = Id;

            this.username = username;
        
            this.isActive = isActive;
        
        }


        public static bool isActiveUser(string username)
        {
            return (clsManagePeopleData.IsActiveUser(username));
        }


        public static bool IsValidUser(string username, string password)
        {
            return (clsManagePeopleData.IsValidUser(username, password));
        }

        public static DataTable GetAllUsers()
        {

            return clsManagePeopleData.getAllUsers();

        }


        public static clsUsers Find(int ID)
        {

            string username = "";
            string isActive = "";


            if (clsManagePeopleData.GetUserInfoByID(ID, ref username, ref isActive))
                
                return new clsUsers(ID, username, isActive);
            else
                return null;
        }

        public static clsUsers Find(string username)
        {
            int userID = -1;
            string isActive = "";

            if (clsManagePeopleData.GetUserInfoByName(username, ref userID, ref  isActive))
            {
                return new clsUsers(userID, username, isActive);
            }

            return null; // Return null if the username is not found
        }

        public static bool saveNewPassword(string username, string password)
        {
            return (clsManagePeopleData.SaveNewPassword(username, password));
        }



        public static int FindPersonIDByUserID(int userID)
        {
            int personID = -1;

            if (clsManagePeopleData.GetPersonIDByUserID(userID, ref personID))
            {
                return personID;
            }

            return -1; // Return -1 if no PersonID is found
        }



    }
}
