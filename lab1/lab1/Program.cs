using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год");
            int a = Convert.ToInt32(Console.ReadLine());
            if ((a%4==0)&&((a % 100 != 0) || (a % 400 == 0)))
            {
                Console.WriteLine("Год високосный");

            }
            else 
            {
                Console.WriteLine("Год не високосный");
            }
        }
    }
}
