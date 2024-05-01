using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp4
{
   public class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectinstring = @"Data Source=Praveen\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True";
            try
            {
                sqlConnection = new SqlConnection(connectinstring);
                sqlConnection.Open();
                Console.WriteLine("ram ram");
                Console.WriteLine("enter name");
                string NAME = Console.ReadLine();
                Console.WriteLine("enter id");
                int ID = Convert.ToInt32(Console.ReadLine());
                string insertquery = "INSERT INTO STUDENTS(NAME,ID) VALUES('" + NAME + "'," + ID + ")";
                SqlCommand insertcommand = new SqlCommand(insertquery, sqlConnection);
                insertcommand.ExecuteNonQuery();
                Console.WriteLine("data inserted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
