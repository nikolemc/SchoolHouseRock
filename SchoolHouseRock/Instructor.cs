using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolHouseRock
{
    class Instructor
    {

        public int Id { get; set; }
        public string InstructorName { get; set; }
        public int DepartmentNameId { get; set; }

        public Instructor()
        {

        }

        public Instructor(SqlDataReader reader)
        {
            InstructorName = reader["InstructorName"].ToString();
            Id = (int)reader["Id"];
            DepartmentNameId = (int)reader["DepartmentNameId"];
        }


    }
}
