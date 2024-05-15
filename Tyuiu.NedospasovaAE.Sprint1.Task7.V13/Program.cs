using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NedospasovaAE.Sprint1.Task7.V13.Lib;

namespace Tyuiu.NedospasovaAE.Sprint1.Task7.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x, y;
            Console.Title = "Спринт #1 | Выполнила: Недоспасова.А.Э | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Недоспасова Александра Эдуардовна | ИИПб-23-2                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Вычислить значение выражения, используя данные, введенные      *");
            Console.WriteLine("* пользователем и округлить до трех чисел после запятой                   *");
            Console.WriteLine("*      y^2 - cos(x^2) + 10                                                *");
            Console.WriteLine("* z = .....................                                               *");
            Console.WriteLine("*      x^2 - sin(y^2) + 12                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение x:                                                        ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y:                                                        ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double result = ds.Calculate(x, y);
            string formattedResult = result.ToString("F3");
            Console.WriteLine(formattedResult);
            Console.ReadKey();
        }
    }
}
