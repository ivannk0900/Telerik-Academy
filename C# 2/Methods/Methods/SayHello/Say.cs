// Write a method that asks the user for his name and prints “Hello, <name>”
using System;

class Say
{
    static void Greeting(string name)
    {
        Console.WriteLine("Hello, {0}",name);
    }
    static void Main()
    {
        Console.WriteLine("enter your name: ");
        string name = Console.ReadLine();
        Greeting(name);
    }
}
