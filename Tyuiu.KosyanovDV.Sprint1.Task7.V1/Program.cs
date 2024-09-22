using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Tyuiu.KosyanovDV.Sprint1.Task7.V1.Lib;

namespace Tyuiu.KosyanovDV.Sprint1.Task7.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Косьянов Д. В. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Косьянов Даниил Васильевич | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*     b + √(b^2+4*a*c)                                                    *");
            Console.WriteLine("* z = ----------------  - a^3*c+b^(-2)                                    *");
            Console.WriteLine("*           2*a                                                           *");
            Console.WriteLine("***************************************************************************");


            Console.Write("* Введите значение a: ");
            double x;
            x = Convert.ToDouble(Console.ReadLine());



            Console.Write("* Введите значение b: ");
            double y;
            y = Convert.ToDouble(Console.ReadLine());


            Console.Write("* Введите значение c: ");
            double z;
            z = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* {ds.Calculate(x, y, z)}                                                   ");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
