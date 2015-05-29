using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBeforeLast
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
        public Student()
        {

        }
        public Student(string fn, string ln,int age)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.Age = age;
        }
    }
}
