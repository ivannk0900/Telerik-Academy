using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
   public class Disciplines
    {
        public string Name { get; set; }

        public int NumberOfLectures { get; set; }

        public int NumberOfExercises { get; set; }

        public Disciplines(string name , int nl , int ne)
        {
            this.Name = name;
            this.NumberOfExercises = ne;
            this.NumberOfLectures = nl ;
        }
    }
}
