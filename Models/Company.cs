using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{
    public class Company
    {

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ComapanyAddress { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public List<Employment> Employments { get; set; }
    }
}
