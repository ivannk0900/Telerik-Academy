//   Problem 4. Print a Deck of 52 Cards
//    Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using 
//    the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//    The card faces should start from 2 to A.
//     Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;

class DeckOfCards
{
    static void Main()
    {
        for(int i=2;i<=10;i++)
        {
            for(int j=1;j<=4;j++)
            {
                switch (j)
                {
                    case 1: Console.Write(i + " of clubs "); break;
                    case 2: Console.Write(i + " of dimonds "); break;
                    case 3: Console.Write(i + " of hearts "); break;
                    case 4: Console.WriteLine(i + " of spades "); break;

                }
            }
        }
        Console.WriteLine("K of clubs K of dimonds  K of heatrs K of spades");
        Console.WriteLine("Q of clubs Q of dimonds  Q of heatrs Q of spades");
        Console.WriteLine("J of clubs J of dimonds  J of heatrs J of spades");
        Console.WriteLine("A of clubs A of dimonds  A of heatrs A of spades");
    }
}

