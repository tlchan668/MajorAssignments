using System;
using System.Collections.Generic;
using System.Text;

namespace MajorAssignment {
    class Class {
        public int Id;
        public string Subject;
        public int Section;
        public int InstructorId;

       public Class(int id, string subject, int section, int instructorid) {
            Id = id;
            Subject = subject;
            Section = section;
            InstructorId = instructorid;
            
        }
        public void Print() {
            Console.WriteLine($"Class info {Id} {Subject} {Section} {InstructorId}");
        }

    }
 }
