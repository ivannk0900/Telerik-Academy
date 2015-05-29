using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class School
    {
        public List<ClassOfStudents> Classes;

        public School()
        {
            this.Classes = new List<ClassOfStudents>();
        }
    }
}
