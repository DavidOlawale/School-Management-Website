﻿using System;
using System.Collections.Generic;
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
                .HasKey(nameof(DepartmentSubject.DepartmentId), nameof(DepartmentSubject.SubjectId));

            builder.Entity<Exam>()
                .HasKey(nameof(Exam.DepartmentSubjectDepartmentId), nameof(Exam.DepartmentSubjectSubjecttId), nameof(Exam.StudentId), nameof(Exam.AcademicSectionId));

            builder.Entity<Exam>()
                .HasOne(e => e.DepartmentSubject)
                .WithMany()
                .HasForeignKey(nameof(Exam.DepartmentSubjectDepartmentId), nameof(Exam.DepartmentSubjectSubjecttId));

        }
    }
}
