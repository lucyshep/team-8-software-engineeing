using System.Data.SqlClient;
using TSE.Controllers;
using TSE.Models;

namespace TSE.services
{
    public class Register
    {
        //sets the connection string to the database string 
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Users;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool AddUser(UserModel user)
        {
            //sets successful to false 
            bool successful = false;
            //defins the sql statement 
            string sqlState = "INSERT INTO dbo.Users (Username, Password) values(@Username, @Password)";

            //using the sql connection with the connection string 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //sets the command 
                SqlCommand command = new SqlCommand(sqlState, connection);
                


                //checks if the username is equal to the username in the database 
                command.Parameters.Add("@Username", System.Data.SqlDbType.NVarChar, 50).Value = user.Username;
                //checks if the password is equal to the username in the password 
                command.Parameters.Add("@Password", System.Data.SqlDbType.NVarChar, 50).Value = PasswordEncryption.ConvertToEncrypt(user.Password);

                //try catch statment 
                try
                {
                    //opens the connection 
                    connection.Open();
                    //reads the sql commands
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        successful = true;
                    }
                    else if (rowsAffected == 0){ 
                        Console.WriteLine("ERROR");
                        
                    }
                    

                    //catch execption e 
                }
                catch (Exception e)
                {
                    //outputs the error 
                    Console.WriteLine(e.Message);
                    throw;
                }

                //returns successfull 
                return successful;
            }
        }

    }
}
