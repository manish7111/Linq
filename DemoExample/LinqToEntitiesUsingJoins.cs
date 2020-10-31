using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoExample
{
    class LinqToEntitiesUsingJoins
    {
        public static void EntitiesUsingJoin()
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 ,StandardId=1} ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 ,StandardId=1} ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25,StandardId=2 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 ,StandardId=2} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 ,StandardId=3}
            };
            IList<Standard> standardList = new List<Standard>()
            {
                new Standard(){StandardID=1,StandardName="Standard 1"},
                new Standard(){StandardID=2,StandardName="Standard 2"},
                new Standard(){StandardID=3,StandardName="Standard 3"}
            };
            var innerJoin = studentList.Join(
                standardList,
                student => student.StandardId,
                standard=>standard.StandardID,
                (student, standard) => new
                {
                    student.StudentName,
                    standard.StandardName
                }
                );
            foreach(var obj in innerJoin)
            {
                Console.WriteLine("{0} - {1}",obj.StudentName,obj.StandardName);
            }
        }
    }
}
