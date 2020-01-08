using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using School.Models;

namespace School.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<AcademicSection> AcademicSections { get; set; }

        public DbSet<DepartmentSubject> departmentSubjects { get; set; }

        public Term CurrentTerm { get => Terms.SingleOrDefault(t => t.StartDate < DateTime.Now && t.EndDate > DateTime.Now); }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Teacher>()
                .HasOne(t => t.DepartmentHeading)
                .WithOne(d => d.DepartmentHead)
                .HasForeignKey<Department>(d => d.DepartmentHeadId);

            builder.Entity<Student>()
                .HasOne(s => s.Department)
                .WithMany()
                .HasForeignKey(s => s.DepartmentId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Student>()
                .HasOne(s => s.Class)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.ClassId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Teacher>()
                .HasOne(t => t.Class)
                .WithMany()
                .HasForeignKey(t => t.ClassId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<DepartmentSubject>()
                .HasOne(ds => ds.Department)
                .WithMany()
                .HasForeignKey(ds => ds.DepartmentId);

            builder.Entity<DepartmentSubject>()
                .HasOne(ds => ds.Subject)
                .WithMany()
                .HasForeignKey(ds => ds.SubjectId);

            builder.Entity<DepartmentSubject>()
                .HasKey(nameof(DepartmentSubject.DepartmentId), nameof(DepartmentSubject.SubjectId));

            builder.Entity<Exam>()
                .HasKey(nameof(Exam.DepartmentSubjectDepartmentId), nameof(Exam.DepartmentSubjectSubjectId), nameof(Exam.StudentId), nameof(Exam.TermId));

            builder.Entity<Exam>()
                .HasOne(e => e.DepartmentSubject)
                .WithMany()
                .HasForeignKey(nameof(Exam.DepartmentSubjectDepartmentId), nameof(Exam.DepartmentSubjectSubjectId));

            builder.Entity<Test>()
                .HasOne(e => e.DepartmentSubject)
                .WithMany()
                .HasForeignKey(nameof(Test.DepartmentSubjectDepartmentId), nameof(Test.DepartmentSubjectSubjectId));

            builder.Entity<Test>()
                .HasKey(nameof(Test.DepartmentSubjectDepartmentId), nameof(Test.DepartmentSubjectSubjectId), nameof(Test.StudentId), nameof(Test.TermId));
        }
    }
}
