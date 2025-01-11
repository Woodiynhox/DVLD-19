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
    }
}
