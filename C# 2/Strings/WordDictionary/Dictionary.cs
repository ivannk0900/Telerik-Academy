using System;
using System.Collections.Generic;


namespace WordDictionary
{
    class Dictionary
    {
        static void Main()
        {
            Dictionary<string,string> dict = new Dictionary<string, string>();
            dict.Add(".NET", "platform for applications from Microsoft");
            dict.Add("CLR","managed execution environment for .NET");
            dict.Add("namespace","hierarchical organization of classes");

            Console.WriteLine("enter word");
            string input = Console.ReadLine();
            if(dict.ContainsKey(input))
            {
                foreach(var item in dict)
                {
                    if(item.Key==input)
                    {
                        Console.WriteLine(item.Value);
                    }
                }
            }
            else
            {
                Console.WriteLine("no item found");
            }
        }
    }
}
