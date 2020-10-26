using System;
using System.Collections.Generic;
using System.Text;

namespace DIPractise1
{
    public class StudentBAL
    {
        public List<Student> ShowStudents()
        {
            List<Student> Allstudents = new List<Student>();
            Allstudents.Add(new Student { Id = 5, Name = "Dipto" });
            Allstudents.Add(new Student { Id = 6, Name = "Sujan" });

            return Allstudents;
        }

    }
}
