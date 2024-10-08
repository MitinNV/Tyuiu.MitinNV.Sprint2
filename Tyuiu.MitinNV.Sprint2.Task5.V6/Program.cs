using Tyuiu.MitinNV.Sprint2.Task5.V6.Lib;
namespace Tyuiu.MitinNV.Sprint2.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Оператор switch                                                         *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                            *");
            Console.WriteLine("* Выполнил: Митин Никита Владимирович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу, которая использует оператор switch вычисляет требуемо*");
            Console.WriteLine("*ое значение и возвращает результат.                                      *");

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
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            var result = ds.FindCardNameAndValue(a, b);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}