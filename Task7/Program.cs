using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 15;
            Console.WriteLine($"a = {a}, b = {b}, сумма чисел от a до b равна {getSum(a,b)}");
            Console.ReadKey();
        }

        static int getSum(int _a, int _b)
        {
            if (_a < _b)
            {
                return _a + getSum(_a + 1, _b);
            }
            else { return _b; }
        }
    }
}
