using MSSQL_Number_Three.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQL_Number_Three.Data.Models
{
    public class HomeworkSubmissions
    {
        [Key]
        public int HomeworkId { get; set; }

        [Required, Column(TypeName = "varchar(max)")]
        public string Content { get; set; }

        [Required]
        public ContentType ContentType { get; set; }

        public DateTime SubmissionTime { get; set; }

        [ForeignKey(name: "Student")]
        public int StudentId { get; set; }
        public virtual Students Students { get; set; }

        [ForeignKey(name: "Course")]
        public int CourseId { get; set; }
        public virtual Courses Course { get; set; }

    }
}
