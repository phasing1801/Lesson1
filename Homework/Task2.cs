using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для вычисления индекса массы тела (ИМТ), введите следующие данные:");

            Console.WriteLine("Введдите вашу массу в килограммах:");
            string mass = Console.ReadLine();

            int m = int.Parse(mass);

            Console.WriteLine("Введите ваш рост в метрах:");
            string height = Console.ReadLine();

            int h = int.Parse(height);


            int IMB = CalcIMB(m, h);

            Console.WriteLine($"Ваш ИМТ равен: {IMB}");
            Console.ReadLine();
        }

        static int CalcIMB(int m, int h)
        {
            int res = h / m * m;

            return res;
        }
    }

}