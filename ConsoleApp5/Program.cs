using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    /// <summary>
    /// Даны 8 различных чисел. Определить максимальное из них, используя функцию определения максимального из двух чисел.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = InputIntNumber("a =");
            int b = InputIntNumber("b =");
            int c = InputIntNumber("c =");
            int d = InputIntNumber("d =");
            int e = InputIntNumber("e =");
            int f = InputIntNumber("f =");
            int g = InputIntNumber("g =");
            int h = InputIntNumber("h =");
            int max1 = Max(a, b);
            int max2 = Max(c, d);
            int max3 = Max(e, f);
            int max4 = Max(g, h);

            // Второй этап: полуфиналы
            int maxSFinal1 = Max(max1, max2);
            int maxSFinal2 = Max(max3, max4);

            // Финал: найти общий максимум
            OutMessage(Max(maxSFinal1, maxSFinal2), "ответ :");
            Console.Read();
        }
        static int Max(int x, int y)
        {
            return (x > y) ? x : y;
        }
        static void OutMessage(int num,  string msg)
        {
            Console.WriteLine($"{msg} : {num}");
        }
        static int InputIntNumber(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
    }
}
