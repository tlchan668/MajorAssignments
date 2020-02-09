using System;
using System.Collections.Generic;
using System.Text;

namespace MajorAssignment {
    class Major {
        public int Id;
        public string Desc;
        public int MinSat;

       public Major(int id, string desc, int minsat) {
            Id = id;
            Desc = desc;
            MinSat = minsat;
            
        }
        public void Print() {
            Console.WriteLine($"Major info {Id} {Desc} {MinSat}");
        }

    }
 }
