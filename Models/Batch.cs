using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{                 
    public class Batch
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int ProgramId { get; set; }
        public string Supervisor { get; set; }
        public YearEnum Year { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public Program Programs { get; set; }
        public List<StudentInBatch> studentInBatches { get; set;}
    }
}