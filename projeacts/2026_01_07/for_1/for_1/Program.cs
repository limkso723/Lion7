using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Iteration: " + i);
            //}

            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine($"👹 고블린 #{i} 생성!");
            //}

            //Console.WriteLine("=== 게임 시작 카운트다운");
            //for (int i = 5; i > 0; i--)
            //{
            //    Console.WriteLine($"{i}...");
            //}

            //string sword = "무한의 대검";

            //Console.WriteLine("당신은 20번 뽑기가 가능합니다. 지금 실행합니다.");

            //Random rand = new Random();
            //int random = 0;

            //for (int i=0; i<20; i++)
            //{
            //    random = rand.Next(1, 101); // 1 ~ 100

            //    if (random >= 1 && random <= 10)
            //    {
            //        sword = "무한의 대검";
            //    }
            //    else if (random >= 11 && random <= 30)
            //    {
            //        sword = "카타나";
            //    }
            //    else if (random >= 31 && random <= 60)
            //    {
            //        sword = "엑스칼리버";
            //    }
            //    else if (random >= 61 && random <= 100)
            //    {
            //        sword = "정기정검";
            //    }

            //    Console.WriteLine(sword);
            //}

            //Console.Write("오늘의 온도는 몇도인가요?! : ");
            //int ondo = int.Parse(Console.ReadLine());

            //if (ondo >= 30)
            //{ Console.WriteLine($"현재 온도 : {ondo}℃"); Console.WriteLine("매우 더워요! 반팔과 반바지를 입으세요."); }
            //else if (ondo >= 20)
            //{ Console.WriteLine($"현재 온도 : {ondo}℃"); Console.WriteLine("적장해요! 긴팔 티셔츠를 입으세요."); }
            //else if (ondo >= 10)
            //{ Console.WriteLine($"현재 온도 : {ondo}℃"); Console.WriteLine("쌀쌀해요! 가디건이나 자켓을 챙기세요."); }
            //else if (ondo >= 0)
            //{ Console.WriteLine($"현재 온도 : {ondo}℃"); Console.WriteLine("추워요! 코트를 입으세요."); }
            //else if (ondo < 0)
            //{ Console.WriteLine($"현재 온도 : {ondo}℃"); Console.WriteLine("매우 추워요! 패팅과 목도리가 필요해요."); }

            Console.WriteLine("\n=== 캐릭터 직업 선택 ===");
            Console.Write("캐릭터를 생성하시겠습니까? (Y or N) : ");
            string create = Console.ReadLine();

            if (create == "Y" || create == "y")
            {
                Console.WriteLine("1. 전사  2. 마법사  3. 궁수 4. 도적");
                Console.Write("직업을 선택하세요 (1~4) : ");
                int job = int.Parse(Console.ReadLine());
                switch (job)
                {
                    case 1:
                        Console.WriteLine("=== 캐릭터 생성 완료 ===");
                        Console.WriteLine("전사를 선택하셨습니다. 전사 - 체력과 방어력이 높습니다.");
                        Console.WriteLine("시작 스탯 : HP + 50, 공격력 + 10");
                        break;
                    case 2:
                        Console.WriteLine("=== 캐릭터 생성 완료 ===");
                        Console.WriteLine("마법사를 선택하셨습니다. 마법사 - 강력한 마법 공격이 가능합니다.");
                        Console.WriteLine("시작 스탯 : 마나 + 100, 마법력 + 20");
                        break;
                    case 3:
                        Console.WriteLine("=== 캐릭터 생성 완료 ===");
                        Console.WriteLine("궁수를 선택하셨습니다. 궁수 - 원거리 공격에 특화 되어 있습니다.");
                        Console.WriteLine("시작 스탯 : 민첩 + 15, 크리티컬 + 10%");
                        break;
                    case 4:
                        Console.WriteLine("=== 캐릭터 생성 완료 ===");
                        Console.WriteLine("도적를 선택하셨습니다. 도적 - 빠른 속도와 회피가 가능합니다.");
                        Console.WriteLine("시작 스탯 : 민첩 + 20, 회피율 + 15%");
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 다시 시도해주세요.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("캐릭터 생성을 취소하셨습니다.");

            }
        }
    }
 }
