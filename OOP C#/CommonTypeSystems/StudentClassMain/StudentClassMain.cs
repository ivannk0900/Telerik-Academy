namespace StudentClassMain
{
    using System;
    class StudentClassMain
    {
 
        static void Main()
        {
            Student student1 = new Student("Ivan", "Ivanov", "Ivanov", 9011237754, "Tsar Osvoboditel 1", "ivanov@abv.bg", 0899123456, 2,Student.Universityies.SofiaUniversity,Student.Faculties.FacultyOfEconomics,Student.Specialities.Informatics);
            Student student2 = new Student("Ivan", "Ivanov", "Ivanov", 9011237754, "Tsar Osvoboditel 1", "ivanov@abv.bg", 0899123456, 2, Student.Universityies.SofiaUniversity, Student.Faculties.FacultyOfEconomics, Student.Specialities.Informatics);
          
            Console.WriteLine(student1.CompareTo(student2));

            object clooned = student1.Clone();
            Console.WriteLine(clooned);
        }
    }
}
