using System;
using System.Data.SqlClient;
using TSE.Models;

namespace TSE.services
{
    public class AssignStaffService
    {
        //sets the connection string to the connection to the databse 
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = LoginUsers; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //fucntion for assigning staff memeber
        public bool findStaffMember(AssignStaff staffMemeber)
        {
            //sets success to false 
            bool success = false;

            //sets the sql statment to the update command 
            //updates the assigned to column to the input where the username is also the inputted username 
            string sqlStatement = "UPDATE Users SET AssignedTo = @AssignedTo WHERE Username = @Username ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //sets the command to the statment and the connection 
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                //add the parameters for the username and the assigned to which are the users inputs 
                command.Parameters.Add("@Username", System.Data.SqlDbType.NVarChar, 50).Value = staffMemeber.StaffName;
                command.Parameters.Add("@AssignedTo", System.Data.SqlDbType.Int).Value = staffMemeber.FieldNo;

                //try catch statement 
                try
                {
                    //opens the connection 
                    connection.Open();
                    //reads the sql commands
                    int rowsAffected = command.ExecuteNonQuery();
                    //if rows affected is greater the 0 
                    if (rowsAffected > 0)
                    {
                        //set sucess to true 
                        success = true;
                    }
                    //else if no rows affected 
                    else if (rowsAffected == 0)
                    {
                        //write error 
                        Console.WriteLine("ERROR");
                    }
                }
                //catch execption e 
                catch (Exception e)
                {
                    //outputs the error 
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
            //returns the success variable 
            return success;
        }
    }
}
