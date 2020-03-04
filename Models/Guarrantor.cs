using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{
    public class Guarrantor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Guid GuarrantorId { get; set; }
        public string HomePhone { get; set; }
        public string OfficePhone { get; set; }
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public EnumNational Nationality { get; set; }
        public string Address { get; set; }
        public GenderEnum Gender { get; set; }
        public int StudentId { get; set; }
        public StudentClass Student { get; set; }
    }
}
