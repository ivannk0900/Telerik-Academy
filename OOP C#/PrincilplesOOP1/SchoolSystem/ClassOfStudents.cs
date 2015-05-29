using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class ClassOfStudents : IComment
    {
        public List<Teacher> Teachers;
        public string Identifier { get; private set; }

        public ClassOfStudents(string id)
        {
            this.Teachers = new List<Teacher>();
            this.Identifier = id;
        }

        string commment { get; set; }



        public void AddComment(string comment)
        {
            this.commment = commment;
        }

        public override string ToString()
        {
            return Identifier;
        }
    }
}
