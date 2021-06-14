using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Lesson2
    {
        static void f(int h)
        {
            if (h > 0)
            {
                Console.WriteLine($"{h}");
                f(h - 1);
            }
        }
        static void Main(string[] args)
        {
            #region Задание 1

            int a = 2;
            int b = 5;
            int c = 1;

            double smallest;
            if (a <= b && a <= c)
            {
                smallest = a;
            } else if (b <= c && b <= a) {
                smallest = b;
            } else {
                smallest = c;
            }

            Console.WriteLine($"Наименьшее из чисел {a} , {b} , {c} - число {smallest}"); // Проверка
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Задание 2

            Console.WriteLine("Введите число для подсчёта количества цифр:");
            int n = int.Parse(Console.ReadLine()), count = 0;
            
            while (n != 0)
            {
                n /= 10;
                count++;
            }
            Console.WriteLine($"Число состоит из {count} цифр");
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Задание 3

            int sum = 0;
            int num = 0;

            Console.WriteLine("Вводите числа. Для завершения введите 0");
            do
            {
                num = int.Parse(Console.ReadLine());

                if (num > 0 && num % 2 == 1)
                    sum += num;

            } while (num != 0);

            Console.WriteLine($"Сумма всех нечётных положительных чисел: {sum}");
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Задание 4

            string login = "root";
            string password = "GeekBrains";

            int tr = 0;
            do
            {
                Console.WriteLine("Введите логин: ");
                string logCheck = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                string passCheck = Console.ReadLine();


                if (login == logCheck && password == passCheck)
                {

                    Console.WriteLine("Выполнен вход. Добро пожаловать!");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine("Неверно введён логин или пароль!");
                Console.ReadLine();
                tr++;
            } while (tr < 3);

            Console.Clear();

            #endregion

            #region Задание 5

            Console.WriteLine("Введите свой рост в метрах через запятую");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите свой вес в кг");
            double i = Convert.ToDouble(Console.ReadLine());

            double l = i / (p * p);

            if (l < 18)
            {
                Console.WriteLine($"Вам необходимо поправиться.");
            }
            else if (l > 25)
            {
                Console.WriteLine($"Вам необходимо похудеть.");
            }
            else
            {
                Console.WriteLine($"Всё в порядке");
            }
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Задание 7

            Console.WriteLine("Введите нижнюю границу:"); // не смог понять, как можно обозначить её для программы
            int s = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите верхнюю границу:");
            int h = int.Parse(Console.ReadLine());

            f(h);

            Console.ReadLine();

            #endregion

        }
    }
}
