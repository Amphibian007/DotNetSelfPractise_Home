using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace LInqPractise1
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> Students = new List<Student>
           {
           new Student{Name="Dipto",Age=25,StandardId=1},
           new Student{Name="Pias",Age=25,StandardId=1},
           new Student{Name="Sujan",Age=17,StandardId=2},
           new Student{Name="Prokash",Age=26,StandardId=2},
           new Student{Name="Ram",Age=20,StandardId=2},
           new Student{Name="Ram",Age=20,StandardId=3},
           new Student{Name="Akash",Age=24}
           };
            IList<Standard> Standards = new List<Standard>
            {
                new Standard{StandardId=1,StandardName="Standard One"},
                new Standard{StandardId=2,StandardName="Standard two"},
                new Standard{StandardId=3,StandardName="Standard three"}
            };

            //var joinList = Students.Join(Standards,
            //    student => student.StandardId,
            //    standard => standard.StandardId,
            //    (student, standard) => new
            //    {
            //        StudentFullName = student.Name,
            //        StandardFullName = student.StandardId
            //    }
            //    );

            //foreach (var student in joinList)
            //{
            //    Console.WriteLine(student.StudentFullName + " " + student.StandardFullName);
            ////}
            //var groupJoinList = Standards.GroupJoin(Students,
            //    std => std.StandardId,
            //    stu => stu.StandardId,
            //    (hot, cold) => new
            //    {
            //        Students = cold,
            //        stdFullName=hot.StandardName
            //    }
            //    );
            //foreach(var item in groupJoinList)
            //{
            //    Console.WriteLine(item.stdFullName);
            //    foreach(var stu in item.Students)
            //    {
            //        Console.WriteLine($"{stu.Name} and standard {stu.StandardId}");
            //    }
            //}
            //var anyList = Students.All(s => s.Age > 12 && s.Age < 28);
            //Console.WriteLine(anyList);
            //var std1 = new Student();
            //Console.WriteLine(std1.GetHashCode());
            var checkStudent = new Student { Name = "Ram", Age = 20 };
            var reallyContains = Students.Contains(checkStudent, new StudentComparer());
            Console.WriteLine(reallyContains);
        }
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int StandardId { get; set; }
        }
        public class Standard
        {
            public int StandardId { get; set; }
            public string StandardName { get; set; }
        }
        public class StudentComparer : IEqualityComparer<Student>
        {
            public bool Equals(Student x, Student y)
            {
                if (x.Name == y.Name && x.Age == y.Age)
                    return true;
                return false;
            }

            public int GetHashCode(Student obj)
            {
                return obj.GetHashCode();
            }
        }
    }
}
