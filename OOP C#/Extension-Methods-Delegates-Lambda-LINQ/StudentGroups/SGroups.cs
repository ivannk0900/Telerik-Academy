using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    class SGroups
    {
        static void Main()
        {
            List<Student> myList = new List<Student>();

            Student studentOne = new Student();
             studentOne.FirstName = "Ivan";
            studentOne.LastName = "Ivanov";
            studentOne.FN = "122934";
            studentOne.Tel = "0899123456";
            studentOne.Email = "ivanov@abv.bg";
            studentOne.Group = 2;
            studentOne.Marks.Add(2);
            studentOne.Marks.Add(3);
            studentOne.Marks.Add(4);
         
            Student studentTwo = new Student { FirstName = "Georgi", LastName = "Georgiev", FN = "212424", Tel = "02776655", Email = "georgiev@gmail.com", Group = 3, Marks = { 5, 5, 4, 5, 2 } };
            Student studentThree = new Student { FirstName = "Petar", LastName = "Petrov", FN = "126406", Tel = "0899151515", Email = "petrov@dir.bg", Group = 2, Marks = { 6, 6, 6, 3, 5 } };
            Student studentFour = new Student { FirstName = "Dimitar", LastName = "Dimitrov", FN = "263406", Tel = "0899101010", Email = "dimitrov@yahoo.com", Group = 1, Marks = { 4, 3, 6, 5, 2 } };
            Student studentFivve = new Student { FirstName = "Blagoi", LastName = "Blagoev", FN = "122329", Tel = "0899898989", Email = "blagoev@abv.bg", Group = 2, Marks = { 4, 3, 4, 5, 2 } };
            Student studentSix = new Student { FirstName = "Rosen", LastName = "Rosenov", FN = "136332", Tel = "02121233", Email = "rosenov@yahoo.com", Group = 3, Marks = { 2, 2 } };
            myList.Add(studentOne);
            myList.Add(studentTwo);
            myList.Add(studentThree);
            myList.Add(studentFour);
            myList.Add(studentFivve);
            myList.Add(studentSix);


           
            var fromGroupTwo =
                from stud in myList
                where stud.Group == 2
                select stud;

            var orderedFromGroupTwo = fromGroupTwo.OrderBy(s => s.FirstName);

            Console.WriteLine("Problem 9: All students form group 2,ordered by first name");
            foreach (var student in orderedFromGroupTwo)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();
            Console.WriteLine();


            // problem 10 
            Console.WriteLine("Problem 10:  All students form group 2,ordered by first name expressed with extension methods");
            var studentsFromGr2Orederd = myList.OrderBy(s => s.FirstName).Where(s => s.Group == 2);
            foreach (var student in studentsFromGr2Orederd)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine();

            //Problem 11

            var mailInAbv = myList.Where(s => s.Email.Contains("abv.bg"));
            Console.WriteLine("Problem 11: All students that have mail in abv");
            foreach (var stud in mailInAbv)
            {
                Console.WriteLine(stud);
            }
            Console.WriteLine();
            Console.WriteLine();

            // Problem 12

            Console.WriteLine("Problem 12: All students that have phone in Sofia");
            var phoneInSofia = myList.Where(s => s.Tel.StartsWith("02"));
            foreach (var stud in phoneInSofia)
            {
                Console.WriteLine(stud);   
            }
            Console.WriteLine();
            Console.WriteLine();

            // problem 13
            Console.WriteLine("Problem 13");
            var anonStudWithExellent = 
                from stud in myList
                where stud.Marks.Contains(6)
                select new 
                {
                    Fullname = stud.FirstName+" "+stud.LastName,
                    Marks = String.Join(" ",stud.Marks)
                    
                };

            foreach (var student in anonStudWithExellent)
            {

                Console.WriteLine(student.Fullname + " " + student.Marks);
            }

            // Problem 14
            Console.WriteLine();
            Console.WriteLine("Students with two 2");
            Console.WriteLine();

            var withTwo2 = myList.Where(s => s.Marks.FindAll(d => d == 2).Count == 2);

            foreach (var stud  in withTwo2)
            {
                Console.WriteLine(stud);
            }

            // Problem 15
            Console.WriteLine();
            Console.WriteLine("Students enrolled in 2006 marks");
            Console.WriteLine();

            var enrolled = myList.Where(s => s.FN[4] == '0' && s.FN[5] == '6');
            foreach (var stud in enrolled)
            {
                Console.WriteLine(stud);
            }



           
            


        }
    }
}
