using System;

namespace _222
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("порядковый номер текущего месяца ->  ");
            DateTime aDate = DateTime.Now; ;
            Console.WriteLine(aDate.ToString("MM"));

        }
    }
}
