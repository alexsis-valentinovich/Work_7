using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.    Обязательная задача*. Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше
//(создать метод для вычисления  площади  треугольника по длинам его сторон).  Для решения задачи можно использовать формулу
//Герона 

//, где x, y, z – стороны треугольника, p – полупериметр.
namespace Part_1
{
    internal class Program
    {
        static double GetSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину трех сторон первого треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double s1= GetSquare(a1, b1, c1);
            Console.WriteLine("Введите длину трех сторон второго треугольника");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double s2=GetSquare(a2, b2, c2);
            Console.WriteLine();
            Console.WriteLine("Площадь первого треугольника = {0:0.00}", s1);
            Console.WriteLine("Площадь второго треугольника = {0:0.00}", s2);
            Console.WriteLine();
            if (s1 >= s2)
            {
                if (s1 > s2)
                    Console.WriteLine("Площадь первого треугольника больше");
                else
                    Console.WriteLine("Площади треугольников равны");
            }
            if (s1 < s2)
                    Console.WriteLine("Площадь второго треугольника больше");
            Console.ReadKey();
        }

    }
}
