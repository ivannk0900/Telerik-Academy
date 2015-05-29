using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Student : Human, IComment
    {

        public int ClassNumber { get; set; }


        public string comment { get; set; }




        public void AddComment(string comment)
        {
            this.comment = comment;
        }
    }
}
