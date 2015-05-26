//Problem 2. Bonus Score

//    Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//        If the score is between 1 and 3, the program multiplies it by 10.
//        If the score is between 4 and 6, the program multiplies it by 100.
//        If the score is between 7 and 9, the program multiplies it by 1000.
//        If the score is 0 or more than 9, the program prints “invalid score”.


using System;

class BonusScore
{
    static void Main()
    {
        int givenScore = 7;
        if (givenScore <= 0 || givenScore >= 10) { Console.WriteLine("Invalid score"); return; }
        if(givenScore>=1&&givenScore<=3)
        {
            givenScore = givenScore * 10;
        }
        else if(givenScore>=4&&givenScore<=6)
        {
            givenScore = givenScore * 100;
        }
        else if(givenScore>=7&&givenScore<=9)
        {
            givenScore = givenScore * 1000;
        }

        Console.WriteLine("score is: {0}",givenScore);
    }
}

