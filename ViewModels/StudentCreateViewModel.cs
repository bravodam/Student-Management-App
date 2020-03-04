using Code360NEWWEB.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.ViewModels
{
    public class StudentCreateViewModel
    {


        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name Cannot excedd 50 characters")]
        public string Name { get; set; }
        [Required]
        public GenderEnum? Gender { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-z0-9-.]+$",
           ErrorMessage = "Invalid Email Format ")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }
       
        
        [Required]
        [Display(Name="Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Identification { get; set; }
        [Required]
        public EnumNational Nationality { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string HealthCondition { get; set; }
        [Required]
        [Display(Name = "Marital Status")]
        public maritalStatus? Marital { get; set; }

        [Display(Name = "Next Of Kin Name")]
        public string NextOfKinName { get; set; }
        [Display(Name = "Next Of Kin Phone")]
        public string NextOfKinPhone { get; set; }
        [Display(Name="Next Of Kin Address")]
        public string NextOfKinAddress { get; set; }

        [Required]
        [Display(Name = "Student Status")]
        public StudentEnum? StudentStatus { get; set; }
        [Required]
        [Display(Name = "Admission Type")]
        public admissionEnum AdmissionType { get; set; }
        public IFormFile Photo { get; set; }


    }
}
