using System;
using System.IO;

namespace MaximalAreaSum
{
    class Maximal
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\..\Files\file5.txt");
            using (reader)
            {
                string currentLine = reader.ReadLine();
                int n = int.Parse(currentLine);
                int[,] matrix = new int[n, n];
                int row = 0;
                currentLine = reader.ReadLine();
                while (currentLine != null)
                {

                    string[] currentLineArr = currentLine.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < n; i++)
                    {
                        matrix[row, i] = int.Parse(currentLineArr[i]);

                    }
                    currentLine = reader.ReadLine();
                    row++;
                }


                int maximalSum = int.MinValue;
                for (int row1 = 0; row1 < n - 1; row1++)
                {
                    for (int col = 0; col < n - 1; col++)
                    {
                        if (matrix[row1, col] + matrix[row1 + 1, col] + matrix[row1 + 1, col + 1] + matrix[row1, col + 1] > maximalSum)
                        {
                            maximalSum = matrix[row1, col] + matrix[row1 + 1, col] + matrix[row1 + 1, col + 1] + matrix[row1, col + 1];
                        }
                    }
                }
                Console.WriteLine("the maximal sum 2x2 is {0}",maximalSum);


            }


        }
    }
}
