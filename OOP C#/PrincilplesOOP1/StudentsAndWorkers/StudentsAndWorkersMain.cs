using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class StudentsAndWorkersMain
    {
        static void Main()
        {
            List<Student> students= new List<Student>()
            {
               new Student("ivan", "ivanov", 1),
               new Student("georgi", "ivanov", 5),
               new Student("pesho", "ivanov", 2),
               new Student("dimitur","ivanov", 4),
               new Student("ivan", "petrov", 8),
               new Student("ivan", "georgiev", 1),
               new Student("ivan", "dimitrov", 6),
               new Student("angel", "ivanov", 11),
               new Student("denis", "ivanov", 10),
               new Student("kiril", "ivanov", 9)
            };

            var studentsSortedByGrade = students.OrderBy(g => g.Grade);
            Console.WriteLine("Students sorted by grade:");
            foreach (var stud in studentsSortedByGrade)
            {
                Console.WriteLine(stud);
            }
            Console.WriteLine();
            Console.WriteLine();

            List<Worker> workers = new List<Worker>()
            {
               new Worker("ivan", "ivanov",40m,40), 
               new Worker("gosho", "ivanov",40m,30), 
               new Worker("pesho", "ivanov",50m,20), 
               new Worker("kristiqn", "ivanov",80m,43), 
               new Worker("blagoi", "ivanov",10m,42), 
               new Worker("georgi", "ivanov",56m,41), 
               new Worker("nikolai", "ivanov",40m,46), 
               new Worker("dimitur", "ivanov",47m,31), 
               new Worker("mitio", "ivanov",34m,44), 
               new Worker("kolio", "ivanov",64m,40)
               
            };

            Console.WriteLine("Workers sorted by money per hour");
            var workersSortedByMoneyPerHour= workers.OrderByDescending(m => m.MoneyPerHour());
            foreach (var worker in workersSortedByMoneyPerHour)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();
            Console.WriteLine();

            var merged = new List<Human>();
            merged.AddRange(students);
            merged.AddRange(workers);

            var allSortedByName = merged
                .OrderBy(n => n.FirstName)
                .ThenBy(n => n.LastName)
                .ToList();

            foreach (var human in merged)
            {
                Console.WriteLine(String.Format("{0} {1}", human.FirstName, human.LastName));
            }
        }
    }
}
