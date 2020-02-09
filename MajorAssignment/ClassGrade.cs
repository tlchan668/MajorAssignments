using System;
using System.Collections.Generic;
using System.Text;

namespace MajorAssignment {
    class ClassGrade {
        public int Grade;
        public double GPA;

        public ClassGrade(int grade, int gpa) {
            Grade = grade;
            GPA = gpa;

        }
        public void Print() {
            Console.WriteLine($"ClassGrade info {Grade} {GPA}");
        }

    }
}
