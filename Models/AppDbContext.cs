using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Code360NEWWEB.Models
{
    public class AppDbContext: IdentityDbContext
    {



        public AppDbContext(DbContextOptions<AppDbContext> options) :  
           base(options)


        {

        }

        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentInBatch> StudentInBatches { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<ProgramCourse> ProgramCourses { get; set; }
        public DbSet<Guarrantor> Guarrantors { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Employment> Employments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();


            modelBuilder.Entity<StudentInBatch>()
                .HasKey(sb => new { sb.BatchId, sb.StudentId });

            modelBuilder.Entity<StudentInBatch>()
                .HasOne(sb => sb.Student)
                .WithMany(sb => sb.studentInBatches)
                .HasForeignKey(sb => sb.StudentId);

            modelBuilder.Entity<StudentInBatch>()
                .HasOne(sb => sb.Batch)
                .WithMany(sb => sb.studentInBatches)
                .HasForeignKey(sb => sb.BatchId);

            modelBuilder.Entity<ProgramCourse>()
                .HasKey(pc => new { pc.CourseId, pc.ProgrameId });

            modelBuilder.Entity<ProgramCourse>()
                .HasOne(pc => pc.Course)
                .WithMany(pc => pc.ProgramCourses)
                .HasForeignKey(pc => pc.CourseId);

            modelBuilder.Entity<ProgramCourse>()
            .HasOne(pc => pc.Program)
            .WithMany(pc => pc.programCourses)
            .HasForeignKey(pc => pc.ProgrameId);

            modelBuilder.Entity<Employment>().HasKey(s => 
            new { s.StudentId, s.CompanyId });


            modelBuilder.Entity<Employment>()
                .HasOne(e => e.Company)
                .WithMany(c => c.Employments)
                .HasForeignKey(c => c.CompanyId);

            modelBuilder.Entity<Employment>()
                        .HasOne(s => s.Student)
                        .WithMany(s => s.Employments)
                        .HasForeignKey(s => s.StudentId);

             



        }
    }
}
