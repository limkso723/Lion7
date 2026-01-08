using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int a = 100;
            //if (a >= 90)
            //{
            //    Console.WriteLine("1 통과");
            //}
            //if (a >= 80)
            //{
            //    Console.WriteLine("2 통과");
            //}

            //int sHP = 30;
            //int maxHp = 100;

            //int enemyDistance = 5;
            //int attacvkRange = 3;


            //if (sHP <= maxHp * 0.5)
            //{
            //    Console.WriteLine("체력이 50% 이하 입니다.");
            //    if (sHP <= maxHp * 0.3)
            //    {
            //        Console.WriteLine("경고 체력이 30% 이하 입니다.");
            //        Console.WriteLine("회복 아이템을 사용하세요!");
            //        if (sHP == 0)
            //        {
            //            Console.WriteLine("게임 오버!");
            //            Console.WriteLine("부활 지점에서 다시 시작합니다.");
            //        }
            //    }
            //}

            //if (enemyDistance <= attacvkRange) {
            //    Console.WriteLine("\n 적이 사거리 안에 있습니다!");
            //    Console.WriteLine("공격 가능!!");
            //}

            // 아이템 구매 시스템
            //int playerGold = 500;
            //int itemPrice = 250;
            //string itemName = "강철 검";

            //Console.WriteLine("==== 상점 =====");
            //Console.WriteLine($"아이템 : {itemName}");
            //Console.WriteLine($"가격 : {itemPrice}");
            //Console.WriteLine($"소지금 : {playerGold}");
            //Console.WriteLine();

            //if (playerGold >= itemPrice)
            //{

            //    // 구매 가능
            //    playerGold -= itemPrice;
            //    Console.WriteLine("구매 성공!");
            //    Console.WriteLine($"{itemName}을 획득했습니다!");
            //    Console.WriteLine($"남은 골드 : {playerGold}골드");
            //}
            //else {
            //    int needGold = itemPrice - playerGold;
            //    Console.WriteLine("골드가 부족합니다!");
            //    Console.WriteLine($"필요한 골드 : {needGold}골드 더 필요");
            //}


            //Console.WriteLine("=== 던전 입장 ===");
            //int playerLevel = 48;
            //int requiredLevel = 50;

            //if (playerLevel >= requiredLevel)
            //{
            //    Console.WriteLine("던전에 입장합니다.!");
            //    Console.WriteLine("전투 준비!");
            //} else
            //{
            //    Console.WriteLine("레벨이 부족합니다!");
            //    Console.WriteLine($"필요 레벨 : {requiredLevel}");
            //    Console.WriteLine($"현재 레벨 : {playerLevel}");
            //    Console.WriteLine($"레벨업이 필요합니다. {requiredLevel-playerLevel}레벨");
            //}

            // 캐릭터 상태 판정
            Console.WriteLine("=== 캐릭터 상태 ===");
            int health = 50;

            if (health >= 80) {
                Console.WriteLine("상태 : 매우 좋음");
            }
            else if (health >= 60) {
                Console.WriteLine("상태 : 좋음");
            } else if (health >= 40) {
                Console.WriteLine("상태 : 보통");
            } else if (health >= 20) {
                Console.WriteLine("상태 : 위험");
            } else {
                Console.WriteLine("상태 : 매우 위험!");
            }





        }
    }
}
