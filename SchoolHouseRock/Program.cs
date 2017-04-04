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
        static public List<Course> GetAllCourses(SqlConnection connection)
        {
            var courses = new List<Course>();
            // Basic Select
            /*
             SELECT * FROM Course

             */
            // estblish the QUERY
            var sqlCommand = new SqlCommand(@"SELECT  CourseTitle, InstructorName
                                           FROM [dbo].[Instructor]
                                           JOIN Course ON Course.InstructorId = Instructor.Id", connection);
            // open the connection
            connection.Open();
            // Run Query
            var reader = sqlCommand.ExecuteReader();
            // Read Results
            while (reader.Read())
            {
                //var course = new Course(reader);
                var course = new Course
                {
                    CourseTitle = reader["CourseTitle"].ToString(),
                    InstructorName = reader["InstructorName"].ToString()
                };
                courses.Add(course);
            }
            // Close Connection
            connection.Close();
            return courses;
        }
        



        static void Main(string[] args)
        {
            // Where is the Database
            const string connectionString =
                @"Server=localhost\SQLEXPRESS;Database=SchoolData;Trusted_Connection=True;";
            // Open with using something

            var courses = new List<Course>();
            using (var connection = new SqlConnection(connectionString))
            {
                courses = GetAllCourses(connection);
                Console.WriteLine("DotNet University");
                foreach (var course in courses)
                {
                    Console.WriteLine(course.CourseTitle + ": Taught by " + course.InstructorName);
                }
            }


    }

}
}
