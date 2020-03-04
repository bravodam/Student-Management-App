using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{
    public class StudentInBatch
    {
        public int StudentId { get; set; }
        public string Status { get; set; }
        public EnumGrade Grade { get; set; }
        public int BatchId { get; set; }
        public StudentClass Student { get; set; }
        public Batch Batch { get; set; }

    }
}
