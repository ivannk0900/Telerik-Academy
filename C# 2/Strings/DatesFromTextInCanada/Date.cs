﻿using System;
using System.Globalization;
using System.Text.RegularExpressions;


namespace DatesFromTextInCanada
{
    class Date
    {
        static void Main()
        {
            string text = Console.ReadLine();
            Console.WriteLine("Extracted dates from the sample text: ");
            foreach (Match item in Regex.Matches(text, @"\b[0-9]{1,2}.[0-9]{1,2}.[0-9]{2,4}"))
            {
                DateTime date;
                if (DateTime.TryParseExact(item.Value, "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Console.WriteLine("- " + date.ToString(CultureInfo.GetCultureInfo("en- CA").DateTimeFormat.ShortDatePattern));
                }
            }
            Console.WriteLine();
        }
    }
}
