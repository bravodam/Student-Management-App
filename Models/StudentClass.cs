using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{
    public class StudentClass
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name Cannot excedd 50 characters")]
        public string Name { get; set; }
     
        public GenderEnum? Gender{ get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-z0-9-.]+$",
           ErrorMessage = "Invalid Email Format ")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }
        public string  Address { get; set; }
      
        public string Identification { get; set; }
     
        public EnumNational Nationality { get; set; }
      
        public string Phone { get; set; }
        public string  HealthCondition { get; set; }
   
        public  maritalStatus? Marital{ get; set; }

        public string NextOfKinName { get; set; }
        public string NextOfKinPhone { get; set; }
        public string NextOfKinAddress { get; set; }



    
        public  StudentEnum? StudentStatus { get; set; }
     
        public admissionEnum AdmissionType { get;set; }
        public string PhotoPath { get; set; }
        public List<Project> Project { get; set; }
        public List<StudentInBatch> studentInBatches { get; set; }
        public List<Guarrantor> Guarrantors { get; set; }
        public List<Employment> Employments { get; set; }




    }
}
