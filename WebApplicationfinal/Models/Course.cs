using System;
using System.Collections.Generic;

namespace WebApplicationfinal.Models
{
    public partial class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Fee { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Category { get; set; }
    }
}
