using StudentsGrades.Models;
using StudentsGrades.Services;
using System;
using System.Collections.Generic;
using Xunit;


namespace StudentsGrades.Tests.Xunit
{
    public class StudentsGradeServiceTests
    {
        [Fact]
        public void Calculate_ShouldReturnCorrectResult() 
        {
            //Arrange
            var list = new List<Grade>
            {
                new Grade
                {
                    Value=5,
                    Weight=2
                },
                new Grade
                {
                    Value=4,
                    Weight=3
                }
            };

            //Act
            var result = serviceUnderTests.Calculate(list);
            //Arrange
            Assert.Equal(4.4M, result);

        }
        #region CONFIGURATION
        StudentGradesService serviceUnderTests;

        public StudentsGradeServiceTests()
        {
            serviceUnderTests = new StudentGradesService();
        }
        #endregion
    }
}

