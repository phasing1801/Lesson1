using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите ваше имя.");
            string name = Console.ReadLine();

            Console.WriteLine("Напишите вашу фамилию.");
            string surname = Console.ReadLine();

            Console.WriteLine("Укажите ваш возраст.");
            string age = Console.ReadLine();

            Console.WriteLine("Укажите ваш вес.");
            string weight = Console.ReadLine();


            Console.WriteLine("Ваше имя - " + name + ", ваша фамилия - " + surname + ", ваш возраст - " + age + ", ваш вес - " + weight + ". Ваша анкета готова!");

            Console.WriteLine("Ваше имя - {0}, ваша фамилия - {1}, ваш возраст - {2}, ваш вес - {3}. Ваша анкета готова!", name, surname, age, weight);
            Console.WriteLine($"Ваше имя - {name}, ваша фамилия - {surname}, ваш возраст - {age}, ваш вес - {weight}. Ваша анкета готова!"); 

            Console.ReadLine();
        }

    }

}
