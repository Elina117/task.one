using System;
using System.Reflection.Emit;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Dk
{

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Упражнение 1");
            double e = Math.E;
            Console.WriteLine(e);

            Console.WriteLine("Упражнение 2");
            Console.WriteLine("50 \n10");

            Console.WriteLine("Упражнение 3");
            Random rnd = new Random();
            int a = rnd.Next(0, 100000);
            int b = rnd.Next(0, 100000);
            int c = rnd.Next(0, 100000);
            int d = rnd.Next(0, 100000);

            Console.WriteLine($"{a} \n{b} \n{c} \n{d}");


            Console.WriteLine("Упражнение 4");
            Console.Write("Введите число: ");
            int numb = int.Parse(Console.ReadLine());
            int result = numb + 10;
            Console.WriteLine(result);
            

            Console.WriteLine("Упражнение 5");
            Console.WriteLine("Введите длину сторны квадрата: ");
            double len = double.Parse(Console.ReadLine());
            double per = len * 4;
            Console.WriteLine($"Периметр квадрата: {per}");
            

            Console.WriteLine("Упражнение 6");
            Console.Write("Введите радиус: ");
            double r = double.Parse(Console.ReadLine());
            double sq = Math.Pow(r, 2) * Math.PI;
            double len = Math.PI * 2 * r;
            Console.WriteLine($"Площадь круга: {sq} \nДлина окружности: {len}");
            

            Console.WriteLine("Упражнение 7");
            Console.Write("Введите угол x: ");
            double x = double.Parse(Console.ReadLine());
            if (-1 < x & x < 1)
            {
                double cos = Math.Cos(x);
                Console.WriteLine(cos);
            }
            else
            {
                Console.WriteLine("Значения нет");
            }

            

            Console.WriteLine("Упражнение 8");
            Console.Write("Введите значение меньшего основания: ");
            double osn1 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение большего основания : ");
            double osn2 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение высоты: ");
            double h = double.Parse(Console.ReadLine());
            double raz = (osn2 - osn1) / 2;
            double bok = Math.Sqrt(Math.Pow(h, 2) + Math.Pow(raz, 2));
            double per = 2 * bok + osn1 + osn2;
            Console.WriteLine($"Периметр трапеции равен: {per}");
            


            Console.WriteLine("Упражнение 9");
            //узнаем кол-во товара
            Console.Write("Введите кг яблок: ");
            double apkg = double.Parse(Console.ReadLine());
            Console.Write("Введите кг конфет: ");
            double konkg = double.Parse(Console.ReadLine());
            Console.Write("Введите кг печенья: ");
            double pechkg = double.Parse(Console.ReadLine());
            //узнаем цену товара
            Console.Write("Введите цену за кг яблок: ");
            double ap = double.Parse(Console.ReadLine());
            Console.Write("Введите цену за кг конфет: ");
            double kon = double.Parse(Console.ReadLine());
            Console.Write("Введите цену за кг печенья: ");
            double pech = double.Parse(Console.ReadLine());

            double sum = apkg * ap + konkg * kon + pechkg * pech;

            Console.WriteLine(sum);

            



            Console.WriteLine("Упражнение 10");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир \n     Труд\n            Май");
            

            Console.WriteLine("Упражнение 11");
            
            Console.Write("Введите первую числовую переменную: ");
            string digit1 = Console.ReadLine();
            // если вводят дробное число
            if (digit1 != null & digit1.Contains(",") || digit1 != null & digit1.Contains("."))
            {
                if (digit1.Contains(","))
                {
                    digit1 = digit1.Replace(",", ".");
                    double firstdigit = double.Parse(digit1);
                    Console.WriteLine($"Первое ваше число - {firstdigit}");
                }
                else
                {
                    if (digit1.Contains("."))
                    {
                        double firstdigit = double.Parse(digit1);
                        Console.WriteLine($"Первое ваше число - {firstdigit}");

                    }
                }
            }
            else //если вводят целое число
            {
                if (int.TryParse(digit1, out int first))
                {
                    Console.WriteLine($"Первое ваше число - {first}");
                }
                else
                {
                    Console.WriteLine("Данные введены неверно, используйте только числа");
                }
            }

            Console.Write("Введите вторую числовую переменную: ");
            string digit2 = Console.ReadLine();

            // если вводят дробное число
            if (digit2 != null & digit2.Contains(",") || digit2 != null & digit2.Contains("."))
            {
                if (digit2.Contains(","))
                {
                    digit2 = digit2.Replace(",", ".");
                    double seconddigit = double.Parse(digit2);
                    Console.WriteLine($"Второе ваше число - {seconddigit}");
                }
                else
                {
                    if (digit2.Contains("."))
                    {
                        double seconddigit = double.Parse(digit2);
                        Console.WriteLine($"Второе ваше число - {seconddigit}");

                    }
                }
            }
            else //если вводят целое число
            {
                if (int.TryParse(digit2, out int second))
                {
                    Console.WriteLine($"Второе ваше число - {second}");
                }
                else
                {
                    Console.WriteLine("Данные введены неверно, используйте только числа");

                }
                
             Console.WriteLine($"Результат чисел с перестановкой: {second}, {first}");
                
            }
               
            
            

            Console.WriteLine("Упражнение 12");
            Console.Write("выбирете нужную фигуру");
            Console.Write("");
            Console.WriteLine("Чтобы выбрать треугольник нажмите 1");
            Console.WriteLine("Чтобы выбрать круг нажмите 2");
            Console.WriteLine("Чтобы выбрать четырехугольник нажмите 3");

            var vvod = Console.ReadLine();
            int choice;
            if (int.TryParse(vvod, out choice) == false)
            {
                Console.Clear();
                Console.WriteLine("Данные введены неверно, используйте только числа");

            }
            else
            {
                switch (choice)
                {
                    case 1:
                    {
                            Console.WriteLine("Вы выбрали треугольник");
                            Console.WriteLine("");

                            Console.WriteLine("Чтобы расчитать площадь фигуры, нажмите 1");
                            Console.WriteLine("Чтобы рассчитать периметр фигуры, нажмите 2");

                            if (int.TryParse(vvod, out choice) == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Данные введены неверно, используйте только числа");

                            }

                            switch (choice)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Вы выбрали найти площадь треугольника!");
                                        Console.Write("Введите длину высоты: ");
                                        double h = double.Parse(Console.ReadLine());
                                        Console.Write("Введите длину основания");
                                        double s = double.Parse(Console.ReadLine());

                                        double sqr = 0.5 * h * s;
                                        Console.WriteLine(sqr);

                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine("Вы выбрали найти периметр треугольника!");
                                        Console.Write("Введите длину первой стороны: ");
                                        double a = double.Parse(Console.ReadLine());
                                        Console.Write("Введите длину второй стороны");
                                        double b = double.Parse(Console.ReadLine());
                                        Console.Write("Введите длину третьей стороны");
                                        double c = double.Parse(Console.ReadLine());

                                        double per = a + b + c;
                                        Console.WriteLine(per);
                                    }
                                        break;


                            }

                            break;
                    }


                    case 2:
                    {
                            Console.WriteLine("Вы выбрали круг");
                            Console.WriteLine("");

                            Console.WriteLine("Чтобы расчитать площадь фигуры, нажмите 1");
                            Console.WriteLine("Чтобы рассчитать периметр фигуры, нажмите 2");

                            if (int.TryParse(vvod, out choice) == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Данные введены неверно, используйте только числа");

                            }
                            switch (choice)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Вы выбрали найти площадь круга!");
                                        Console.Write("Введите длину радиуса: ");
                                        double r = double.Parse(Console.ReadLine());

                                        double sqr = Math.PI * Math.Pow(r, 2);
                                        Console.WriteLine(sqr);

                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine("Вы выбрали найти периметр круга!");
                                        Console.Write("Введите длину первой стороны: ");
                                        double r = double.Parse(Console.ReadLine());

                                        double per = 2 * Math.PI * r;
                                        Console.WriteLine(per);
                                    }
                                    break;


                            }

                            break;
                    }

                    case 3:
                    {
                            Console.WriteLine("Вы выбрали четырехугольник");
                            Console.WriteLine("");

                            Console.WriteLine("Чтобы расчитать площадь фигуры, нажмите 1");
                            Console.WriteLine("Чтобы рассчитать периметр фигуры, нажмите 2");

                            if (int.TryParse(vvod, out choice) == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Данные введены неверно, используйте только числа");

                            }

                            switch (choice)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Вы выбрали найти площадь четырехугольника!");
                                        Console.Write("Введите длину высоты: ");
                                        double a = double.Parse(Console.ReadLine());
                                        Console.Write("Введите длину стороны");
                                        double b = double.Parse(Console.ReadLine());

                                        double sqr = a * b;
                                        Console.WriteLine(sqr);

                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine("Вы выбрали найти периметр четырехугольника!");
                                        Console.Write("Введите длину первой стороны: ");
                                        double a = double.Parse(Console.ReadLine());
                                        Console.Write("Введите длину второй стороны");
                                        double b = double.Parse(Console.ReadLine());
                                        Console.Write("Введите длину третьей стороны");
                                        double c = double.Parse(Console.ReadLine());
                                        Console.Write("Введите длину четвертой стороны");
                                        double d = double.Parse(Console.ReadLine());

                                        double per = a + b + c + d;
                                        Console.WriteLine(per);
                                    }
                                    break;


                            }

                            break;
                    }






                }
            }

            

            Console.WriteLine("Упражнение 13");
            Console.Write("Введите число: ");
            int digit = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {digit}");



            Console.WriteLine("Упражнение 14");
            Console.WriteLine("2 кг \n13 17");

            


            Console.WriteLine("Упражнение 15");
            Random rnd = new Random();
            int a = rnd.Next(0, 1000000000);
            int b = rnd.Next(0, 1000000000);
            int c = rnd.Next(0, 1000000000);
            int d = rnd.Next(0, 1000000000);

            Console.WriteLine($"{a} \n{b} \n{c} \n{d}");

            

            Console.WriteLine("Упражнение 16");
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

            


            Console.WriteLine("Упражнение 17");
            Console.Write("Введите первое число: ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("Введите второе числоЖ ");
            double second = double.Parse(Console.ReadLine());
            double srarifm = (first + second) / 2;
            double srgeom = (first * second) / 2;
            Console.ReadLine($"Среднее арифметическое: {srarifm} \nСреднее геометрическое: {srgeom}");
            

            Console.WriteLine("Упражнение 18");
            Console.Write("Введите координату Х первой точки: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату Y первой точки: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату Х второй точки: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату Y второй точки: ");
            double y2 = double.Parse(Console.ReadLine());

            double distance = Math.Sqrt((x2 - x1) + (y2 - y1));
            Console.WriteLine($"Расстояние = {distance}");
            

            Console.WriteLine("Упражнение 19");
            Console.Write("Введите переменную a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write(("Введите переменную b: "));
            var b = int.Parse(Console.ReadLine());
            Console.Write(("Введите переменную c: "));
            var c = int.Parse(Console.ReadLine());
            //first task
            (b, a, c) = (c, b, a);
            Console.WriteLine(a + " " + b + " " + c);
            (b, c, a) = (a, c, b);
            Console.WriteLine(a + " " + b + " " + c);
            


            Console.WriteLine("Упражнение 20");
            Console.Write("Введите сколько секунд прошло с начала суток: ");
            int sec = int.Parse(Console.ReadLine());
            int hour = (sec / 60) / 60;
            int min = (sec % 3600) / 60;
            int ss = sec % 60;
            Console.WriteLine($"сколько полных часов прошло с начала суток {hour}");
            Console.WriteLine($"сколько полных минут прошло с начала очередного часа {min}");
            Console.WriteLine($"сколько полных секунд прошло с начала очередной минуты {ss}");
            


            Console.WriteLine("Упражнение 21");
            int kvadrat = 543 / 130;
            Console.WriteLine(kvadrat);
            


            Console.WriteLine("Упражнение 22");
            Console.Write("Введите трехзначное число: ");
            int triz = int.Parse(Console.ReadLine());
            int number1 = (triz % 10);
            int number3 = triz / 10;
            Console.WriteLine($"{number1}{number3}");

            

            Console.WriteLine("Упражнение 23");
            Console.Write("Введите число большее 999:  ");
            int numb = int.Parse(Console.ReadLine());
            int sotni = numb / 100;
            int tus = numb / 1000;
            Console.WriteLine($"Кол-во сотен: {sotni}\nКол-во тысяч: {tus}");
            

            Console.WriteLine("Упражнение 24");
            Console.Write("Ввести четырехзначное число: ");
            var i = Console.ReadLine();
            string str = i.ToString();
            Console.WriteLine($"{i[3]}{i[2]}{i[1]}{i[0]}");
            Console.WriteLine($"{i[1]}{i[0]}{i[3]}{i[2]}");
            Console.WriteLine($"{i[0]}{i[2]}{i[1]}{i[3]}");
            Console.WriteLine($"{i[2]}{i[3]}{i[0]}{i[1]}");
            


            Console.WriteLine("Упражнение 25");
            Console.Write("Введите число от 100 до 999: ");
            int n = int.Parse(Console.ReadLine());
            int last = n % 10; //последнее число
            int nextl = n / 10; //предпоследнее
            if (100 <= n & n <= 999 & nextl != 0)
            {
                int x = last * 100 + nextl;
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("Число введено неверно!");
            }
            

            Console.WriteLine("Упражнение 26");
            Console.Write("Введите часы: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Введите минуты: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите секунды: ");
            int s = int.Parse(Console.ReadLine());

            int summ = (h * 3600) + (m * 60) + s;
            int corn = summ % 360;
            Console.WriteLine($"Угол = {corn}");



            Console.WriteLine("Упражнение 27");
            //Часовая стрелка: 1 градус = 2 минуты
            //Минутная стрелка: 6 градусов = 1 минута
            int otkl = 2 * 2 * 6;
            int h = 0;
            int min = 2 * 2;
            Console.WriteLine($"Значени угла минутной стрелки: {otkl}\nПолных часов {h}\nПолных минут {min}");
            

            Console.WriteLine("Упражнение 28");
            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double c = double.Parse(Console.ReadLine());

            if (Math.Abs(a) < Math.Abs(b) & Math.Abs(a) < Math.Abs(c))
            {
                double small = a;
                Console.WriteLine(small);
            }
            else
            {
                if (Math.Abs(b) < Math.Abs(a) & Math.Abs(b) < Math.Abs(c))
                {
                    double small = b;
                    Console.WriteLine(small);
                }
                else
                {
                    if (Math.Abs(c) < Math.Abs(a) & Math.Abs(c) < Math.Abs(b))
                    {
                        double small = c;
                        Console.WriteLine(small);
                    }
                }
            }
            
          
            Console.WriteLine("Упражнение 29");
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());
            int[] numbers = { a, b, c };
            int min = numbers.Min();
            int max = numbers.Max();
            int sum = min + max;
            Console.WriteLine(sum);
            

            Console.WriteLine("Упражнение 30");
            Console.Write("Ввести натуральное число: ");
            int numb = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i = 1; i<=numb; i++)
                if (numb%i==0)
                {
                    cnt++;
                }
            Console.WriteLine($"Количество делителей равно {cnt}");
            

            Console.WriteLine("Упражнение 32");
            Console.Write("Введите первый член арифметической прогрессии: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второй член арифметической прогрессии: ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("Введите yомер члена арифметической прогрессии: ");
            int n = int.Parse(Console.ReadLine());

            int d = a2 - a1;
            int an = a1 + d * (n - 1);
            Console.WriteLine(an);
            


            Console.WriteLine("Упражнение 33");
            Console.WriteLine("Если вы студент и трудоустроены нажмите 1");
            Console.WriteLine("Если вы студент и не трудоустроены нажмите 2");
            Console.WriteLine("Если вы пенсионер и трудоустроены нажмите 3");
            Console.WriteLine("Если вы пенсионер и не трудоустроены нажмите 4");
            Console.WriteLine("Если вы пенсионер и студент нажмите 5");

            var vvod = Console.ReadLine();
            int choice;
            if (int.TryParse(vvod, out choice) == false)
            {
                Console.Clear();
                Console.WriteLine("Данные введены неверно!");
            }
            else
            {
                switch(choice)
                {
                    case 1:
                        { 
                            Console.WriteLine("Вы являетесь студентом и трудоустроены, поэтому вы можете получить кредит");
                            

                            break;

                        }
                    case 2:
                        {
                            Console.WriteLine("Вы являетесь студентом и не трудоустроены, поэтому вы не можете получить кредит");
                            

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Вы являетесь пенсионером и трудоустроены, поэтому вы можете получить кредит");


                            break;

                        }
                    case 4:
                        {
                            Console.WriteLine("Вы являетесь пенсионером и не трудоустроены, поэтому вы не можете получить кредит");


                            break;

                        }

                    case 5:
                        {

                            Console.WriteLine("Вы являетесь пенсионером и студентом");
                            Console.WriteLine("Вы можете получить кредит");


                            break;
                        }
                }
            }
            

            Console.WriteLine("Упражнение 34");
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}");
            */

            Console.WriteLine("Упражнение 35");
            Console.Write(" ");
            Console.Write("Как тебя зовут?\n");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}");
            Console.Write(" ");
            string first = Console.ReadLine();
            Console.WriteLine("Да");
            Console.Write("  ");
            string secnd = Console.ReadLine();
            Console.WriteLine("нет");
            Thread.Sleep(5000);
            Console.WriteLine("но могу показать");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();





        }
    }
}

