﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School.Data;

namespace School.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191230130948_fixed-typo")]
    partial class fixedtypo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("School.Models.AcademicSection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BeginDate");

                    b.Property<DateTime>("EndDate");

                    b.Property<int?>("FirstTermId");

                    b.Property<int?>("SecondTermId");

                    b.Property<int?>("ThirdTermId");

                    b.HasKey("Id");

                    b.HasIndex("FirstTermId");

                    b.HasIndex("SecondTermId");

                    b.HasIndex("ThirdTermId");

                    b.ToTable("AcademicSections");
                });

            modelBuilder.Entity("School.Models.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("School.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("HasProfilePhoto");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("MiddleName")
                        .IsRequired();

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProfilePhotoExtension");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ApplicationUser");
                });

            modelBuilder.Entity("School.Models.Attendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<bool>("Present");

                    b.Property<Guid>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("School.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("School.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid?>("DepartmentHeadId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentHeadId")
                        .IsUnique()
                        .HasFilter("[DepartmentHeadId] IS NOT NULL");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("School.Models.DepartmentSubject", b =>
                {
                    b.Property<int>("DepartmentId");

                    b.Property<int>("SubjectId");

                    b.HasKey("DepartmentId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("departmentSubjects");
                });

            modelBuilder.Entity("School.Models.Exam", b =>
                {
                    b.Property<int>("DepartmentSubjectDepartmentId");

                    b.Property<int>("DepartmentSubjectSubjectId");

                    b.Property<Guid>("StudentId");

                    b.Property<int>("TermId");

                    b.Property<int>("Score");

                    b.HasKey("DepartmentSubjectDepartmentId", "DepartmentSubjectSubjectId", "StudentId", "TermId");

                    b.HasIndex("TermId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("School.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<bool>("Received");

                    b.Property<Guid>("ReceiverId");

                    b.Property<Guid>("SenderId");

                    b.HasKey("Id");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("School.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("School.Models.Term", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Terms");
                });

            modelBuilder.Entity("School.Models.Test", b =>
                {
                    b.Property<int>("DepartmentSubjectDepartmentId");

                    b.Property<int>("DepartmentSubjectSubjectId");

                    b.Property<Guid>("StudentId");

                    b.Property<int>("TermId");

                    b.Property<int>("Score");

                    b.HasKey("DepartmentSubjectDepartmentId", "DepartmentSubjectSubjectId", "StudentId", "TermId");

                    b.HasIndex("TermId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("School.Models.Admin", b =>
                {
                    b.HasBaseType("School.Models.ApplicationUser");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("School.Models.Parent", b =>
                {
                    b.HasBaseType("School.Models.ApplicationUser");

                    b.HasDiscriminator().HasValue("Parent");
                });

            modelBuilder.Entity("School.Models.Student", b =>
                {
                    b.HasBaseType("School.Models.ApplicationUser");

                    b.Property<DateTime>("AdmissionDate");

                    b.Property<int>("ClassId");

                    b.Property<DateTime>("DOB");

                    b.Property<int>("DepartmentId");

                    b.Property<Guid?>("ParentId");

                    b.HasIndex("ClassId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ParentId");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("School.Models.Teacher", b =>
                {
                    b.HasBaseType("School.Models.ApplicationUser");

                    b.Property<int>("ClassId")
                        .HasColumnName("Teacher_ClassId");

                    b.Property<DateTime>("DOB")
                        .HasColumnName("Teacher_DOB");

                    b.Property<DateTime>("EmploymentDate");

                    b.HasIndex("ClassId");

                    b.HasDiscriminator().HasValue("Teacher");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("School.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("School.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("School.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("School.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("School.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("School.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("School.Models.AcademicSection", b =>
                {
                    b.HasOne("School.Models.Term", "FirstTerm")
                        .WithMany()
                        .HasForeignKey("FirstTermId");

                    b.HasOne("School.Models.Term", "SecondTerm")
                        .WithMany()
                        .HasForeignKey("SecondTermId");

                    b.HasOne("School.Models.Term", "ThirdTerm")
                        .WithMany()
                        .HasForeignKey("ThirdTermId");
                });

            modelBuilder.Entity("School.Models.Attendance", b =>
                {
                    b.HasOne("School.Models.Student")
                        .WithMany("Atendances")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("School.Models.Department", b =>
                {
                    b.HasOne("School.Models.Teacher", "DepartmentHead")
                        .WithOne("DepartmentHeading")
                        .HasForeignKey("School.Models.Department", "DepartmentHeadId");
                });

            modelBuilder.Entity("School.Models.DepartmentSubject", b =>
                {
                    b.HasOne("School.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("School.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("School.Models.Exam", b =>
                {
                    b.HasOne("School.Models.Term", "Term")
                        .WithMany()
                        .HasForeignKey("TermId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("School.Models.DepartmentSubject", "DepartmentSubject")
                        .WithMany()
                        .HasForeignKey("DepartmentSubjectDepartmentId", "DepartmentSubjectSubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("School.Models.Message", b =>
                {
                    b.HasOne("School.Models.ApplicationUser", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("School.Models.Test", b =>
                {
                    b.HasOne("School.Models.Term", "Term")
                        .WithMany()
                        .HasForeignKey("TermId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("School.Models.DepartmentSubject", "DepartmentSubject")
                        .WithMany()
                        .HasForeignKey("DepartmentSubjectDepartmentId", "DepartmentSubjectSubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("School.Models.Student", b =>
                {
                    b.HasOne("School.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("School.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("School.Models.Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("School.Models.Teacher", b =>
                {
                    b.HasOne("School.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
