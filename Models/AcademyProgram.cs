using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{
    public class AcademyProgram
    {
        public int Id { get; set; }
        public ProgramName ProgramName { get; set; }
        public List<Batch> Batches { get; set; }
        public EnuProgramDuration ProgramDuration { get; set; }
        public List<ProgramCourse> ProgramCourses { get; set; }
    }
}
