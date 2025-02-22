using System;
using System.Data;
using System.Data.SqlClient;

namespace Data_Layer___Applications
{
    public class clsAppDataLayer
    {

        private static void LogError(Exception ex)
        {
            // Replace with proper logging
            Console.WriteLine("Error: " + ex.Message);
        }

        public static DataTable GetAllApplicationsTypes()
        {
            // select * from TestTypes order by TestTypeFees asc
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsAppDataAccessSettings.ConnectionString);

            string query = "select * from ApplicationTypes order by ApplicationFees asc";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                LogError(ex);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }



        public static DataTable GetAllTestTypes()
        {
            // select * from TestTypes order by TestTypeFees asc
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsAppDataAccessSettings.ConnectionString);

            string query = "select * from TestTypes order by TestTypeFees asc";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                LogError(ex);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }


        public static DataTable GetAllLocalDrivingApplications()
        {
            // select * from TestTypes order by TestTypeFees asc
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsAppDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM LocalDrivingLicenseApplications_View";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                LogError(ex);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }



        public static DataTable GetAllClasses()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsAppDataAccessSettings.ConnectionString))
            {
                string query = "SELECT LicenseClassID, ClassName FROM LicenseClasses";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        LogError(ex);
                    }
                }
            }

            return dt;
        }


        public static int AddNewApplication(int applicantPersonID, int userID, int paidFees, short applicantTypeID, short applicantStatus, DateTime applicationDate, DateTime lastStatusDate)
        {
            int applicationID = -1;

            using (SqlConnection connection = new SqlConnection(clsAppDataAccessSettings.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                INSERT INTO Applications
                ([ApplicantPersonID], [ApplicationDate], [ApplicationTypeID], [ApplicationStatus],
                 [LastStatusDate], [PaidFees], [CreatedByUserID])
                VALUES (@applicantPersonID, @applicationDate, @applicationTypeID, @applicantStatus,
                        @lastStatusDate, @paidFees, @userID);
                SELECT SCOPE_IDENTITY();";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@applicantPersonID", applicantPersonID);
                    command.Parameters.AddWithValue("@applicationDate", applicationDate);
                    command.Parameters.AddWithValue("@applicationTypeID", applicantTypeID);
                    command.Parameters.AddWithValue("@applicantStatus", applicantStatus);
                    command.Parameters.AddWithValue("@lastStatusDate", lastStatusDate);
                    command.Parameters.AddWithValue("@paidFees", paidFees);
                    command.Parameters.AddWithValue("@userID", userID);

                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        applicationID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                    LogError(ex);
                }
            }

            return applicationID;
        }



        public static int LocalDrivingLicenseApplications(int applicationID, int licenseClassID)
        {
            int localDrivingLicenseApplicationsID = -1;

            using (SqlConnection connection = new SqlConnection(clsAppDataAccessSettings.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                INSERT INTO LocalDrivingLicenseApplications
                ([ApplicationID], [LicenseClassID])
                VALUES (@applicationID, @licenseClassID);
                SELECT SCOPE_IDENTITY();";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@applicationID", applicationID);
                    command.Parameters.AddWithValue("@licenseClassID", licenseClassID);

                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        localDrivingLicenseApplicationsID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                    LogError(ex);
                }
            }

            return localDrivingLicenseApplicationsID;
        }


        public static bool GetApplicationInfoByApplicationID(
    int localDrivingLicenseApplicationID,
    ref int personID,
    ref string appliedFor,
    ref string createdBy,
    ref string firstName,
    ref string secondName,
    ref string thirdName,
    ref string lastName,
    ref int applicationStatus,
    ref DateTime applicationDate,
    ref DateTime lastStatusDate,
    ref int passedTests)
        {
            Console.WriteLine($"Parameter LocalDrivingLicenseApplicationID: {localDrivingLicenseApplicationID}"); // Log here
            string query = @"
        SELECT 
    Applications.ApplicationID,
    LicenseClasses.ClassName AS AppliedFor,
    Users.UserName AS CreatedBy,
    People.PersonID,
    People.FirstName,
    People.SecondName,
    People.ThirdName,
    People.LastName,
    Applications.ApplicationStatus,
    Applications.ApplicationDate,
    Applications.LastStatusDate,
    COUNT(Tests.TestResult) AS PassedTests
FROM 
    Applications
INNER JOIN 
    LocalDrivingLicenseApplications 
    ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
INNER JOIN 
    LicenseClasses 
    ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
INNER JOIN 
    People 
    ON Applications.ApplicantPersonID = People.PersonID
INNER JOIN 
    Users 
    ON Applications.CreatedByUserID = Users.UserID
LEFT JOIN 
    Tests 
    ON Users.UserID = Tests.CreatedByUserID AND Tests.TestResult = 1
WHERE 
    LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID
GROUP BY 
    Applications.ApplicationID, LicenseClasses.ClassName, Users.UserName, People.PersonID, 
    People.FirstName, People.SecondName, People.ThirdName, People.LastName, 
    Applications.ApplicationStatus, Applications.ApplicationDate, Applications.LastStatusDate;
";

            SqlConnection connection = new SqlConnection(clsAppDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);

            Console.WriteLine($"Parameter LocalDrivingLicenseApplicationID: {localDrivingLicenseApplicationID}");
            //  Console.WriteLine($"SQL Query: {query}");


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Populate values
                    personID = reader["PersonID"] == DBNull.Value ? -1 : Convert.ToInt32(reader["PersonID"]);
                    appliedFor = reader["AppliedFor"] == DBNull.Value ? string.Empty : reader["AppliedFor"].ToString();
                    createdBy = reader["CreatedBy"] == DBNull.Value ? string.Empty : reader["CreatedBy"].ToString();
                    firstName = reader["FirstName"] == DBNull.Value ? string.Empty : reader["FirstName"].ToString();
                    secondName = reader["SecondName"] == DBNull.Value ? string.Empty : reader["SecondName"].ToString();
                    thirdName = reader["ThirdName"] == DBNull.Value ? string.Empty : reader["ThirdName"].ToString();
                    lastName = reader["LastName"] == DBNull.Value ? string.Empty : reader["LastName"].ToString();
                    applicationStatus = reader["ApplicationStatus"] == DBNull.Value ? -1 : Convert.ToInt32(reader["ApplicationStatus"]);
                    applicationDate = reader["ApplicationDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["ApplicationDate"]);
                    lastStatusDate = reader["LastStatusDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["LastStatusDate"]);
                    passedTests = reader["PassedTests"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PassedTests"]);
                    return true;
                }
                else
                {
                    Console.WriteLine("No data found in database.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }


        public static DataTable getAllAppointment()
        {
            // select * from TestTypes order by TestTypeFees asc
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsAppDataAccessSettings.ConnectionString);

            string query = "select TestAppointmentID, AppointmentDate, PaidFees, IsLocked from dbo.TestAppointments_View";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                LogError(ex);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static int scheduleVisionTest(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, int CreatedByUserID)
        {
            int testAppointmentID = -1;

            using (SqlConnection connection = new SqlConnection(clsAppDataAccessSettings.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                 INSERT INTO TestAppointments
                 (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked)
                 VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, 10, @CreatedByUserID, 0);
                 SELECT SCOPE_IDENTITY();";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        testAppointmentID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                    LogError(ex);
                }
                finally
                {
                    connection.Close();
                }
            }

            return testAppointmentID;
        }


        public static bool GetUserInfoByName(string userName, ref int userID, ref string isActive)
        {
            bool isFound = false;

            string query = @"
        SELECT UserID, UserName, IsActive 
        FROM Users 
        WHERE UserName = @userName";

            using (SqlConnection connection = new SqlConnection(clsAppDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userName", userName);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // The record was found
                            isFound = true;

                            userID = reader["UserID"] != DBNull.Value ? Convert.ToInt32(reader["UserID"]) : -1;
                            userName = reader["UserName"] as string ?? string.Empty;
                            isActive = reader["IsActive"] != DBNull.Value && Convert.ToByte(reader["IsActive"]) == 0 ? "No" : "Yes";
                        }
                        else
                        {
                            // No matching record
                            isFound = false;
                            userID = -1;
                            userName = string.Empty;
                            isActive = "Unknown";
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogError(ex);
                    isFound = false;
                    userID = -1;
                    userName = string.Empty;
                    isActive = "Unknown";
                }
            }

            return isFound;
        }



    }

}

