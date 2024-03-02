using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static (double, double) getCubeAreaAndVolumeBySide(double a)
        {
            return (Math.Pow(a, 2) * 6, Math.Pow(a, 3));
        }
        static void Main(string[] args)
        {
            #region Задача2 Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
            Console.WriteLine("Введите сторону куба");
            double a = Convert.ToDouble(Console.ReadLine());
            (double area, double volume) = getCubeAreaAndVolumeBySide(a);
            Console.WriteLine("Куб имеет площадь, равную {0} и объем {1}", area, volume);
            #endregion

            Console.Write("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
