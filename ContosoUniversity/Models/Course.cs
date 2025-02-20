﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")] //ezhr basm Number f elview
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        [Range(0, 5)]
        public int DepartmentID { get; set; }
        public int Credits { get; set; }

        //NAVIGATION PROP
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}