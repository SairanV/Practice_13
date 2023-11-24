using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 3, 8, 12, 7, 9, 15, 10 };

            int secondMax = numbers.OrderByDescending(n => n).Distinct().Skip(1).First();
            int position = numbers.IndexOf(secondMax);
            Console.WriteLine($"Позиция второго максимального элемента: {position}, Значение: {secondMax}");

            numbers.RemoveAll(n => n % 2 != 0);

            Console.WriteLine("Список после удаления нечетных элементов:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
