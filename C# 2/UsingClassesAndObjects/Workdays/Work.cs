using System;
using System.Globalization;

namespace Workdays
{
    class Work
    {
        static void Main()
        {
            DateTime[] publicHolidays = new DateTime[]
            {
                new DateTime(2015,1,1),
                new DateTime(2015,1,6),
                new DateTime(2015,1,7),
                new DateTime(2015,3,3),
                new DateTime(2015,4,10),
                new DateTime(2015,4,13),
                new DateTime(2015,5,1),
                new DateTime(2015,5,6),
                new DateTime(2015,5,24),
                new DateTime(2015,9,6),
                new DateTime(2015,9,22),
                new DateTime(2015,12,24),
                new DateTime(2015,12,25),
                new DateTime(2015,12,26),
                new DateTime(2015,12,31),

            };


            Console.Write("Enter the date you want to calculate as follows:\nYYYY-MM-DD: ");
            DateTime lastDate = DateTime.Parse(Console.ReadLine());
            DateTime startdate = DateTime.Now;
            DateTime sameStartDate = startdate;

            double thePeriod = (lastDate - startdate).Days; // total number of days/all days
            double allDays = thePeriod;
            Console.WriteLine("all days {0}", thePeriod);

           
            for (int i = 0; i <= allDays; i++)
            {


                if (sameStartDate.DayOfWeek == DayOfWeek.Saturday || sameStartDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    thePeriod--;
                }

                sameStartDate = sameStartDate.AddDays(1);
            } 
            foreach (var item in publicHolidays)
            {
                if (sameStartDate.Day== item.Day)
                {
                    thePeriod--;
                }
            }

            Console.WriteLine("without the holydays {0}", thePeriod);




        }
    }
}
