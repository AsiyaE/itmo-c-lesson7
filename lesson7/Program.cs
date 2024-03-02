using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class Program
    {
        static double GetAreaOfTriangleBySides(double a, double b, double c)
        {
            double semiper = (a + b + c) / 2;
            return Math.Sqrt(semiper * (semiper - a) * (semiper - b) * (semiper - c));
        }
        static void Main(string[] args)
        {
            #region Задача1 Определить, площадь какого из треугольников больше 
            Console.WriteLine("Введите стороны первого треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите стороны второго треугольника");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());

            double s1 = GetAreaOfTriangleBySides(a1, b1, c1);
            double s2 = GetAreaOfTriangleBySides(a2, b2, c2);

            string answer = (s1 > s2) ? "1" : (s1 == s2) ? "площади треугольников равны" : "2";

            Console.WriteLine("Треугольник максимальной площади:  {0}", answer);

            #endregion

            Console.Write("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
