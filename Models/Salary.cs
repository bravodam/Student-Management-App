using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Role { get; set; }
        public double Amount { get; set; }
        public string PayDay { get; set;}



    }
}
