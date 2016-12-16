﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asprs3.Models
{
    public class Student
    {
        [Key]
        [Display(Name = "Student Number")]
        public int StudentID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Student First Name")]
        public String StudentFName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Student Last Name")]
        public String StudentLName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime StudentDOB { get; set; }

        [Required]
        [Display(Name = "Student Grade")]
        public int StudentGrade { get; set; }

    }
}