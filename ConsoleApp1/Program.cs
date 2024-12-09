using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Задача 1. Поменять местами содержимое двух строковых переменных.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string strOne = "это первая строка ";
            string strTwo = "это вторая строка";
            Console.WriteLine($"вывод до обмена : {strOne} , {strTwo}");
            Swap(ref strOne, ref strTwo);
            Console.WriteLine($"вывод после обмена : {strOne} , {strTwo}");
            Console.Read();
        }
        static void Swap(ref string strOne,ref string strTwo) 
        {
            string strNope = strOne;
            strOne = strTwo;
            strTwo = strNope;
        }
    }
}
