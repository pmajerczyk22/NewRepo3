
﻿using StudentsGrades.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StudentsGrades.Services
{
    public class StudentGradeService
    {
        public decimal Calculate(IEnumerable<Grade> grades)
    {
            var gradesSum = grades.Sum(g => g.Value * g.Weight);
            return gradesSum / grades.Sum(g => g.Weight);
        }

    }

}