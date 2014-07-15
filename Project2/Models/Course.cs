using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Project2.Models
{
    public class Course
    {

        public Course()
        {
            this.Students = new HashSet<Student>();
            this.Teachers = new HashSet<Teacher>();
        }

        [ScaffoldColumn(false)]
        public int CourseID { get; set; }

        [Required, Display(Name = "Course Year")]
        public int CourseYear { get; set; }

        [Required, StringLength(50), Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Required, StringLength(10000), Display(Name = "Course Description"), DataType(DataType.MultilineText)]
        public string CourseDescription { get; set; }

        public string CourseDepartement { get; set; }

        public int CourseSemester { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}