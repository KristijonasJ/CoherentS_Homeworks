using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkCoherent_1
{
    class Program
    {
        static string convertToTernary(int N)
        {
            if (N == 0)
                return "";

            int x = N % 3;
            N /= 3;
            return convertToTernary(N) + x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            var b = int.Parse(Console.ReadLine());

            for(int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            {
                string number = convertToTernary(Math.Abs(i));
                if (number.Count(x => x == '2') == 2)
                    Console.WriteLine(i);
            }
        }

    }
}
