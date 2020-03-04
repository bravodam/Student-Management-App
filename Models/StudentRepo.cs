using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{
    public class StudentRepo:IStudent
    {
        private List<StudentClass> _studentsList;
        public StudentRepo()
        {
            _studentsList = new List<StudentClass>()
            {
                new StudentClass(){Id= 1, Name ="Mike",Gender = GenderEnum.Male, Address="Lag", Email="mike@gmail.com", DOB= DateTime.Now, 
                    Identification="Voter's Card",Nationality=EnumNational.Angola, 
                    Phone="0808564376", Marital=maritalStatus.Married,StudentStatus=StudentEnum.Employed,AdmissionType=admissionEnum.Paid },
                 new StudentClass(){Id= 1, Name ="Moose",Gender = GenderEnum.Female, Address="Lag", Email="mike@gmail.com", DOB=DateTime.Now,
                     Identification="Voter's Card",Nationality=EnumNational.Angola, Phone="0808564376", 
                     Marital=maritalStatus.Married,StudentStatus=StudentEnum.Employed,AdmissionType=admissionEnum.Paid},
                  new StudentClass(){Id= 2, Name ="Mike",Gender = GenderEnum.Male, Address="Lag", Email="mike@gmail.com", DOB=DateTime.Now,
                      Identification="Voter's Card",Nationality=EnumNational.Angola, Phone="0808564376", 
                      Marital=maritalStatus.Married,StudentStatus=StudentEnum.Employed,AdmissionType=admissionEnum.Paid},
                   new StudentClass(){Id= 3, Name ="Mike",Gender = GenderEnum.Male, Address="NY", Email="mike@gmail.com", DOB=DateTime.Now,
                       Identification="Voter's Card",Nationality=EnumNational.Angola, Phone="0808564376", 
                       Marital=maritalStatus.Married,StudentStatus=StudentEnum.Employed,AdmissionType=admissionEnum.Paid}
            };

           
        }

        public StudentClass Add(StudentClass studentClass)
        {
            studentClass.Id = _studentsList.Max(e => e.Id) + 1;
            _studentsList.Add(studentClass);
            return studentClass;
        }

        public StudentClass Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StudentClass> GetAllStudents()
        {
            return _studentsList;
        }



        public StudentClass GetStudent(int id)
        {
            return _studentsList.FirstOrDefault(s => s.Id == id);
        }

        public StudentClass Update(StudentClass studentClassChange)
        {
            StudentClass studentClass = _studentsList.FirstOrDefault(e => e.Id == studentClassChange.Id);
            if (studentClass != null)
            {
                studentClass.Name = studentClassChange.Name;
                studentClass.Gender = studentClassChange.Gender;
                studentClass.Email = studentClassChange.Email;
                studentClass.DOB = studentClassChange.DOB;
                studentClass.Address = studentClassChange.Address;
                studentClass.Identification = studentClassChange.Identification;
                studentClass.Nationality = studentClassChange.Nationality;
                studentClass.Phone = studentClassChange.Phone;
                studentClass.PhotoPath = studentClassChange.PhotoPath;
                studentClass.HealthCondition = studentClassChange.HealthCondition;
                studentClass.Marital = studentClassChange.Marital;
                studentClass.StudentStatus = studentClassChange.StudentStatus;
                studentClass.AdmissionType = studentClassChange.AdmissionType;
                

            }
            return studentClass;
        }
    }
}
