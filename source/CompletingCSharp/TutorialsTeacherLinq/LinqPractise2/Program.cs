using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace LinqPractise2
{
    class Program
    {
        static void Main(string[] args)
        {

            IList<Student> allStudents = new List<Student>
            {
            new Student{Name="Dipto",Age=25,StandardId=1},
            new Student{Name="Pias",Age=25,StandardId=1},
            new Student{Name="Sujan",Age=17,StandardId=2},
            new Student{Name="Prokash",Age=26,StandardId=2},
            new Student{Name="Ram",Age=20,StandardId=2},
            new Student{Name="Ram",Age=20,StandardId=3},
            new Student{Name="Akash",Age=24}
            };
            IList<Student> allStudents2 = new List<Student>
            {
            new Student{Name="Dipto",Age=25,StandardId=1},
            new Student{Name="Pias",Age=25,StandardId=1},

            };
            // string[] name1 = { "Dipto", "Pias", "Sujon" };
            // string[] name2 = { "Dipto2", "Pias2", "Sujon2" };
            // var name3 = name1.Concat(name2);
            // Console.WriteLine(string.Join(',',name3));
            // var students = allStudents.Concat(allStudents2);
            // foreach(var student in students)
            //     Console.WriteLine(student.Name);

            //IList<Student> studentList = new List<Student>();
            //var newList1 = studentList.DefaultIfEmpty(new Student());
            //Console.WriteLine(newList1.Count());
            //Console.WriteLine(studentList.ElementAtOrDefault(0));

            //var list1 = Enumerable.Empty<string>();
            //Console.WriteLine(list1.GetType());
            //Console.WriteLine(list1.Count());

            //var stringCollection = Enumerable.Repeat("Dipto", 5);
            //Console.WriteLine(string.Join(',',stringCollection));
            IList<string> stringList = new List<string> { "one", "two", "one", "three", "two", "one" };
            IList<string> stringList2 = new List<string> {"two","four","three" };
            IList<int> intList = new List<int> {  };
            var skipList = stringList.TakeWhile(s=>s.Length<4);
            Console.WriteLine(string.Join(',',skipList));
        }
    }
    public class Student:IEqualityComparer<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int StandardId { get; set; }

        public bool Equals(Student x,Student y)
        {
            if (x.Name.ToLower() == y.Name.ToLower())
                return true;
            return false;
        }


        public int GetHashCode([DisallowNull] Student obj)
        {
            return obj.GetHashCode();
        }
    }
}
