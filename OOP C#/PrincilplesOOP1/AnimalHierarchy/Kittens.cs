﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Kittens : Cat
    {
        public Kittens(string name, int age)
            : base(name, age, Gender.Female)
        {
        }
    }
}
