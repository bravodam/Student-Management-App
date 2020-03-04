using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{
   public  interface IStudent
    {

        StudentClass GetStudent(int id);
        IEnumerable<StudentClass> GetAllStudents();
        StudentClass Add(StudentClass studentClass);
        StudentClass Update(StudentClass studentClassChange);
        StudentClass Delete(int Id);

    }
}
