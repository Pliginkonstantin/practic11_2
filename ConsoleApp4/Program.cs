using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Написать программу определения площади пятиугольника с заданными координатами его вершин (x1,y1), (x2,y2), (x3,y3), (x4,y4), (x5,y5) 
    /// как сумму площадей трех треугольников. Площадь треугольника, определенную по координатам вершин, рассчитать с помощью функции.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = InputIntNumber("x1 = ");
            int y1 = InputIntNumber("y1 = ");
            int x2 = InputIntNumber("x2 = ");
            int y2 = InputIntNumber("y2 = ");
            int x3 = InputIntNumber("x3 = ");
            int y3 = InputIntNumber("y3 = ");
            int x4 = InputIntNumber("x4 = ");
            int y4 = InputIntNumber("y4 = ");
            int x5 = InputIntNumber("x5 = ");
            int y5 = InputIntNumber("y5 = ");
            double area1 = TriangleArea(x1, y1, x2, y2, x3, y3);
            OutNumber(area1, "первый треугольник");
            double area2 = TriangleArea(x1, y1, x3, y3, x4, y4);
            OutNumber(area2, "второй треугольник");
            double area3 = TriangleArea(x1, y1, x4, y4, x5, y5);
            OutNumber(area3, "третий треугольник");
            OutNumber(area1 + area2 + area3, "площадь пятиуголька");
            Console.ReadLine();
        }
        static double TriangleArea(int x1, int y1, int x2, int y2, int x3, int y3)
        {

            double area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
            return Math.Abs(area) / 2.0;
        }

        static int InputIntNumber(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void OutNumber(double num, string message)
        {
            Console.WriteLine($"{message}: {num:f1}");
        }

    }
}
