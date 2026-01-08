using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for(int i =1; i<=3; i++)
            //{

            //    for(int j =1; j<=3; j++)
            //    {
            //        Console.WriteLine($"i={i}, j={j}");
            //    }
            //    Console.WriteLine();

            //}

            //for (int i = 1; i <= 3; i++)
            //{

            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.Write("■");
            //    }
            //    Console.WriteLine();

            //}

            //for (int i = 0; i <= 2; i++)
            //{

            //    for (int j = 0; j <= 2; j++)
            //    {
            //        Console.Write($"({j}, {i}) ");
            //    }
            //    Console.WriteLine();

            //}

            //for (int i = 0; i <= 5; i++)
            //{
            //    for (int z = 6; z > i; z--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j <= 5; j++)
            //    {
            //        //Console.Write($"({j}, {i}) ");

            //        if (j <= i)
            //        {

            //            Console.Write("*");
            //            Console.Write(" ");
            //        }

            //    }
            //    Console.WriteLine();

            //}

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.Write($" ({i} X {j} = {i*j})");
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0 && j == 0)
                    {
                    Console.Write("집");
                    } else if (i == 3 && j == 3)
                    {
                        Console.Write("끝");
                    }
                    else
                    {
                        Console.Write("■");
                    }
                    
                }
                Console.WriteLine();
            }

        }
    }
}
