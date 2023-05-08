using Microsoft.AspNetCore.Routing.Constraints;
using System.Data;
using System.Data.SqlClient;



namespace TSE.services
{
   

    public class OverviewClass
    {



        List<string> Field_1 = new List<string>();
        List<string> Field2 = new List<string>();
        List<string> Field3 = new List<string>();
        List<string> Field4 = new List<string>();
        List<string> Field5 = new List<string>();
        List<string> Field6 = new List<string>();
        List<string> Field7 = new List<string>();
        List<string> Field8 = new List<string>();
        List<string> Field9 = new List<string>();

      

        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = LoginUsers; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
       
        public List<string> setField_1()
        {
           
            

            SqlConnection conn1 = new SqlConnection(connectionString);
            conn1.Open();


            //gets the username form the database of everyone who is assigned to field 1
            string sqlStatement1 = "SELECT Username From dbo.users WHERE AssignedTo = 1";
            SqlCommand cmd = new SqlCommand(sqlStatement1, conn1);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            int count = reader.FieldCount;
            while (reader.Read())
            {
                for (int i = 0; i < count; i++)
                {
                    Field_1.Add(reader[i].ToString());
                    
                    
                }
            }

            conn1.Close();


            //field1Members= new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(Field_1);



            return Field_1; 
            
        }
        //public static string myOutput()
        //{
        //    foreach (string field in Field_1)
        //    {
        //        Console.WriteLine(field);
                
        //    }
        //    return Field_1.ToString();
        //}

        public void setField_2()
        {
            SqlConnection conn2 = new SqlConnection(connectionString);
            conn2.Open();

            //gets the username form the database of everyone who is assigned to field 2

            string sqlStatement2 = "SELECT Username From dbo.users WHERE AssignedTo = 2";
            SqlCommand cmd2 = new SqlCommand(sqlStatement2, conn2);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();
            int count2 = reader2.FieldCount;
            while (reader2.Read())
            {
                for (int i = 0; i < count2; i++)
                {
                    Field2.Add(reader2[i].ToString());
                }
            }
            conn2.Close();
        }

        public void setField_3()
        {
            SqlConnection conn3 = new SqlConnection(connectionString);
            conn3.Open();
            //gets the username form the database of everyone who is assigned to field 3

            string sqlStatement3 = "SELECT Username From dbo.users WHERE AssignedTo = 3";
            SqlCommand cmd3 = new SqlCommand(sqlStatement3, conn3);
            SqlDataReader reader3;
            reader3 = cmd3.ExecuteReader();
            int count3 = reader3.FieldCount;
            while (reader3.Read())
            {
                for (int i = 0; i < count3; i++)
                {
                    Field3.Add(reader3[i].ToString());
                }
            }
            conn3.Close();
        }
        public void setField_4()
        {
            SqlConnection conn4 = new SqlConnection(connectionString);
            conn4.Open();
            //gets the username form the database of everyone who is assigned to field 4

            string sqlStatement4 = "SELECT Username From dbo.users WHERE AssignedTo = 4";
            SqlCommand cmd4 = new SqlCommand(sqlStatement4, conn4);
            SqlDataReader reader4;
            reader4 = cmd4.ExecuteReader();
            int count4 = reader4.FieldCount;
            while (reader4.Read())
            {
                for (int i = 0; i < count4; i++)
                {
                    Field4.Add(reader4[i].ToString());
                }
            }
            conn4.Close();
        }
        public void setField_5()
        {
            SqlConnection conn5 = new SqlConnection(connectionString);
            conn5.Open();
            //gets the username form the database of everyone who is assigned to field 5

            string sqlStatement5 = "SELECT Username From dbo.users WHERE AssignedTo = 5";
            SqlCommand cmd5 = new SqlCommand(sqlStatement5, conn5);
            SqlDataReader reader5;
            reader5 = cmd5.ExecuteReader();
            int count5 = reader5.FieldCount;
            while (reader5.Read())
            {
                for (int i = 0; i < count5; i++)
                {
                    Field5.Add(reader5[i].ToString());
                }
            }
            conn5.Close();
        }
        public void setField_6()
        {
            SqlConnection conn6 = new SqlConnection(connectionString);
            //gets the username form the database of everyone who is assigned to field 6
            conn6.Open();
            string sqlStatement6 = "SELECT Username From dbo.users WHERE AssignedTo = 6";
            SqlCommand cmd6 = new SqlCommand(sqlStatement6, conn6);
            SqlDataReader reader6;
            reader6 = cmd6.ExecuteReader();
            int count6 = reader6.FieldCount;
            while (reader6.Read())
            {
                for (int i = 0; i < count6; i++)
                {
                    Field6.Add(reader6[i].ToString());
                }
            }
            conn6.Close();
        }
        public void setField_7()
        {
            SqlConnection conn7 = new SqlConnection(connectionString);
            conn7.Open();
            //gets the username form the database of everyone who is assigned to field 7

            string sqlStatement7 = "SELECT Username From dbo.users WHERE AssignedTo = 7";
            SqlCommand cmd7 = new SqlCommand(sqlStatement7, conn7);
            SqlDataReader reader7;
            reader7 = cmd7.ExecuteReader();
            int count7 = reader7.FieldCount;
            while (reader7.Read())
            {
                for (int i = 0; i < count7; i++)
                {
                    Field7.Add(reader7[i].ToString());
                }
            }
            conn7.Close();
        }
        public void setField_8()
        {
            SqlConnection conn8 = new SqlConnection(connectionString);
            //gets the username form the database of everyone who is assigned to field 8
            conn8.Open();
            string sqlStatement8 = "SELECT Username From dbo.users WHERE AssignedTo = 8";
            SqlCommand cmd8 = new SqlCommand(sqlStatement8, conn8);
            SqlDataReader reader8;
            reader8 = cmd8.ExecuteReader();
            int count8 = reader8.FieldCount;
            while (reader8.Read())
            {
                for (int i = 0; i < count8; i++)
                {
                    Field8.Add(reader8[i].ToString());
                }
            }
            conn8.Close();

        }
        public void setField_9()
        {
            SqlConnection conn9 = new SqlConnection(connectionString);
            //gets the username form the database of everyone who is assigned to field 9
            conn9.Open();
            string sqlStatement9 = "SELECT Username From dbo.users WHERE AssignedTo = 9";
            SqlCommand cmd9 = new SqlCommand(sqlStatement9, conn9);
            SqlDataReader reader9;
            reader9 = cmd9.ExecuteReader();
            int count9 = reader9.FieldCount;
            while (reader9.Read())
            {
                for (int i = 0; i < count9; i++)
                {
                    Field9.Add(reader9[i].ToString());
                }
            }
            conn9.Close();
        }

      
    }
}


