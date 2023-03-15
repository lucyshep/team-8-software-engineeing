using System;
using System.Data.SqlClient;
using TSE.Models;

namespace TSE.services
{
    public class Usersdao
    {
        //sets the connection string to the database string 
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Users;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool findUser (UserModel user )
        {
            //sets successful to false 
            bool successful = false;
            //defins the sql statement 
            string sqlState = "SELECT * FROM dbo.Users WHERE Username = @username AND Password = @password";

            //using the sql connection with the connection string 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //sets the command 
                SqlCommand command = new SqlCommand(sqlState, connection);

                //adds the username is equal to the username in the database 
                command.Parameters.Add("@Username", System.Data.SqlDbType.NVarChar, 50).Value = user.Username;
                //adds the password is equal to the username in the password 
                command.Parameters.Add("@Password", System.Data.SqlDbType.NVarChar, 50).Value = user.Password;

                //try catch statment 
                try
                {
                    //opens the connection 
                    connection.Open();
                    //reads the sql commands
                    SqlDataReader reader = command.ExecuteReader();
                    //if the command has rows - means it was successful 
                    if (reader.HasRows)
                    {
                        //sets successful to true 
                        successful = true;
                        
                    }

                //catch execption e 
                }catch(Exception e)
                {
                    //outputs the error 
                    Console.WriteLine(e.Message);
                }

                //returns successfull 
                return successful; 
            }
        }
    }

}
