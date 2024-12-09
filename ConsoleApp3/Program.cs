using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// Задача 4. Создать метод, который будет вычислять площадь круга и длину окружности. 
    /// Вызывающий программный код должен передавать в качестве аргумента методу значение радиуса и печатать значение радиуса,
    /// площади круга и длины окружности.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = InputIntNumber("радиус круга = ");
            OutMessage(lengthOfACircle(r) , "длина окружности");
            OutMessage(AreaOfACircle(r), "площадь окружности");
            Console.Read();
        }
        static double AreaOfACircle(int x)
        {
            return Math.PI * Math.Pow(x , 2);
        }
        static double lengthOfACircle(int x)
        {
            return 2 * Math.PI * x;
        }
        static int InputIntNumber(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void OutMessage(double message , string name)
        {
            Console.WriteLine($"{name} : {message:f1}");
        }
    }
}
