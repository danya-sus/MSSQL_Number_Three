using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQL_Number_Three.Data.Models
{
    public class Courses
    {
        public Courses()
        {
            this.StudentsEnrolled = new HashSet<StudentCourses>();
            this.Resources = new HashSet<Resources>();
            this.HomeworkSubmissions = new HashSet<HomeworkSubmissions>();
        }

        [Key]
        public int CourseId { get; set; }

        [Required, MaxLength(64)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get;set }

        [Required]
        public DateTime EndDate { get;set }

        [Required]
        public decimal Price { get; set; }

        public virtual ICollection<StudentCourses> StudentsEnrolled { get; set; }
        public virtual ICollection<Resources> Resources { get; set; }

        public virtual ICollection<HomeworkSubmissions> HomeworkSubmissions { get; set; }
    }
}
