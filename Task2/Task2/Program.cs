using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static int isVowel(char ch)
        {
            ch = char.ToUpper(ch);
            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int countVowels(string str, int n)
        {
            if (n == 1)
            {
                return isVowel(str[n - 1]);
            }

            return countVowels(str, n - 1) + isVowel(str[n - 1]);
        }

        public static void Main(string[] args)
        { 
            string str = Console.ReadLine();

            Console.WriteLine(countVowels(str, str.Length));
        }
    }
}