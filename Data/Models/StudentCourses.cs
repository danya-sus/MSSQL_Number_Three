using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQL_Number_Three.Data.Models
{
    public class StudentCourses
    {
        [ForeignKey(name: "Student")]
        public int StudentId { get; set; }
        public virtual Students Students { get; set; }

        [ForeignKey(name: "Course")]
        public int CourseId { get; set; }
        public virtual Courses Courses { get; set; }
    }
}
