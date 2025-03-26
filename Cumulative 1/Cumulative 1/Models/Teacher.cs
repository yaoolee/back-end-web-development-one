﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Cumulative_1.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string? TeacherFName { get; set; }
        public string? TeacherLName { get; set; }
        public string? EmployeeNumber { get; set; }
        public DateTime? HireDate { get; set; }
        public decimal? Salary { get; set; }
    }
}
