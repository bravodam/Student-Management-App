using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{
    public  static class ModelBuilderExtension
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentClass>().HasData(
                 new StudentClass
                 {
                     Id = 2,
                     Name = "Mary",
                     Gender = GenderEnum.Female,
                     Email = "bravo@gmail.com"
                 },

                  new StudentClass
                  {
                      Id = 3,
                      Name = "john",
                      Gender = GenderEnum.Female,
                      Email = "john@gmail.com"
                  }


                 );


        }
    }
}
