using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Cat : Animals
    {
        public Cat(string name,int age,Gender sex)
            :base(name,age,sex)
        {

        }


        public override string ProduceSound()
        {
            return "Meow Meow";
        }


    }
}
