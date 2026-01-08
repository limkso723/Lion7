using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //while(true)
            //{
            //    Console.WriteLine("Hello World!");
            //    System.Threading.Thread.Sleep(1000);
            //}

            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    System.Threading.Thread.Sleep(1000);
            //    i++;
            //}

            //int i = 10;
            //while (i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //int sum = 0;
            //int i = 1;
            //while (i < 6)
            //{
            //    Console.WriteLine(i);
            //    sum += i;
            //    i++;

            //    Console.WriteLine(sum);
            //}

            //int coins = 0;
            //int target = 50;
            //int day = 0;
            //while (coins < target)
            //{
            //    day++;
            //    coins += 10;
            //    Console.WriteLine($"{day}일차 : 코인 {coins}개");


            //}
            //Console.WriteLine($"목표 달성! : {day}일 걸렸습니다!");


            //int x = 5;
            //do
            //{
            //    Console.WriteLine(x);
            //    x--;
            //} while (x > 0);



            //string choice;
            //int totalPrice = 0;


            //do
            //{
            //    Console.WriteLine("메뉴판");
            //    Console.WriteLine("1. 짜장면 - 5,000원");
            //    Console.WriteLine("2. 짬뽕 - 6,000원");
            //    Console.WriteLine("3. 탕수육 - 15,000원");
            //    Console.WriteLine("4. 볶음밥 - 7,000");
            //    Console.WriteLine("0. 주문 완료!");
            //    Console.WriteLine("======================================");
            //    Console.Write("메뉴 번호를 선택하세요. : ");

            //    choice = Console.ReadLine();

            //    // 메뉴 선택 처리
            //    switch (choice)
            //    {
            //        case "1":
            //            Console.WriteLine("짜장면 추가! (+5,000원)");
            //            totalPrice += 5000;
            //            break;
            //        case "2":
            //            Console.WriteLine("짜장면 추가! (+5,000원)");
            //            totalPrice += 5000;
            //            break;
            //        case "3":
            //            Console.WriteLine("짜장면 추가! (+5,000원)");
            //            totalPrice += 5000;
            //            break;
            //        case "4":
            //            Console.WriteLine("짜장면 추가! (+5,000원)");
            //            totalPrice += 5000;
            //            break;
            //        case "0":
            //            Console.WriteLine("주문이 완료되었습니다!");
            //            break;
            //        default:
            //            Console.WriteLine("잘못된 선택입니다.");
            //            break;
            //    }

            //    if (choice != "0")
            //    {
            //        Console.WriteLine($"현재까지의 총 금액은 {totalPrice}원 입니다.");
            //    }

            //    } while (choice != "0");
            //Console.WriteLine($"최종 결제 금액은 {totalPrice}원 입니다. 감사합니다!");

            //for (int i = 0; i <= 10; i++)
            //{

            //    if (i == 5)
            //        break;
            //    Console.WriteLine(i);


            //}

            for (int i = 1; i <= 10; i++)
            {

                if (i % 2 == 0)
                    continue;
                Console.WriteLine(i);


            }
        }
    }
}
