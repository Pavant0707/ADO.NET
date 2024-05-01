using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=PRAVEEN\SQLEXPRESS;Integrated Security=True";
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                //Console.WriteLine("Connection established");
                //Console.WriteLine("enter name");
                //string NAME = Console.ReadLine();
                //Console.WriteLine("enter the country");
                //string COUNTRY= Console.ReadLine();
                //Console.WriteLine("enter id");
                //int ID=Convert.ToInt32(Console.ReadLine());
                //string insertquery="INSERT INTO EMPLOYEES(NAME,COUNTRY,ID) VALUES('"+NAME+"','"+COUNTRY+"',"+ID+")";
                //SqlCommand insertcommand =new SqlCommand(insertquery,sqlConnection);
                //insertcommand.ExecuteNonQuery();
                //Console.WriteLine("data inserted");
                //Retrieve=>R
                //string displayQuery = "SELECT * FROM EMPLOYEES";
                //SqlCommand displayCommand=new SqlCommand(displayQuery,sqlConnection);
                //SqlDataReader reader =displayCommand.ExecuteReader();
                //while (reader.Read())
                //{
                //    Console.WriteLine("ID:"+reader.GetValue(0));
                //    Console.WriteLine("NAME:"+reader.GetValue(1));
                //    Console.WriteLine("COUNTRY"+ reader.GetValue(2))n;
                //}
                //UPDATE 
                //Console.WriteLine("enter the userid that u like update");
                //int ID = Convert.ToInt32(Console.ReadLine());
                //string update = "UPDATE EMPLOYEES SET NAME='PRABAAS' WHERE NAME='Prabas'";
                //SqlCommand cmd = new SqlCommand(update,sqlConnection);
                //cmd.ExecuteNonQuery();
                //Console.WriteLine("data updated ");
                string delete = "DELETE FROM EMPLOYEES WHERE ID=6";
                SqlCommand sqlCommand = new SqlCommand(delete,sqlConnection);
                sqlCommand.ExecuteNonQuery();
                Console.WriteLine("deleted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
