using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Student : Human
    {
        private int grade;

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("grade must be > 1");
                }
                else
                {
                    this.grade = value;
                }
            }
        }

        public Student(string firstName , string lastName, int grade)
            : base(firstName,lastName)
        {
            this.grade = grade;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName+ " " +Grade;
        }

    }
}
