using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1265476845;
            Console.WriteLine($"В числе {a} {numCount(a)} цифр");
            Console.ReadKey();
        }

        static int numCount(int _num)
        {
            int count = 1;
            while (_num > 9)
            {
                _num /= 10;
                count++;
            }
            return count;
        }
    }
}
