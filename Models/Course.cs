using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string  Name {get;set;}
        public EnumLevelCourse Level { get; set; }
        public double Cost { get; set; }
        public List<ProgramCourse> ProgramCourses{ get; set; }

    }
}
