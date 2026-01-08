using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 10;
            ConsoleKeyInfo keyInfo;
            Console.CursorVisible = false; // 커서 숨기기
            const int targetX = 5;
            const int targetY = 5;
            bool ty = true;
            maploop:
            while (ty == true)
            {

                Console.Clear();

                Console.SetCursorPosition(x, y); // 좌표

                Console.Write("★");

                Console.SetCursorPosition(targetX, targetY);
                Console.Write("□ 대장간으로 가기");


                if (x == targetX && y == targetY)
                {
                    Random rand = new Random();
                    Console.Clear();
                    Console.WriteLine("== 대장장이 키우기 ==");

                    int pmoney = 100;
                    int input;
                    int rnd;

                    Thread.Sleep(500);

                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("1. 나무캐기");
                        Console.WriteLine("2. 장비뽑기");
                        Console.WriteLine("3. 나가기");
                        Console.Write("입력: ");
                        input = int.Parse(Console.ReadLine());

                        if (input == 1)
                        {
                            while (true)
                            {
                                Console.WriteLine("나무캐기 (엔터)");
                                Console.WriteLine("뒤로가기 x");

                                string str = Console.ReadLine();

                                pmoney += 100;
                                Console.WriteLine("소지금 : " + pmoney);
                                if (str == "x")
                                {
                                    Console.WriteLine("뒤로가기");
                                    Console.Clear();
                                    Console.WriteLine("== 대장장이 키우기 ==");
                                    break;
                                }
                            }

                        }
                        else if (input == 2)
                        {
                            // 장비뽑기
                            if (pmoney >= 1000)
                            {
                                pmoney -= 1000;
                                int Arank = 0, Brank = 0, Crank = 0, Drank = 0, Srank = 0, SSrank = 0, SSSrank = 0;
                                // 20번 뽑기
                                for (int i = 1; i <= 20; i++)
                                {
                                    rnd = rand.Next(1, 101);


                                    if (rnd == 1)
                                    {
                                        SSSrank++;
                                    }
                                    else if (rnd >= 2 && rnd <= 6)
                                    {
                                        SSrank++;
                                    }
                                    else if (rnd >= 7 && rnd <= 17)
                                    {
                                        Srank++;
                                    }
                                    else if (rnd >= 18 && rnd <= 38)
                                    {
                                        Arank++;
                                    }
                                    else if (rnd >= 39 && rnd <= 59)
                                    {
                                        Brank++;
                                    }
                                    else if (rnd >= 60 && rnd <= 78)
                                    {
                                        Crank++;
                                    }
                                    else
                                    {
                                        Drank++;
                                    }

                                    if (i % 2 == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("== 대장장이 키우기 ==");
                                        Console.WriteLine(" ");
                                        Console.WriteLine("                        ▦");
                                        Console.WriteLine("                      ▦▦▦");
                                        Console.WriteLine("                    ▦▦▦▦▦");
                                        Console.WriteLine("                  ▦▦▦▦▦▦▦");
                                        Console.WriteLine("                ▦▦▦▦▦▦▦▦▦");
                                        Console.WriteLine("              ▦▦▦▦▦▦▦▦▦▦▦");
                                        Console.WriteLine("              │                   │");
                                        Console.WriteLine("              │   ──         ──   │");
                                        Console.WriteLine("              │    >          <   │");
                                        Console.WriteLine("              │                   │");
                                        Console.WriteLine("              │         ┘         │");
                                        Console.WriteLine("              │                   │");
                                        Console.WriteLine("              │      └────┘       │");
                                        Console.WriteLine("              └───────────────────┘");
                                        Console.WriteLine("                     │     │");
                                        Console.WriteLine("                     │     │");
                                        Console.WriteLine("        ┌────────────┘     └────────────┐");
                                        Console.WriteLine("        │                               │");
                                        Console.WriteLine("        │                               │");
                                        Console.WriteLine("        │    │                    │     │");
                                        Console.WriteLine("        │    │                    │     │");
                                        Console.WriteLine("        │    │                    │     │");
                                        Console.WriteLine("        │    │                    │     │");
                                        Console.WriteLine("        │    │                    │     │");
                                        Console.WriteLine("        │    │                    │     │");
                                        Console.WriteLine("        │    │                    │     │");
                                        Console.WriteLine("        │    │                    │     │");
                                        Console.WriteLine("                                  /     / ");
                                        Console.WriteLine("                                 /     /");
                                        Console.WriteLine("                                /     /");
                                        Console.WriteLine("                               /     /");
                                        Console.WriteLine("                   ┌───┐      /     /");
                                        Console.WriteLine("                   │   │======□□□====");
                                        Console.WriteLine("                   └───┘        ");
                                        Console.WriteLine("       ┌─────────────────────────────────┐     ");
                                        Console.WriteLine("       │                                 │     ");
                                        Console.WriteLine("       │                                 │     ");
                                        Console.WriteLine("       └─────────────────────────────────┘     ");
                                        Console.WriteLine("            │                       │    ");
                                        Console.WriteLine("            │                       │     ");
                                        Console.WriteLine("       └─────────────────────────────────┘     ");
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("== 대장장이 키우기 ==");
                                        Console.WriteLine(" ");
                                        Console.WriteLine("                        ▦");
                                        Console.WriteLine("                      ▦▦▦");
                                        Console.WriteLine("                    ▦▦▦▦▦");
                                        Console.WriteLine("                  ▦▦▦▦▦▦▦");
                                        Console.WriteLine("                ▦▦▦▦▦▦▦▦▦");
                                        Console.WriteLine("              ▦▦▦▦▦▦▦▦▦▦▦");
                                        Console.WriteLine("              │                   │");
                                        Console.WriteLine("              │   ──         ──   │");
                                        Console.WriteLine("              │   ＠          ＠  │");
                                        Console.WriteLine("              │                   │");
                                        Console.WriteLine("              │         ┘         │");
                                        Console.WriteLine("              │                   │");
                                        Console.WriteLine("              │      └────┘       │");
                                        Console.WriteLine("              └───────────────────┘");
                                        Console.WriteLine("                     │     │");
                                        Console.WriteLine("                     │     │");
                                        Console.WriteLine("        ┌────────────┘     └────────────┐");
                                        Console.WriteLine("        │                               │");
                                        Console.WriteLine("        │                               │");
                                        Console.WriteLine("        │    │                    │     │");
                                        Console.WriteLine("        │    │                    │     │");
                                        Console.WriteLine("        │    │                    │     │");
                                        Console.WriteLine("        │    │                    │     │");
                                        Console.WriteLine("        │    │                    │     │");
                                        Console.WriteLine("        │    │                    │     │");
                                        Console.WriteLine("        │    │                    │     │");
                                        Console.WriteLine("        │    │                    │     │");
                                        Console.WriteLine("                ┌───┐            ┘     │ ");
                                        Console.WriteLine("                │   │======□□□====                     │");
                                        Console.WriteLine("                └───┘               ┘");
                                        Console.WriteLine("                               ");
                                        Console.WriteLine("                         ");
                                        Console.WriteLine("                   ");
                                        Console.WriteLine("                           ");
                                        Console.WriteLine("       ┌─────────────────────────────────┐     ");
                                        Console.WriteLine("       │                                 │     ");
                                        Console.WriteLine("       │                                 │     ");
                                        Console.WriteLine("       └─────────────────────────────────┘     ");
                                        Console.WriteLine("            │                       │    ");
                                        Console.WriteLine("            │                       │     ");
                                        Console.WriteLine("       └─────────────────────────────────┘     ");
                                    }

                                    Thread.Sleep(500);
                                }
                                Console.WriteLine("뽑기 결과");
                                Console.WriteLine($"SSS : {SSSrank}, SS : {SSrank}, S : {Srank}, A : {Arank}, B : {Brank}, C : {Crank}, D : {Drank}");
                            }
                            else
                            {
                                Console.WriteLine("소지금이 부족합니다.");
                                Thread.Sleep(500);
                            }


                        }
                        else if (input == 3)
                        {
                            Console.WriteLine("게임을 종료합니다.");
                            //Environment.Exit(0);

                            //break;
                            //continue maploop;

                        }
                    }
                    //break;


                }



                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (y > 0) y--; break;
                    case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
                    case ConsoleKey.LeftArrow: if (x > 0) x--; break;
                    case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
                    case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                    case ConsoleKey.Escape: break;
                }
                continue;

            }

            // 대장장이 키우기




        }
    }
}
