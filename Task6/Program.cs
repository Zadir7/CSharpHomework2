using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,count = 0;
            DateTime start = DateTime.Now;
            for (number = 1; number<=1000000; number++)
            {
                if (number % getSum(number) == 0)
                {
                    count++;
                }
            }
            TimeSpan finish = DateTime.Now - start;
            Console.WriteLine($"От 1 до 1.000.000 найдено {count} хороших чисел.");
            Console.WriteLine($"Время выполнения программы: {finish}");
            Console.ReadKey();
        }
        static int getSum(int _number)
        {
            int sum = 0;
            while (_number > 0)
            {
                sum += _number % 10;
                _number /= 10;
            }
            return sum;
        }
    }
}
