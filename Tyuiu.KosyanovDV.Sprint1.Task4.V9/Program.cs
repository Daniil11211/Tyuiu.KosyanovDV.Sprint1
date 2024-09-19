using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

using Tyuiu.KosyanovDV.Sprint1.Task4.V9.Lib;

namespace Tyuiu.KosyanovDV.Sprint1.Task4.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Косьянов Д. В. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Класс Math                                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Косьянов Даниил Васильевич | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Формула: ln(x*y)/x-√(1-y^2)                                             *");

            double x;
            
            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            double y;
            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* ln(x*y)/x-√(1-y^2) = {ds.Calculate(x,y)}                                             *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}

