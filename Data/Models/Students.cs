using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQL_Number_Three.Data.Models
{
    public class Students
    {
        public Students()
        {
            this.CourseEnrollments = new HashSet<StudentCourses>();
            this.HomeworkSubmissions = new HashSet<HomeworkSubmissions>();
        }

        [Key]
        public int StudentId { get; set; }

        [Required, MaxLength(128)]
        public string Name { get; set; }

        [Column(TypeName = "char(10)")]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime RegisteredOn { get; set; }
        public DateTime? Birthday { get; set; }

        public virtual ICollection<StudentCourses> CourseEnrollments { get; set; }

        public virtual ICollection<HomeworkSubmissions> HomeworkSubmissions { get; set; }
    }
}
