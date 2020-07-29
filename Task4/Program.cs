using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string log, pass;
            int tryCount = 0, maxTryCount = 3;

            do
            {
                Console.WriteLine("Введите логин");
                log = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                pass = Console.ReadLine();
                if (checkPassword(log, pass))
                {
                    Console.WriteLine("Вход выполнен.");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный логин или пароль. Вам дана еще одна попытка.");
                }
                tryCount++;
            }
            while (tryCount < maxTryCount);

            if (tryCount >= maxTryCount)
            {
                Console.WriteLine($"Вы превысили максимальное количество попыток: {maxTryCount}. Вход заблокирован отныне и навсегда.");
            }
            Console.ReadKey();
        }
        static bool checkPassword(string _login, string _pass)
        {
            if (_login == "root" && _pass == "GeekBrains")
            {
                return true;
            }
            else return false;
        }
    }
}
