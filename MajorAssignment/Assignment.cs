using System;
using System.Collections.Generic;
using System.Text;

namespace MajorAssignment {
    class Assignment {
        public int Id;
        public string Desc;
        public int ClassId;

        public Assignment(int id, string desc, int classid) {
            Id = id;
            Desc = desc;
            ClassId = classid;

        }
        public void Print() {
            Console.WriteLine($"Assignment info {Id} {Desc} {ClassId}");
        }

    }
}
