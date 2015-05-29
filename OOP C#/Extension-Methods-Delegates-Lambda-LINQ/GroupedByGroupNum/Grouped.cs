using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupedByGroupNum
{
    class Grouped
    {
        static void Main()
        {

            Student studentOne = new Student { FirstName = "Georgi", LastName = "Georgiev", FN = "212424", Tel = "02776655", Email = "georgiev@gmail.com", Group = 3, Marks = { 5, 5, 4, 5, 2 } };
            Student studentTwo = new Student { FirstName = "Petar", LastName = "Petrov", FN = "126406", Tel = "0899151515", Email = "petrov@dir.bg", Group = 2, Marks = { 6, 6, 6, 3, 5 } };
            Student studentThree = new Student { FirstName = "Dimitar", LastName = "Dimitrov", FN = "263406", Tel = "0899101010", Email = "dimitrov@yahoo.com", Group = 1, Marks = { 4, 3, 6, 5, 2 } };
            Student studentFour = new Student { FirstName = "Blagoi", LastName = "Blagoev", FN = "122329", Tel = "0899898989", Email = "blagoev@abv.bg", Group = 2, Marks = { 4, 3, 4, 5, 2 } };
            Student studentFive = new Student { FirstName = "Rosen", LastName = "Rosenov", FN = "136332", Tel = "02121233", Email = "rosenov@yahoo.com", Group = 3, Marks = { 2, 2 } };

            List<Student> myList = new List<Student>();
            myList.Add(studentOne);
            myList.Add(studentTwo);
            myList.Add(studentThree);
            myList.Add(studentFour);
            myList.Add(studentFive);

            var groupedStudents = 
                from student in myList
                group student by student.Group
                into groups
                select new 
                {
                    Group = groups.Key,
                    Students = groups.ToList()
                };
            foreach (var grouped in groupedStudents)
            {
                Console.WriteLine("\nGroup: {0} Students: \n{1}", grouped.Group,
                string.Join("\r\n\r\n", grouped.Students));
            }
   


            // Problem 19

            var grouped2 = myList.GroupBy(x => x.Group,
                  (groupNumber, students) => new { Group = groupNumber, Students = students });

         
        }

    }
}
