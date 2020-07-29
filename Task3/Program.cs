using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, summ = 0;
            do
            {
                Console.WriteLine("Введите число. 0 останавливает программу");
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 0 && a % 2 == 1)
                {
                    summ += a;
                }
            }
            while (a != 0);
            Console.WriteLine($"Сумма всех введенных нечетных положительных чисел равна {summ}");
            Console.ReadKey();
        }
    }
}
