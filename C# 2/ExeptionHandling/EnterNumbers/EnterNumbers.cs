using System;


namespace EnterNumbers
{
    class EnterNumbers
    {
        static int ReadNumber(int start, int end)
        {
              Console.WriteLine("enter a number between {0} and {1}", start, end);
                int num = int.Parse(Console.ReadLine());

                if (num < start || num > end)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return (num);
            
            
            
        }
        static void Main()
        {
            int start = 1;
            int end = 100;

            try
            {


                for (int i = 1; i <= 10; i++)
                {
                    ReadNumber(start, end);
                }
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
