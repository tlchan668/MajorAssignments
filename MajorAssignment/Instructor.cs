using System;
using System.Collections.Generic;
using System.Text;

namespace MajorAssignment {
    class Instructor {
        public int Id;
        public string Firstname;
        public string Lastname;
        public int YearsExperience;
        public bool IsTenured;

        public Instructor(int id, string firstname, string lastname, int yearsexperienced, bool istenured) {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            YearsExperience = yearsexperienced;
            IsTenured = istenured;

        }
        public void Print() {
            Console.WriteLine($"Instructorinfo {Id} {Firstname} {Lastname} {YearsExperience} {IsTenured} {IsTenured}");
        }

    }
}
