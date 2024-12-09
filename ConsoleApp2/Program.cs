using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// Задача 2. Составить программу, в результате которой величина а меняется значением с величиной b, а величина c — с величиной d.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = InputIntNumber("a =");
            int b = InputIntNumber("b =");
            int c = InputIntNumber("c =");
            int d = InputIntNumber("d =");
            Swap(ref a, ref b);
            Swap(ref c, ref d);
            OutMessage(a);
            OutMessage(b);
            OutMessage(c);
            OutMessage(d);
            Console.ReadLine();
        }
        static void Swap(ref int x, ref int y)
        {
            int n = x;
            x = y;
            y = n;

        }
        static int InputIntNumber(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void OutMessage(int message) 
        {
            Console.WriteLine($"{ message}");
        }
    }
}
