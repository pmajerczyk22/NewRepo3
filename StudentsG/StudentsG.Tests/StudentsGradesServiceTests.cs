using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using StudentsGrades.Models;
using StudentsGrades.Services;


namespace StudentsGrades.Tests
{
    [TestClass]
    public class StudentsGradesServiceTests
    {

        [TestMethod]
        public void Calculate_ShouldReturnCorrectResult()
        {
            //Arrange 
            var list = new List<Grade>
            {
                new Grade
                {
                    Value =5,
                    Weight =2
                },
                new Grade
                {
                    Value=4,
                    Weight=3
                }
            };
            //Act
            var result = ServiceUnderTests.Calculate(list);

            //Arrange 
            Assert.AreEqual(4.4M, result);

        }
            #region CONFIGURATION
            StudentGradeService ServiceUnderTests;

            public StudentsGradesServiceTests()
            {
            ServiceUnderTests = new StudentGradeService();
            }

            #endregion
        

    }
}
