using System;


namespace CorrectBrackets
{
    class Correct
    {
        static void Main()
        {
            int countLeft = 0;
            int countRight = 0;
            Console.WriteLine("enter the expression");
            string expression = Console.ReadLine();

            foreach(var symbol in expression)
            {
                if(symbol=='(')
                {
                    countRight++;
                }
                if(symbol==')')
                {
                    countLeft++;
                }
            }
            if(countLeft==countRight)
            {
                Console.WriteLine("the brackets of the expression are CORRECT");
            }
            else
            {
                Console.WriteLine("the brackets are NOT in correct format");
            }

        }
    }
}
