using System;
using System.Collections.Generic;
using System.Linq;


namespace AnimalHierarchy
{
    class HieararchyMain
    {
        public static double AverageAge(Animals[] arr)
        {
            return arr.Average(x => x.Age);
        }

        static void Main()
        {

            Cat[] catArr = new Cat[] 
            {
            new Cat("Maca", 5, Gender.Female),
            new Cat("Pisana", 5, Gender.Female),
            new Cat("Macmac", 8, Gender.Male)
            };
            Dog[] dogArr = new Dog[]
            {
                new Dog("Sharo", 4, Gender.Female),
                new Dog("Rex", 3, Gender.Female),
                new Dog("Cezar", 8, Gender.Female)
            };

            Frog[] frogArr = new Frog[]
            {
                new Frog("Janburan", 1, Gender.Male),
                new Frog("Jaburana", 1, Gender.Female),
                new Frog("Frogie", 1, Gender.Male)
            };

            Kittens[] kittensArr = new Kittens[]
            {
                new Kittens("Lucy",2),
                new Kittens("Tracy",4)
            };

            Tomcat[] tomcatArr = new Tomcat[]
            {
                new Tomcat("Tommy",1),
                new Tomcat("Arnold",2)
            };




            Console.WriteLine("Kittens: {0:F2}", AverageAge(kittensArr));
            Console.WriteLine("Tomcats: {0:F2}", AverageAge(tomcatArr));
            Console.WriteLine("Frogs: {0:F2}", AverageAge(frogArr));
            Console.WriteLine("Dogs: {0:F2}", AverageAge(dogArr));
            Console.WriteLine("Cats: {0:F2}", AverageAge(catArr));
        }

    }
}
