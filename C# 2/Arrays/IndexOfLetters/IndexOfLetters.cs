//   Write a program that creates an array containing all letters from the alphabet (A-Z).
//   Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] arrWithLetters = new char[26];
        for (char ch = 'a'; ch <= 'z'; ch++)
        {
            arrWithLetters[ch - 'a'] = ch;
        }

        Console.WriteLine("enter the word for which you want to find the index of the letters");
        string inputWord = Console.ReadLine();


        foreach(char ch in inputWord)
        {
            Console.Write(Array.IndexOf(arrWithLetters,ch) + " ");
        }
    }

}
