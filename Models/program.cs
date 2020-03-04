using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{
    public class Program
    {
        public int Id { get; set; }
        public EnumProgramName Name { get; set; }
        public string Duration { get; set; }
        public double Cost { get; set; }
        public List<Batch> Batch { get; set; }
        public List<ProgramCourse> programCourses { get; set; }

    }
}
