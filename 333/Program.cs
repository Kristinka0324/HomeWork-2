﻿using System;

namespace _333
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите число и я определю четное оно или не четное :)");
            int a;

            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");

            }
        }
    }   
}
