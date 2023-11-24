using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> doubles = new List<double> { 2.5, 3.7, 1.8, 4.2, 2.1 };

            double sum = 0;
            foreach (var number in doubles)
            {
                sum += number;
            }

            double average = sum / doubles.Count;

            Console.WriteLine("Элементы больше среднего арифметического:");
            foreach (var number in doubles.Where(n => n > average))
            {
                Console.WriteLine(number);
            }
        }
    }
}
