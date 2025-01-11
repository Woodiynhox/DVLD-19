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



    }
}
