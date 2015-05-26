using System;

class Matrix
{
    static void Main()
        {   
            start:
            Console.WriteLine("enter 0<n<20");
            int n = int.Parse(Console.ReadLine());
            if (n < 0 || n > 21)
            {
                Console.WriteLine("wrong input ");
                goto start;
            }
            
            for (int i = 1; i <= n; i++)
            {
              for (int j=i;j<n+i;j++)
              {
                  Console.Write(j + "  ");
                  
              }
              Console.WriteLine();

            }


        }
}

