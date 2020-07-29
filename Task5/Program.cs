using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, weight, index, diff;
            Console.WriteLine("Введите ваш рост в сантиметрах");
            height = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.WriteLine("Введите ваш вес");
            weight = Convert.ToDouble(Console.ReadLine());
            index = weight / Math.Pow(height,2);

            if (index < 18.5)
            {
                diff = Math.Pow(height, 2) * 18.5 - weight;
                Console.WriteLine($"Ваш индекс массы тела равен {index:f2}, это дефицит массы. Чтобы вернуться в норму, вам нужно набрать хотя бы {diff:f1} килограмм.");
            }
            else if (index >= 18.5 && index <= 25)
            {
                Console.WriteLine($"Ваш индекс массы тела равен {index:f2}, в пределах нормы.");
            }
            else if (index > 25)
            {
                diff = weight - Math.Pow(height, 2) * 25;
                Console.WriteLine($"Ваш индекс массы тела равен {index:f2}, вес избыточен. Чтобы вернуться в норму, вам нужно сбросить хотя бы {diff:f1} килограмм.");
            }
            Console.ReadKey();
        }
    }
}
