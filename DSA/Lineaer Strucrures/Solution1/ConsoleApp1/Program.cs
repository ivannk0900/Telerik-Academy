//Write a program that reads N integers from the console and reverses them using a stack.

using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number of integers: ");
            int n = Int32.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            var reversedStack = new Stack<int>();

            for(int i = 0; i < n; i++)
            {
                stack.Push(Int32.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < n; i++)
            {
                reversedStack.Push(stack.Pop());
            }

            
        }
    }
}
