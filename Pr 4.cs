//***********************************************************
//* Практическая работа № 4                                 *
//* Выполнил: Кузин. Я. Н., группа 2ИСПд                    *
//* Задание: составить программу работы линейного алгоритма *
//***********************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PR_4
{
    internal class Program
    {
        static void Main(string[] args) // точка входа в программу
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Практическая работа № 4"; // заголовок консоли
            double x, y, b; // объявление переменных
            double v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16;
            Console.WriteLine("Здравствуйте!");
            Console.Write("Введите x = "); // ввод исходных данных
            x = Convert.ToDouble(Console.ReadLine()); // явное приведение к типу double
            Console.Write("Введите b = "); 
            b = Convert.ToDouble(Console.ReadLine()); 
            // расчёт ззначения выражения
            v1 = b - 1;
            v2 = 1 - b * x;
            v3 = Math.Pow(x, 3); // возведение в степень
            v4 = v3 + 1; // сокращённая форма записи
            v5 = Math.Pow(x, 3);
            v6 = v5 - b;
            v7 = v1 / v2 / v4 / v6;
            v8 = Math.Pow(x, 2);
            v9 = 17 * b * x + 7;
            v10 = v8 - v9;
            v11 = Math.Sqrt(2 * Math.Pow(x, b) + 5); // корень
            v12 = 3 * v11;
            v14 = v12 - x;
            v15 = Math.Log(3) * Math.Abs(v14);
            y = v7 + v15;
            // Вывод результата на экран
            Console.WriteLine("Результат: y = {0: #.#####}", y);
            // или Console.WriteLine("Результат: y = " + y);
            Console.ReadKey(); //задержка экрана консоли









            

            
        }
    }
}
