using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{
    public class Employment
    {

        public int Id { get; set; }
        public int CompanyId {get;set;}
        public Company Company { get; set; }
        public int StudentId { get; set; }
        public  StudentClass Student { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Salary> Salary { get; set; }

    }
}
