using System;


namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("enter integer number");
                int num = int.Parse(Console.ReadLine());
                if(num<0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("square root of {0} - {1}", num, Math.Sqrt(num));
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("cannot calculate square root of negative");
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }

        }
    }
}
