using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{
    public class ProgramCourse
    {
        public int ProgrameId { get; set; }
        public Program Program { get; set; }
        public int CourseId { get; set;}
        public Course Course { get; set; }
    }
}
