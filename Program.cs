using System;

namespace From_A_to_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] number = Console.ReadLine().Split(" ");
            int a = int.Parse(number[0]);
            int b = int.Parse(number[1]);
            int x = 0;
            if (((1 > a) || (a > (1000000000))) || ((1 > b) || (b > (1000000000))))
            {
                return;
            }
            while (a > b)
            {
                if (a % 2 == 0)
                {
                    a /= 2;
                }
                else
                {
                    a++;
                }
                x++;
            }
            while (a < b)
            {
                a++;
                x++;
            }

            Console.WriteLine(x);
        }
    }
}