//   We are given a matrix of strings of size N x M. Sequences in the matrix we define
// as sets of several neighbour elements located on the same line, column or diagonal.
//    Write a program that finds the longest sequence of equal strings in the matrix.

using System;

class SequenceNMatrix
{
    static void Main()
    {
        Console.WriteLine("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("M = ");
        int m = int.Parse(Console.ReadLine());
        string[,] array = new string[n, m];
       
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Array[{0},{1}] = ", i, j);
                array[i, j] = Console.ReadLine();
            }
        }
        int maxElements = 0;
        int currentElements = 0;
        string maxStr = "";
       

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                // horizontally count elements
                currentElements = 0;
                for (int k = i; k < n - 1; k++)
                {
                    if (array[j, k + 1] == array[j, k])
                    {
                        currentElements++;
                    }
                    if (currentElements > maxElements)
                    {
                        maxElements = currentElements;
                        maxStr = array[j, k];
                    }
                }
                // vertically count elements
                currentElements = 0;
                for (int k = j; k < m - 1; k++)
                {
                    if (array[k, i] == array[k + 1, i])
                    {
                        currentElements++;
                    }
                    if (currentElements > maxElements)
                    {
                        maxElements = currentElements;
                        maxStr = array[k, i];
                    }
                }
                // diagonally count elements
                currentElements = 0;
                for (int k = i, l = j; (k < n - 1) && (l < m - 1); k++, l++)
                {
                    if (array[l, k] == array[l + 1, k + 1])
                    {
                        currentElements++;
                    }
                    if (currentElements > maxElements)
                    {
                        maxElements = currentElements;
                        maxStr = array[l, k];
                    }
                }
            }
        }
        for (int i = 0; i < maxElements + 1; i++) Console.Write(maxStr + ", ");
         
    }
}

