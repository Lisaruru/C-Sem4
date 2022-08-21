//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
using System;

namespace Exs29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[ ]arr=new int[8];
            void RandomArray(int[]array)
            {
                for(int i=0;i<8;i++)
                {
                    Random rnd=new Random();
                    int value=rnd.Next(0,100);
                    arr[i]=value;
                    Console.Write($"{arr[i]}  ");
                }
          
            }
                    RandomArray(arr);
        }
    }
}
