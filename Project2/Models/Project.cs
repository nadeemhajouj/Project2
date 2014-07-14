using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Project2.Models
{
    public class Project
    {
        [ScaffoldColumn(false)]
        public int ProjectID { get; set; }

        [Required, StringLength(100), Display(Name = "Project Name")]
        public string ProjectName { get; set; }

        [Required, StringLength(1000), Display(Name = "Project Description"), DataType(DataType.MultilineText)]
        public string ProjectDescription { get; set; }

        [Required, Display(Name = "Project Year")]
        public int ProjectYear { get; set; }

        public string ImagePath { get; set; }

    }
}