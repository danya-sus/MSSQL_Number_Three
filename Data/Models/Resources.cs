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
    public class Resources
    {
        [Key]
        public int ResourceId { get; set; }

        [Required, MaxLength(64)]
        public string Name { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string Url { get; set; }

        public ResourceType ResourceType { get; set; }

        [ForeignKey(name: "Course")]
        public int CourseId { get; set; }
        public virtual Courses Courses { get; set; }
    }
}
