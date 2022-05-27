using StudentsGrades.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentsGrades.Services
{
    public class StudentGradesService
    {
        public decimal Calculate(IEnumerable<Grade> grades) //Czym jest parametr w grades oraz IEnumerable
        {
            var gradesSum = grades.Sum(g => g.Value * g.Weight);
            return gradesSum/grades.Sum(g=>g.Weight);
        }
    }
}
