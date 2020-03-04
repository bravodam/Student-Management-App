using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{
    public class SQLStudentRepo:IStudent
    {

        private readonly AppDbContext context;
        public SQLStudentRepo(AppDbContext context)
        {
            this.context = context;
        }
        public StudentClass Add(StudentClass studentClass)
        {
            context.StudentClasses.Add(studentClass);
            context.SaveChanges();
            return studentClass;
        }

        public StudentClass Delete(int Id)
        {
            StudentClass studentClass = context.StudentClasses.Find(Id);
            if (studentClass != null)
            {
                context.StudentClasses.Remove(studentClass);
                context.SaveChanges();
            }
            return studentClass;
        }

        public IEnumerable<StudentClass> GetAllStudents()
        {
            var students = context.StudentClasses;
            return students;
        }

        public StudentClass GetStudent(int id)
        {
            return context.StudentClasses.Find(id);
        }

        public StudentClass Update(StudentClass studentClassChange)
        {
            var studentClass = context.StudentClasses.Attach(studentClassChange);
            studentClass.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return studentClassChange;

        }



    }
}
