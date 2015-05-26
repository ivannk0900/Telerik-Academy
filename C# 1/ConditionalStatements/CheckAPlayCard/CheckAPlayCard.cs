//  Problem 3. Check for a Play Card
//    Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and
//    prints “yes” if it is a valid card sign or “no” otherwise.

using System;

class CheckAPlayCard
{
    static void Main()
    {
        Console.Write("enter a sign that you want to check ");
        string checker = Console.ReadLine();

        int number;  

        bool ifNum = int.TryParse(checker, out number);
        if(ifNum)
        {
             if (int.Parse(checker)>=2&&int.Parse(checker)<=9)
             { 
                 Console.WriteLine("yes");
             }
             else Console.WriteLine("no");
        }
        else
        {
            if(checker=="J"||checker=="A"||checker=="Q"||checker=="K")
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
        


    }
}

