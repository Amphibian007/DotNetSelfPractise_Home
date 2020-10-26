using System;
using System.Collections.Generic;
using System.Text;

namespace DIPractise1
{
    public class StudentBL
    {
        public StudentBAL studentBAL1;
        public List<Student> GetStudents()
        {
            studentBAL1 = new StudentBAL();
            return studentBAL1.ShowStudents();
        }
    }
}
