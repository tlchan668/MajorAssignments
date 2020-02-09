using System;
using System.Collections.Generic;
using System.Text;

namespace MajorAssignment {
    class MajorClassRel {
        public int Id;
        public int MajorId;
        public int ClassId;

        public MajorClassRel(int id, int majorid, int classid) {
            Id = id;
            MajorId = majorid;
            ClassId = classid;

        }
        public void Print() {
            Console.WriteLine($"MajorClassRel info {Id} {MajorId} {ClassId}");
        }

    }
}
