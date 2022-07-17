using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.    Обязательная задача*. Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
namespace Part_2
{
    internal class Program
    {
        static void GetCube(double a, out double s, out double v)
        {
            s = 6 * a* a; //площадь
            v = a * a * a; //обьем
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double s ;
            double v;
            GetCube(a, out s, out v);
            Console.WriteLine();
            Console.WriteLine("Площадь куба ={0}", s);
            Console.WriteLine("Объем куба = {0}", v);
            Console.ReadLine();
        }
    }
}
