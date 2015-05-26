//    Problem 2. Gravitation on the Moon
//    The gravitational field of the Moon is approximately 17% of that on the Earth.
//    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class Program
{
    static void Main()
    {
        double weightOnEarth = 74.6;
        double gravityOfTheMoon=0.17;
        double weightOnTheMoon = weightOnEarth * gravityOfTheMoon;
        Console.WriteLine(weightOnTheMoon);

    }
}
