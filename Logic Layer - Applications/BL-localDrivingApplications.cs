using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Data_Layer___Applications;

namespace Logic_Layer___Applications
{
    public class clsBL_localDrivingApplications
    {
    //    private int _applicationID = -1;
        public int ApplicationID { get; set; }
        public int PersonID { get; set; }
        public string AppliedFor { get; set; } 
        public string CreatedBy { get; set; } 
        public string FirstName { get; set; } 
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public int ApplicationStatus { get; set; }
        public int PassedTests { get; set; } 
        public DateTime ApplicationDate { get; set; }
        public DateTime LastStatusDate { get; set; }

        public clsBL_localDrivingApplications() { }


        public clsBL_localDrivingApplications(int applicationID,int personID, string appliedFor, string createdBy, string firstName,
       string secondName, string thirdName, string lastName, int applicationStatus, int passedTests,
       DateTime applicationDate, DateTime lastStatusDate)
        {
            ApplicationID = applicationID;
            PersonID = personID;
            AppliedFor = appliedFor;
            CreatedBy = createdBy;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            ApplicationStatus = applicationStatus;
            PassedTests = passedTests;
            ApplicationDate = applicationDate;
            LastStatusDate = lastStatusDate;
        }

        public static DataTable GetAllLocalDrivingApplications()
        {

            return clsAppDataLayer.GetAllLocalDrivingApplications();

        }

        public static DataTable GetAllClasses()
        {

            return clsAppDataLayer.GetAllClasses();

        }

        public static bool AddNewApplication(DateTime ApplicationDate, int licenseClass, int PaidFees, int UserID, int applicantPersonID)
        {

            int ApplicationID, LocalDrivingLicenseApplicationsID;
            short ApplicantTypeID = 1, ApplicantStatus = 1;
            DateTime LastStatusDate = DateTime.Now;

            ApplicationID = clsAppDataLayer.AddNewApplication(applicantPersonID, UserID, PaidFees, ApplicantTypeID, ApplicantStatus, ApplicationDate, LastStatusDate);

            if (ApplicationID != -1) {

                LocalDrivingLicenseApplicationsID = clsAppDataLayer.LocalDrivingLicenseApplications(ApplicationID, licenseClass);
                
                if (LocalDrivingLicenseApplicationsID != -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
             

            }
            else
            {
                return false;
            }

        }

        public static DataTable getAllAppointment()
        {

            return clsAppDataLayer.getAllAppointment();

        }

        public static clsBL_localDrivingApplications GetApplicationInfoByApplicationID( int applicationID)
        {
            string appliedFor = "";
            int personID = -1;
            string createdBy = "";
            string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";
            int applicationStatus = -1;
            int passedTests = -1;
            DateTime applicationDate = DateTime.Now;
            DateTime lastStatusDate= DateTime.Now;
            bool isDataFound = clsAppDataLayer.GetApplicationInfoByApplicationID(
                            applicationID, ref personID, ref appliedFor, ref createdBy, ref firstName, ref secondName,
                           ref thirdName, ref lastName, ref applicationStatus, ref applicationDate, ref lastStatusDate, ref passedTests);

            if (isDataFound)
            {
                return new clsBL_localDrivingApplications(applicationID, personID, appliedFor, createdBy, firstName,
                    secondName, thirdName, lastName, applicationStatus, passedTests, applicationDate, lastStatusDate);
            }
            else
            {
                // Log or handle the case when no data is found
                Console.WriteLine($"No data found for Application ID: {applicationID}");
                return null;
            }
        }

        public static bool scheduleVisionTest(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, int CreatedByUserID)
        {
            int testAppointmentID = -1;

            testAppointmentID = clsAppDataLayer.scheduleVisionTest(TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, CreatedByUserID);

            if (testAppointmentID != -1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
