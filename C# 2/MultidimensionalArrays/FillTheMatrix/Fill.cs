// three types of matrixes that you can print

using System;

class Program
{
    static void MatrixA(int size)
    {

        int[,] matrix = new int[size, size];

        for (int row = 0; row < size; row++)
        {
            int element = row + 1;
            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = element;

                element += size;
            }

        }

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void MatrixB(int size)
    {
        int[,] matrix = new int[size, size];
        int element = 1;
        for (int col = 0; col < size; col++)
        {

            if (col % 2 == 0)
            {
                for (int rowEven = 0; rowEven < size; rowEven++)
                {
                    matrix[rowEven, col] = element;
                    element++;
                }
            }
            else
            {
                for (int rowOdd = size - 1; rowOdd >= 0; rowOdd--)
                {
                    matrix[rowOdd, col] = element;
                    element++;
                }
            }

        }

        // up to here the code is for filling the matrix

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }

    }


    static void MatrixC(int size)
    {
        int[,] matrix = new int[size, size];
        int element = 1;
        int counter = 1;
        for (int row = size - 1; row >= 0; row--)
        {
            int diagonal = 0;
            for (int col = 0; col < counter; col++)
            {

                matrix[row + diagonal, col] = element;
                diagonal++;
                element++;
            }
            counter++;
        }
    

        //up to here this code fills the matrix with the elements under the main diagnoal-including
        // counter indicates how many times the loop will cycle: for filling '1' one time, for filling '2' and '3' two times etc..
        counter = size-1;
       
            for (int col = 1; col <= size - 1; col++)
            {
                int diagonal = 0;
                for (int row = 0; row < counter; row++)
                {

                    matrix[row,col+diagonal] = element;
                    diagonal++;
                    element++;
                }
                counter--;
            }
        
        // the code above fiils the matrix abov the main diagonal


        // the code below prints the matrix
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
    }

    
      
    static void Main()
    {
        Console.WriteLine("enter the size of the square matrix");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the type of matrix that you want from 1 to 3");
        int a = int.Parse(Console.ReadLine());
        switch (a)
        {
            case 1:
                {
                    MatrixA(size);
                    break;
                }
            case 2:
                {
                    MatrixB(size);
                    break;
                }
            case 3:
                {
                    MatrixC(size);
                    break;
                }
           

            default: { Console.WriteLine("no matrix found"); break; }
        }
    }
}
