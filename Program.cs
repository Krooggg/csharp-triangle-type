
using System;

namespace _8._0_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte  číslo a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte  číslo b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte  číslo c:");
            int c = int.Parse(Console.ReadLine());



            if ((b + c > a) && (a + c > b) && (a + b > c))
            {
                if ((a == b) && (b == c) && (a == c))
                {
                    Console.WriteLine("Vaš torjúhelník je rovnostraný");
                } else {
                    if ((a == b) || (b == c) || (a == c))
                    {
                        Console.WriteLine("Vaš trojúhelník je rovnoramenný");
                    } else {
                         if ((Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) ||
                         (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2)) ||
                         (Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2)))
                         {
                                Console.WriteLine("Vaš trojúhelník je pravoúhlý");
                          } else {
                            Console.WriteLine("Vaš trojúhelník je obecný");
                          }
                    }
                }
            } else {
                Console.WriteLine("To není trojúhelník");
            }
        }
    }
}
