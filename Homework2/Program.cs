using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9, b = 5, c = 5, min;
            min = GetMinimal(a, b, c);
            Console.WriteLine($"a = {a}, b = {b}, c = {c}, min = {min}");
            Console.ReadKey();

        }
        static int GetMinimal(int _a, int _b, int _c)
        {
            int _min = 0;

            if (_a < _b && _a < _c)
            {
                _min = _a;
            }
            else
            {
                _min = _b < _c ? _b : _c;
            }
            return _min;
        }
    }
}
