using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Project2.Models
{
    public class Course
    {
        [ScaffoldColumn(false)]
        public int CourseID { get; set; }

        [Required, Display(Name = "Course Year")]
        public int CourseYear { get; set; }

        [StringLength(20), Display(Name = "Course Teacher")]
        public string CourseTeacher { get; set; }

        [Required, StringLength(50), Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Required, StringLength(10000), Display(Name = "Course Description"), DataType(DataType.MultilineText)]
        public string CourseDescription { get; set; }

        public string CourseDepartement { get; set; }

        public virtual ICollection<Advertisement> Advertisements { get; set; } 
    }
}