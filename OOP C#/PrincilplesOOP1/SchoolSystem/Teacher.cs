using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
   public class Teacher : Human
    {
       public List<Disciplines> Disciplines;
       public Teacher(string name)
       {
           base.Name = name;
           this.Disciplines = new List<Disciplines>();
       }
    }
}
