using PeopleMangDataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Policy;

namespace PeopleMangDataLayer
{
    public class clsManagePeopleData
    {





        public static bool GetPersonInfoByID(int ID, ref string username, ref string secondName, ref string thirdName, ref string lastName,
            ref string nationalNo, ref DateTime dateOfBirth, ref string gender, ref string phone, ref string email, ref int countryID, ref string imagePath, ref string address)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    username = reader["FirstName"] as string ?? string.Empty;
                    secondName = reader["SecondName"] as string ?? string.Empty;
                    thirdName = reader["ThirdName"] as string ?? string.Empty;
                    lastName = reader["LastName"] as string ?? string.Empty;
                    nationalNo = reader["NationalNo"] as string ?? string.Empty;

                    dateOfBirth = reader["DateOfBirth"] != DBNull.Value ? (DateTime)reader["DateOfBirth"] : DateTime.MinValue;

                    // Handle Gendor (tinyint)
                    gender = reader["Gendor"] != DBNull.Value && (byte)reader["Gendor"] == 0 ? "Male" : "Female";

                    // Handle nullable columns
                    phone = reader["Phone"] as string ?? string.Empty;
                    email = reader["Email"] as string ?? string.Empty;
                    countryID = reader["NationalityCountryID"] != DBNull.Value ? Convert.ToInt32(reader["NationalityCountryID"]) : -1;
                    address = reader["Address"] as string ?? string.Empty;

                    // Handle ImagePath (nullable)
                    imagePath = reader["ImagePath"] as string ?? string.Empty;

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }





        public static bool GetCountryInfoByName(string CountryName, ref int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Countries WHERE CountryName = @CountryName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    ID = (int)reader["CountryID"];

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }





        public static DataTable GetAllPeople ()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * from People";

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
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }




        public static int AddNewContact( string firstName, string secondName, string thirdName, string lastName,
            string nationalNo, DateTime dateOfBirth, string gender, string phone, string email, int countryID, string imagePath, string address)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO People
           ([NationalNo]
           ,[FirstName]
           ,[SecondName]
           ,[ThirdName]
           ,[LastName]
           ,[DateOfBirth]
           ,[Gendor]
           ,[Address]
           ,[Phone]
           ,[Email]
           ,[NationalityCountryID]
           ,[ImagePath])
     VALUES( @nationalNo, @firstName, @secondName, @thirdName, @lastName, @dateOfBirth, @gender, @address, @phone, @email, @countryID, @imagePath); 
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@nationalNo", nationalNo);
            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@secondName", secondName);
            command.Parameters.AddWithValue("@thirdName", thirdName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            command.Parameters.Add("@gender", SqlDbType.TinyInt).Value = (gender == "Male" ? 0 : 1);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@countryID", countryID);

            if (imagePath != "" && imagePath != null)
                command.Parameters.AddWithValue("@imagePath", imagePath);
            else
                command.Parameters.AddWithValue("@imagePath", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return PersonID;
        }



        public static bool UpdateContact(int ID, string firstName, string secondName, string thirdName, string lastName,
            string nationalNo, DateTime dateOfBirth, string gender, string phone, string email, int countryID, string imagePath, string address)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                UPDATE People
                                SET
                                    NationalNo = @nationalNo
                                    FirstName = @firstName,
                                    SecondName = @secondName,
                                    ThirdName = @thirdName,
                                    LastName = @lastName,
                                    DateOfBirth = @dateOfBirth,
                                    Gendor = @gender,
                                    Address = @address,
                                    Phone = @phone,
                                    Email = @email,
                                    NationalityCountryID = @countryID,
                                    ImagePath = @imagePath
                                WHERE PersonID = @PersonID;";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@secondName", secondName);
            command.Parameters.AddWithValue("@thirdName", thirdName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            command.Parameters.Add("@gender", SqlDbType.TinyInt).Value = (gender == "Male" ? 0 : 1);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@countryID", countryID);
            command.Parameters.AddWithValue("@nationalNo", nationalNo);


            if (imagePath != "" && imagePath != null)
                command.Parameters.AddWithValue("@imagePath", imagePath);
            else
                command.Parameters.AddWithValue("@imagePath", System.DBNull.Value);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }




        public static DataTable GetAllCountries()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Countries order by CountryName";

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
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }





        public static bool DeletePerson(int PersonID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete People 
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }



        public static bool IsPersonExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }




        private static void LogError(Exception ex)
        {
            // Replace with proper logging
            Console.WriteLine("Error: " + ex.Message);
        }




        public static bool IsNationalUsed(string NationalNo)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        public static bool IsActiveUser(string username)
        {
            // Use "using" for automatic resource cleanup
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                // Define the query with parameter
                string query = "SELECT IsActive FROM Users WHERE UserName = @username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    try
                    {
                        // Open connection
                        connection.Open();

                        // Execute query and retrieve value
                        object result = command.ExecuteScalar();

                        // Return true if IsActive = 1, false otherwise
                        return result != null && Convert.ToBoolean(result);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false; // Treat as inactive in case of error
                    }
                }
            }
        }



        public static bool IsValidUser(string username, string password)
        {
            // Use "using" for automatic resource cleanup
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                // Define the query with parameter
                string query = "SELECT COUNT(*) FROM Users WHERE UserName = @username AND Password = @password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@Password", password);


                    try
                    {
                        // Open connection
                        connection.Open();

                        // Execute query and retrieve value
                        int count = (int)command.ExecuteScalar();

                        // Return true if count > 0, false otherwise
                        return count > 0;

                    }
                    catch (Exception ex)
                    {
                        LogError(ex);
                        return false; // Treat as inactive in case of error
                    }
                }
            }
        }



        public static DataTable getAllUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Users.UserID,
                            People.PersonID,
                            People.FirstName,
                            People.SecondName,
                            People.ThirdName,
                            People.LastName,
                            Users.UserName, 
                            Users.IsActive
               

                         FROM
                               People 
                              INNER JOIN  

                               Users ON People.PersonID = Users.PersonID";

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



        public static bool GetUserInfoByID(int ID, ref string username, ref string isActive )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT UserID, UserName, IsActive FROM Users WHERE UserID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                 //   ID = Convert.ToInt32(reader["ID"]);
                    username = reader["userName"] as string ?? string.Empty;

                    // Handle isActive (tinyint)
                    isActive =  reader["isActive"] != DBNull.Value && (byte)reader["isActive"] == 0 ? "No" : "Yes";

                   

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
               LogError (ex);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        public static bool GetUserInfoByName(string userName, ref int userID, ref string isActive)
        {
            bool isFound = false;

            string connectionString = clsDataAccessSettings.ConnectionString;
            string query = @"
        SELECT UserID, UserName, IsActive 
        FROM Users 
        WHERE UserName = @userName";

            using (SqlConnection connection = new SqlConnection(connectionString))
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



        public static bool SaveNewPassword(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                // Define the query with parameters
                string query = "UPDATE Users SET Password = @password WHERE UserName = @username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the query and get the number of rows affected
                        int rowsAffected = command.ExecuteNonQuery();

                        // Return true if at least one row was updated, false otherwise
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        // Log the error and return false
                        LogError(ex);
                        return false;
                    }
                }
            }
        }


        public static bool GetPersonIDByUserID(int UserID, ref int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT PersonID FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int personId))
                {
                    isFound = true;
                    PersonID = personId; // Assign result to the ref parameter
                    Console.WriteLine($"DEBUG: PersonID found for UserID {UserID} = {PersonID}");
                }
                else
                {
                    isFound = false;
                    Console.WriteLine($"DEBUG: No PersonID found for UserID {UserID}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }







    }
}
