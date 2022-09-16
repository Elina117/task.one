using System;
using System.Reflection.Emit;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Упржнение 1");
            // ввод имени
            Console.Write("Введите свое имя: \n");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}");


            Console.WriteLine("Упржнение 2");
            // разделить два числа
            Console.Write("Введите первое число: ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int s = int.Parse(Console.ReadLine());
            int del = f / s;
            Console.WriteLine(del);


            Console.WriteLine("Упражнение 3");
            // Вывод буквы алфавита
            Console.Write("Введите букву алфавита: ");
            char letter = char.Parse(Console.ReadLine());
            int ind = Convert.ToInt32(letter);
            int nextind = ind + 1;
            char letternext = (char)nextind;
            Console.WriteLine($"Следующая буква алфавита: {letternext}");


            Console.WriteLine("Упржнение 4");
            // квадратное уравнение
            Console.Write("Введите первое число a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите третье число c: ");
            double c = double.Parse(Console.ReadLine());
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Первый корень {x1}, второй корень {x2}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Kорней нет");
                Console.ReadKey();
            }

        }
    }
}

