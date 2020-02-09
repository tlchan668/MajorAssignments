using System;

namespace MajorAssignment {
    class Program {
        static void Main(string[] args) {
           
            //var accounting = new Major(100, "Accounting", 1000);
           // var business = new Major(200, "Business", 800);
            //var engineering = new Major(300, "Engineering", 500);
            //var math = new Major(400, "Math", 1300);
            
            //create an array of majors
            //var majors = new Major[4];
            //alternate to specify how many items in an array by when you create it takes place of above
            var majors = new Major[]{
                    new Major(100, "Accounting", 1000),//this will be read in from DB
                    new Major(200, "Business", 800),
                    new Major(300, "Engineering", 500),
                    new Major(400, "Math", 1300),
                    new Major(500, "Education", 1100)
            };
            //put majors in array this is done above
            //majors[0] = accounting;
            //majors[1] = business;
            //majors[2] = engineering;//refers to the major var
            //majors[3] = math;
            //print of all things in our array using for loop == simplified way
            //allows to work with as many majors as have
            for (var idx = 0; idx < majors.Length; idx++) {
                var major = majors[idx];
                major.Print();//instance of the major class
            }
            //accounting.Print();
            //business.Print();
            //engineering.Print();

            //do same thing for student
            //create array
            var students = new Student[] {
                new Student(2, "Leia", "Chan", 1000, 3.8, majors[2]),
                new Student(3, "Katarina", "Chan", 1500, 4.3, majors[1]),
                new Student(4, "Fred", "Chan", 500, 1.3, majors[1]),
                new Student(1, "Traci","Chan", 1200, 4.0, majors[0])

            };//defining data gets a semicolon after brace

            //different way to loop through data
            foreach(var student in students) {
                student.Print();
            }
            var class1 = new Class(1, "math", 100, 55);
            var class2 = new Class(2, "english", 800, 66);
            var class3 = new Class(3, "history", 500, 77);

            class1.Print();
            class2.Print();
            class3.Print();

            //change student1 to name
            //this is now like a join view..shows 
            //student1.Print();
            //student2.Print();
            //student3.Print();
            //fred.Print();

           

        }

        }
    }
