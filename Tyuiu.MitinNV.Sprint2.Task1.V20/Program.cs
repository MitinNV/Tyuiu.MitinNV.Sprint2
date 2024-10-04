using Tyuiu.MitinNV.Sprint2.Task1.V20.Lib;
namespace Tyuiu.MitinNV.Sprint2.Task1.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Логические операции                                                     *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Митин Никита Владимирович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=, последова*");
            Console.WriteLine("*ательность можно чередовать, но использовать один раз в выражении) и логи*");
            Console.WriteLine("*ических операций (|, &, ||, &&, !, ^, последовательность операций не долж*");
            Console.WriteLine("*жна нарушаться), а также арифметических выражений, которая вернет логичес*");
            Console.WriteLine("*скую последовательность(массив): (False, False, False, True, True, True),*");
            Console.WriteLine("*, при a = 242, b = 155, c = 456, d = 17                                  *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetLogicOperations(242, 155, 456, 17);
            var s = "";
            foreach (var res in result)
            {
                s += " " + res.ToString();
            }
            Console.WriteLine(s.Substring(1));
            Console.ReadKey();
        }
    }
}