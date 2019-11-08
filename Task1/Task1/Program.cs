using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(gcd(x, y));

            Console.ReadKey();
        }

        static int gcd(int x, int y)
        {
            while (y != 0)
            {
                int tmp = x % y;
                x = y;
                y = tmp;
            }

            return x;
        }
    }
}