using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Frog : Animals
    {
         public Frog(string name, int age, Gender sex)
            :base(name,age,sex)
        {

        }
 

        public override string ProduceSound()
        {
            return "Kwak Kwak";
        }
    }
}
