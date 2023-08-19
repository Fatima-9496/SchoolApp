﻿using System.ComponentModel.DataAnnotations;

namespace SchoolApp.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [StringLength(20, MinimumLength = 3)]
        public string CourseName { get; set; }
        [StringLength(50)]
        public string? CourseDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
        public ICollection<Assignment>? Assignments { get; set; }

    }
}
