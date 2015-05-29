using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBeforeLast
{
    class FirstBeforeLast
    {
        static void Main()
        {
            var listOfStudent = new List<Student>();
            Student studentOne = new Student("andrei", "petrov",20);
            Student studentTwo = new Student("georgi", "andreev",14);
            Student studentThree = new Student("petar", "petrov",35);

            listOfStudent.Add(studentOne);
            listOfStudent.Add(studentTwo);
            listOfStudent.Add(studentThree);

            var firstBeforeLast = listOfStudent.Where(s => s.FirstName.CompareTo(s.LastName) < 0);

            Console.WriteLine("problem 3 first before last");
            foreach (var item in firstBeforeLast)
            {
                Console.WriteLine("{0} {1}",item.FirstName,item.LastName);
            }
            Console.WriteLine();
            Console.WriteLine("problem 4 age range");

            var ageRange = listOfStudent.Where(s => s.Age >= 18 && s.Age <= 24);

            foreach (var item in ageRange)
            {
                Console.WriteLine("{0} {1}",item.FirstName,item.LastName);
            }

            Console.WriteLine();
            Console.WriteLine("problem 5 oreder students");

            var sortedStudents = listOfStudent.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName);
            foreach (var item in sortedStudents)
            {
                Console.WriteLine("{0} {1}",item.FirstName,item.LastName);
            }
                
           
        }
    }
}
