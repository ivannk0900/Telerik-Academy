//    Problem 5. Third Digit is 7?
//    Write an expression that checks for given integer if its third digit from right-to-left is 7.


using System;

class ThirdDigit7
{
    static void Main()
    {
        int var1 = 701;
        bool is7 = (var1 / 10 / 10 == 7);
        Console.WriteLine(is7);

        int var2 = 777877;
        bool is7_2 = (var2 / 10 / 10 == 7);
        Console.WriteLine(is7_2);

    }
}

