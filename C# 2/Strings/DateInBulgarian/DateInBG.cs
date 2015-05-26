using System;
// Write a program that reads a date and time given in the format:
// day.month.year hour:minute:second and prints the date and time 
// after 6 hours and 30 minutes (in the same format) along with the
// day of week in Bulgarian.

namespace DateInBulgarian
{
    class DateInBG
    {
        static void Main()
        {
            Console.WriteLine("enter the date as follows : day.month.year hour:minute:second");
            string dateString = (Console.ReadLine());

            try
            {
                DateTime date = DateTime.ParseExact(dateString, "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.CreateSpecificCulture("bg-BG"));
                DateTime newDate = date.AddHours(6).AddMinutes(30);
                Console.WriteLine("{0},{1}", newDate, newDate.DayOfWeek);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("incorrect input");
            }

           
          
        }
    }
}
