using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolHouseRock
{
    class Program
    {
        static void Main(string[] args)
        {
            // Where is the Database
            const string connectionString =
                @"Server=localhost\SQLEXPRESS;Database=SchoolData;Trusted_Connection=True;";
            // Open with using something

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Connected");
            }




        }

    }
}
