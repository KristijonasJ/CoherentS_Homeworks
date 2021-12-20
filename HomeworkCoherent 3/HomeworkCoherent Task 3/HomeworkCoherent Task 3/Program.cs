using System;
using System.Collections.Generic;
using System.Linq;

namespace Coherent_HM1_Task_3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array"); //Did this Task 2 ways not sure which is more effective,
            var arraySize = int.Parse(Console.ReadLine());    //but there is less coding to do with Linq
            var list = new List<int>();

            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("Enter element " + (i + 1) + ":");
                list.Add(int.Parse(Console.ReadLine()));
            }

            var minPosition = list.IndexOf(list.Min());
            var maxPosition = list.LastIndexOf(list.Max());
            list.ForEach(x => Console.Write(x + " "));
            Console.Write('\n');
            Console.WriteLine(list.GetRange(Math.Min(minPosition, maxPosition), Math.Abs(minPosition - maxPosition) + 1).Sum());

            //Console.WriteLine("Enter the size of the array");
            //var arraySize = int.Parse(Console.ReadLine());
            //var array = new int[arraySize];

            //for (int i = 0; i < arraySize; i++)
            //{
            //    Console.WriteLine("Enter element " + (i+1) + ":");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //var minPosition = Math.Min(Array.IndexOf(array, array.Min()), Array.LastIndexOf(array, array.Max()));
            //var maxPosition = Math.Max(Array.IndexOf(array, array.Min()), Array.LastIndexOf(array, array.Max()));
            //var sum = 0;

            //for (int i = 0; i < arraySize; i++)
            //{
            //    if(i >= minPosition && i <= maxPosition)
            //        sum += array[i];
            //    Console.Write(array[i] + " ");
            //}

            //Console.WriteLine(sum);
        }

    }
}
