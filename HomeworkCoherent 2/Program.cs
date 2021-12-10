using System;

namespace Coherent_HM1_TASK2
{
    class Program
    {
        int Sum(string ISBN)
        {
            var sum = 0;
            var counter = 10;
            foreach (char c in ISBN)
            {
                sum += int.Parse(c.ToString()) * counter--;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first 9 digits of the ISBN");
            string ISBN = Console.ReadLine();
            var program = new Program();
            var sum = program.Sum(ISBN);
            int lastDigit = 11 - sum % 11;
            Console.WriteLine(lastDigit == 10 ? ISBN + 'X' : ISBN + lastDigit);
        }
    }
}
