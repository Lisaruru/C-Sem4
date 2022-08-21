// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
using System;

namespace Exs27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number=Convert.ToInt32(Console.ReadLine());
            int sum=0;
            int digit=0;

             while(number>0)
             {
                digit=number%10;
                sum=sum+digit;
                number=number/10;
               
             }
            Console.WriteLine(sum);
        }
    }
}
