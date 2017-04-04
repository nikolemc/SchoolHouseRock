using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolHouseRock
{
    class Course
    {
        public int Id { get; set; }
        public string CourseTitle { get; set; }
        public int InstructorId { get; set; }
        public int CourseNumber { get; set; }
        public int DepartmentNameId { get; set; }
        public string InstructorName { get; set; }

        public Course()
        {

        }

        public Course(SqlDataReader reader)
        {
            CourseTitle = reader["CourseTitle"].ToString();
            Id = (int)reader["Id"];
            InstructorId = (int)reader["InstructorId"];
            CourseNumber = (int)reader["CourseNumber"];
            DepartmentNameId = (int)reader["DepartmentNameId"];
        }


    }
}
