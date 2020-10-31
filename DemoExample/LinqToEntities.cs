using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoExample
{
    class LinqToEntities
    {
        public static void Entities()
        {
            Student[] studentArray = {
                    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
                    new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 } ,
                    new Student() { StudentID = 7, StudentName = "Rob",Age = 19  } ,
                };
            //this query is used to find the students of ages between 12 and 20 and store it in array
            Student[] teenAgerStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

            foreach (Student student in teenAgerStudents)
            {
                Console.WriteLine("Id:-" + student.StudentID + " " + "Name:-" + student.StudentName + " " + "Age:-" + student.Age);
                Console.WriteLine("\n");
            }

            // Use LINQ to find first student whose name is Bill 
            Student bill = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();
            Console.WriteLine("Id:-" + bill.StudentID + " " + "Name:-" + bill.StudentName + " " + "Age:-" + bill.Age);

            //Use LINQ to find student whose StudentID is 5
            Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();
        }
    }
}
