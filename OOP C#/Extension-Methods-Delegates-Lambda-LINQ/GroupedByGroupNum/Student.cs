using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupedByGroupNum
{
   public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public int Group { get; set; }

        private List<int> marks = new List<int>();

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                this.marks = value;
            }
        }





        public override string ToString()
        {
            string marks = String.Join(", ", Marks);

            return FirstName + " " + LastName + " FN: " + FN + " Telephone: " + Tel + " Email: " + Email + " Group:" + Group + " Marks: " + marks;
        }
    }
}
