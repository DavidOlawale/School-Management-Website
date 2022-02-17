using Microsoft.EntityFrameworkCore;
using Moq;
using School.Controllers.Api;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace School.Tests
{
    public class UnitTest1
    {
        private Random rand = new Random();
        private int randomNumber => rand.Next(1000);
        [Fact]
        public void ExamsControllerTests()
        {
            //var dbContextStub = new Mock<School.Data.ApplicationDbContext>();
            //dbContextStub.Setup(db => db.Exams)
            //    .Returns(new DbSet<Exam>())
            //var examControllerStub = new ExamsController();
        }

        private Exam CreateRandonExam()
        {
            return new Exam
            {
                DepartmentSubjectDepartmentId = randomNumber,
                DepartmentSubjectSubjectId = randomNumber,
                Score = randomNumber,
                StudentId = Guid.NewGuid(),
                TermId = randomNumber
            };
        }
    }
}
