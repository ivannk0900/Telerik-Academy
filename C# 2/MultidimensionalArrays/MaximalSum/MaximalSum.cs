// Write a program that reads a rectangular matrix 
// of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
using System;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("enter the number of rows>3");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the number of cols>3");
        int cols = int.Parse(Console.ReadLine());

        if(rows<3&&cols<3)
        {
            Console.WriteLine("invalid input");
            return;
        }
        int[,] matrix = new int[rows, cols];


        Console.WriteLine("enter the elements of the matrix");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("matrix[{0} {1}]=",row,col);
                matrix[row, col] = int.Parse(Console.ReadLine());
                
            }
        }


        int maxSum = int.MinValue;

        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                int currentMatrix = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (maxSum < currentMatrix)
                {
                    maxSum = currentMatrix;
                }
            }
        }

        Console.WriteLine("the maximal sum is: {0}", maxSum);
    }
}


