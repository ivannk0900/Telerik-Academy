// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;


namespace DateDifference
{
    class Difference
    {
        static void Main()
        {
            Console.WriteLine("enter the first date as follows:\nYYYY.MM.DD:");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("enter the second date as follows:\nYYYY.MM.DD:");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            double difference = (secondDate-firstDate).Days;
            Console.WriteLine(Math.Abs(difference));                         
        }
    }
}
