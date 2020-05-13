using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPortal.Models
{
    public class StudentCourseAssignmentModel
    {
        public List<string> courses { get; set; }
        public int studentID { get; set; }
    }
}
