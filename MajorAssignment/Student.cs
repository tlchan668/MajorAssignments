using System;
using System.Collections.Generic;
using System.Text;

namespace MajorAssignment {
    class Student{
        public int Id;
        public string Firstname;
        public string Lastname; 
        public int SAT;
        public double GPA;
        public Major Major;

        public Student(int id, string firstname, string lastname, 
            int sat, double gpa, Major  major) {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            SAT  = sat;
            GPA = gpa;
            Major = major;

        }
        public void Print() {
            Console.WriteLine($"Studentinfo {Id}, name={Firstname} {Lastname}, SAT={SAT}, GPA={GPA},  " +
                $"Desc={Major.Desc} { Major.MinSat} ");
        }

    }
}
