using System;
using System.Collections.Generic;
using System.Text;

namespace MajorAssignment {
    class StudentClassRel {
        public int Id;
        public int StudentId;
        public int ClassId;
        public string GradeValue;

        public StudentClassRel(int id, int studentid, int classid, string gradevalue) {
            Id = id;
            StudentId = studentid;
            ClassId = classid;
            GradeValue = gradevalue;

        }
        public void Print() {
            Console.WriteLine($"StudentClassRel info {Id} {StudentId} {ClassId} {GradeValue}");
        }

    }
}
