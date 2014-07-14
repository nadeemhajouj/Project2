﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Project2.Models
{
    public class CourseContext : DbContext
    {
        public CourseContext()
            : base("Project2")
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; } 
    }
    
}