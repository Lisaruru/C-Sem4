// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
using System;

namespace Exs25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А: ");
            int numberA=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите число B: ");
            int numberB=Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine($"{numberA}^{numberB} = " + Math.Pow(numberA, numberB));
        }
    }
}

