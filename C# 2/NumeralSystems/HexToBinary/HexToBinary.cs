using System;

class HexToBinary
{
    static void Main()
    {
        Console.WriteLine("enter the hecaxedimal number");
        string hex = Console.ReadLine();
        string binary="AA";
        foreach(var item in hex)
        {
            if(item==0)
            {
                binary += "0000";
            }
            if (item == 1)
            {
                binary += "0001";
            }
            if (item == 2)
            {
                binary += "0010";
            }
            if (item == 3)
            {
                binary += "0011";
            }
            if (item == 4)
            {
                binary += "0010";
            }
            if (item == 5)
            {
                binary += "0101";
            }
            if (item == 6)
            {
                binary += "0110";
            }
            if (item == 7)
            {
                binary += "0111";
            }
            if (item == 8)
            {
                binary += "1000";
            }
            if (item == 9)
            {
                binary += "1001";
            }
            if (item == 'A')
            {
                binary += "1010";
            }
            if (item == 'B')
            {
                binary += "1011";
            }
            if (item == 'C')
            {
                binary += "1100";
            }
            if (item == 'D')
            {
                binary += "1101";
            }
            if (item == 'E')
            {
                binary += "1110";
            }
            if (item == 'F')
            {
                binary += "1111";
            }

        }
        Console.WriteLine(binary);
    }
}

