using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 연산자
            //int a = 5, b = 3;
            //int sum = a + b; // 산술연산자 사용 +
            //bool isEqual = (a == b); // 관계형 연산자 사용

            //Console.WriteLine($"합: {sum}");
            //Console.WriteLine($"a와 b가 같은가?: {isEqual}");

            // 단항 연산자
            //int number = 5;
            //Console.WriteLine(+number); // 양수 출력 : 5
            //Console.WriteLine(-number); // 음수 출력 : -5

            //bool flag = true;
            //Console.WriteLine(!flag); // 논리 부정 출력 : False

            //int a = 10, b = 3;

            //Console.WriteLine(a + b); // 덧셈 출력 : 13
            //Console.WriteLine(a - b); // 뺄셈 출력 : 7
            //Console.WriteLine(a * b); // 곱셈 출력 : 30
            //Console.WriteLine(a / b); // 나눗셈 출력 : 3
            //Console.WriteLine(a % b); // 나머지 출력 : 1

            // 문자열 연결 연산자
            //string str1 = "Hello, ";
            //string str2 = "World!";

            //Console.WriteLine(str1 + str2); // 문자열 연결 출력 : Hello, World!

            // int a = 5, b = 4;

            //sum = a + b;
            // a = a + b;
            // a += b; // 복합 대입 연산자
            //a *= b; // a /= b;

            //Console.WriteLine($"a: {a}, b: {b}");

            //a += b;
            //Console.WriteLine($"a: {a}");
            //a = 5;
            //a -= b;
            //Console.WriteLine($"a: {a}");
            //a = 5;
            //a *= b;
            //Console.WriteLine($"a: {a}");
            //a = 5;
            //a /= b;
            //Console.WriteLine($"a: {a}");
            //a = 5;
            //a %= b;
            //Console.WriteLine($"a: {a}");

            //string str1 = "안녕. "; ;
            //string str2 = "반가워!";

            //str1 += str2;

            //Console.WriteLine(str1);

            // 캐릭터 스탯 계산
            //int baseAttack = 50;
            //int weaponDamage = 30;
            //int totalAttack = baseAttack + weaponDamage;

            //Console.WriteLine("=== 공격력 계산");
            //Console.WriteLine($"기본 공격력: {baseAttack}");
            //Console.WriteLine($"무기 공격력: {weaponDamage}");
            //Console.WriteLine($"총 공격력: {totalAttack}");

            //// 데미지 계산
            //int playerHealth = 100;
            //int damage = 25;
            //playerHealth = playerHealth - damage;

            //Console.WriteLine("=== 데미지 계산");
            //Console.WriteLine($"받은 데미지: {damage}");
            //Console.WriteLine($"남은 체력: {playerHealth}");

            //// 경험치 계산
            //int monsterSkilled = 5;
            //int expPerMonster = 100;
            //int totalExp = monsterSkilled * expPerMonster;

            //Console.WriteLine("=== 경험치 획득");
            //Console.WriteLine($"처치한 몬스터 수: {monsterSkilled}");
            //Console.WriteLine($"몬스터 당 경험치: {expPerMonster}");
            //Console.WriteLine($"총 획득 경험치: {totalExp}");

            // 증강연산자 ++ --

            //int b = 5;

            //b++; // 후위 증가
            //Console.WriteLine($"b: {b}"); // b: 6
            //b--; // 후위 감소
            //Console.WriteLine($"b: {b}"); // b: 5

            // === 몬스터 처치 ===
            // 고블린 처치! (킬 카운트 :1)
            // 오크 처치! (킬 카운트 :2)
            // 드래곤 처치! (킬 카운트 :3)
            // 총 처치한 몬스터 수: 3

            // === 사격 ===
            // 남은 탄약 : 30

            //int ammo = 30;
            //int killCount = 0;

            //Console.WriteLine("=== 카운트 다운 ===");
            //Console.WriteLine("3");
            //Console.WriteLine("2");
            //Console.WriteLine("1");

            //Console.WriteLine("발사!");

            //Console.WriteLine("탕! 당신은 고블린을 처치 했다!");
            //ammo--;
            //killCount++;
            //Console.WriteLine($"당신의 남은 탄약 : {ammo}, 총 처치한 몬스터 수 : {killCount}");
            //Console.WriteLine("탕! 탕! 당신은 오크를 처치 했다!");
            //ammo -= 2;
            //killCount += 2;
            //Console.WriteLine($"당신의 남은 탄약 : {ammo}, 총 처치한 몬스터 수 : {killCount}");
            //Console.WriteLine("탕! 당신은 고블린을 처치 했다!");
            //ammo--;
            //killCount++;
            //Console.WriteLine($"당신의 남은 탄약 : {ammo}, 총 처치한 몬스터 수 : {killCount}");
            //Console.WriteLine("탕! 탕! 탕! 당신은 드래곤을 처치 했다!");
            //ammo-=3;
            //killCount+=3;
            //Console.WriteLine($"당신의 남은 탄약 : {ammo}, 총 처치한 몬스터 수 : {killCount}");

            // 관계형 연산자와 논리 연산자
            //int x = 5;
            //int y = 10;

            //Console.WriteLine(x < y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x <= y);
            //Console.WriteLine(x >= y);
            //Console.WriteLine(x != y);
            //Console.WriteLine(x == y);

            // AND, OR, NOT

            //bool a = true;
            //bool b = true;

            //Console.WriteLine(a && b); // AND

            //bool a= false, b = false;
            //Console.WriteLine(a || b); // OR

            //!
            //bool a = false;
            //Console.WriteLine(!a); // NOT

            //int x = 5; // 0101
            //int y = 3; // 0011

            //string binary = Convert.ToString(x & y, 2);

            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            //binary = Convert.ToString(x | y, 2);

            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            //int value = 4;
            //string binary = Convert.ToString(value<<1, 2);

            //Console.WriteLine($"값: {value}, 2진수: {binary.PadLeft(8, '0')}");

            //binary = Convert.ToString(value >> 1, 2);
            //Console.WriteLine($"값: {value}, 2진수: {binary.PadLeft(8, '0')}");



            int currentHP = 80;
            int maxHP = 100;

            Console.WriteLine("=== 모험 일기 ===");
            Console.WriteLine("당신은 숲을 걸어가고 있습니다.");
            Console.WriteLine($"현재 당신의 체력은 {currentHP}/{maxHP}입니다.");
            Console.WriteLine($"앗! 고블린과 조우했어요. 한대를 허용했지만 무사히 물리치셨네요. 체력이 25 깎입니다.");
            currentHP -= 25;
            Console.WriteLine($"현재 당신의 체력은 데미지를 입어 {currentHP}/{maxHP}입니다.");
            Console.WriteLine($"당신은 급하게 체력 회복 물약을 먹었습니다. 회복물약은 체력을 30 회복 시켜줍니다.");
            currentHP += 30;
            Console.WriteLine($"현재 당신의 체력은 물약을 먹어 {currentHP}/{maxHP}입니다.");
            Console.WriteLine($"이런 아까 고블린에게 맞은 공격에 독이 있었네요. 독 데미지로 인해 체력이 5 깎입니다.");
            currentHP -= 5;
            Console.WriteLine($"현재 당신의 체력은 {currentHP}/{maxHP}입니다.");


            int expPerMonster = 150;
            int monstersKilled = 0;
            int expForLevelUp = 500;

            Console.WriteLine("\n=== 사냥 일기 ===");
            Console.WriteLine("당신은 길을 걷다가 고블린을 발견 했습니다. 겨우 사냥을 완료 했습니다.");
            monstersKilled++;
            expForLevelUp -= expPerMonster;
            Console.WriteLine($"고블린 처치! (킬 카운트 : {monstersKilled}, 경험치 획득 : {expPerMonster}, 레벨업 까지 앞으로 {expForLevelUp}남았습니다.)");
            Console.WriteLine("당신은 길을 걷다가 오크를 발견 했습니다. 겨우 사냥을 완료 했습니다.");
            monstersKilled++;
            expForLevelUp -= expPerMonster;
            Console.WriteLine($"오크 처치! (킬 카운트 : {monstersKilled}, 경험치 획득 : {expPerMonster}, 레벨업 까지 앞으로 {expForLevelUp}남았습니다.)");
            Console.WriteLine("당신은 길을 걷다가 드래곤을 발견 했습니다. 겨우 사냥을 완료 했습니다.");
            monstersKilled++;
            expForLevelUp -= expPerMonster;
            Console.WriteLine($"드래곤 처치! (킬 카운트 : {monstersKilled}, 경험치 획득 : {expPerMonster}, 레벨업 까지 앞으로 {expForLevelUp}남았습니다.)");



            int totalGold = 1234;
            int partymembers = 5;

            Console.WriteLine("\n=== 분배 일기 ===");
            Console.WriteLine($"현재 당신은 총 {totalGold}를 길드에게서 받았습니다.");
            Console.WriteLine($"당신은 자신을 포함한 {partymembers}명의 파티원과 골드를 균등 분배 하기로 했습니다.");
            Console.WriteLine($"각 파티원은 {totalGold / partymembers}골드를 받게 됩니다.");
            Console.WriteLine($"골드 분배 후 남은 골드는 {totalGold % partymembers}골드 입니다.");



            int playerLevel = 35;
            int requiredLevel = 30;
            bool haskey = true;
            int currentHP1 = 60;
            int maxHP1 = 100;

            Console.WriteLine("\n=== 던전 입장 조건 ===");
            Console.WriteLine($"던전에 입장하기 위한 조건이 있습니다.");
            Console.WriteLine($"레벨은 {requiredLevel}레벨 이상, 체력은 50% 이상 이어야 하고, 열쇠도 보유해야 합니다.");
            Console.WriteLine($"현재 당신의 레벨은 {playerLevel}레벨 입니다.");
            Console.WriteLine($"현재 당신의 레벨 조건은 {requiredLevel <= playerLevel}이기에 확인했습니다.");
            Console.WriteLine($"현재 당신의 열쇠 보유 여부는 {haskey}이기에 확인했습니다.");
            Console.WriteLine($"현재 당신의 체력은 50% 이상 조건은 {(maxHP1*0.5) < currentHP1}이기에 확인했습니다.");





            // 상점 할인 계산기

            int originlPrice = 5000;
            bool isVIP = true;
            bool hasCoupon = true;

            Console.WriteLine("\n=== 상점 할인 계산기 ===");
            Console.Write("이름을 입력하세요: ");
            string name = Console.ReadLine(); // 사용자로부터 이름 입력 받기

            Console.Write("몇 개를 구매하기 희망하시나요?: ");
            string count1= Console.ReadLine();
            int count = int.Parse(count1); // 문자열 -> 정수 변환

            Console.Write("VIP 쿠폰이 있으신가요? 있으시면 Y, 없으시면 N을 입력해주세요. : ");
            string Class = Console.ReadLine();
            if (Class == "Y") { isVIP = true; } else { isVIP = false; }

            Console.Write("할인 쿠폰이 있으신가요? 있으시면 Y, 없으시면 N을 입력해주세요. : ");
            string Coupon = Console.ReadLine();
            if (Coupon == "Y") { hasCoupon = true; } else { hasCoupon = false; }

            Console.Write("금액을 넣어주세요.: ");
            string money1 = Console.ReadLine();
            int money = int.Parse(money1);

            if (isVIP == false && hasCoupon == false)
            {
                if (originlPrice * count <= money) {
                    Console.WriteLine($"{name}님의 영수중 입니다.");
                    Console.WriteLine($"{count}개의 물건 가격은 총 {originlPrice * count}입니다.");
                    Console.WriteLine($"현금 {money}원을 받았습니다. 잔돈은 {money-(originlPrice * count)}원 입니다.");
                    Console.WriteLine($"안녕히가세요. {name}님");
                } 
                else { Console.WriteLine("금액이 부족합니다."); }
            }
            else if (isVIP == true && hasCoupon == false) 
            {
                if (originlPrice * count <= money)
                {
                    Console.WriteLine($"{name}님의 영수중 입니다.");
                    Console.WriteLine($"{count}개의 물건 가격은 총 {originlPrice * count}입니다.");
                    Console.WriteLine($"VIP 혜택으로 인해 할인 된 가격은 {(originlPrice * count) * 0.8}입니다.");
                    Console.WriteLine($"현금 {money}원을 받았습니다. 잔돈은 {money - ((originlPrice * count) * 0.8)}원 입니다.");
                    Console.WriteLine($"안녕히가세요. {name}님");
                }
                else { Console.WriteLine("금액이 부족합니다."); }
            }
            else if (isVIP == false && hasCoupon == true)
            {
                if (originlPrice * count <= money)
                {
                    Console.WriteLine($"{name}님의 영수중 입니다.");
                    Console.WriteLine($"{count}개의 물건 가격은 총 {originlPrice * count}입니다.");
                    Console.WriteLine($"할인 쿠폰 혜택으로 인해 할인 된 가격은 {(originlPrice * count) - 500}입니다.");
                    Console.WriteLine($"현금 {money}원을 받았습니다. 잔돈은 {money - ((originlPrice * count) - 500)}원 입니다.");
                    Console.WriteLine($"안녕히가세요. {name}님");
                }
                else { Console.WriteLine("금액이 부족합니다."); }
            }
            else if (isVIP == true && hasCoupon == true)
            {
                if (originlPrice * count <= money)
                {
                    Console.WriteLine($"{name}님의 영수중 입니다.");
                    Console.WriteLine($"{count}개의 물건 가격은 총 {originlPrice * count}입니다.");
                    Console.WriteLine($"VIP 및 할인 쿠폰 혜택으로 인해 할인 된 가격은 {((originlPrice * count) * 0.8) - 500}입니다.");
                    Console.WriteLine($"현금 {money}원을 받았습니다. 잔돈은 {money - (((originlPrice * count) * 0.8) - 500)}원 입니다.");
                    Console.WriteLine($"안녕히가세요. {name}님");
                }
                else { Console.WriteLine("금액이 부족합니다."); }
            }




        }
    }
}
