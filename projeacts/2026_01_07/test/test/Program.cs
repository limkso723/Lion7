using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int a = 10, b = 20;
            //int max = (a > b) ? a : b;
            //Console.WriteLine(max);

            //int score = 85;
            //String result = (score >= 60) ? "합격" : "불합격";
            //Console.WriteLine("=== 시험 결과 ===");
            //Console.WriteLine($"점수 {score}");
            //Console.WriteLine($"결과 {result}");

            //int level = 45;
            //string result = (level >= 50 ) ? "고급" : 
            //                (level >= 30 ) ? "중급" : "초급";

            //Console.WriteLine("=== 플레이어 등급 ===");
            //Console.WriteLine($"레벨 {level}");
            //Console.WriteLine($"등급 {result}");

            //int hels = 30;
            //int maxhels = 100;
            //string status = (hels >= maxhels * 0.7) ? "정상" :
            //                (hels >= maxhels * 0.3) ? "주의" : "위험";
            //Console.WriteLine("=== 플레이어 상태 ===");
            //Console.WriteLine($"현재 체력 {hels}/{maxhels}");
            //Console.WriteLine($"현재 상태 {status}");

            //// 연산자 우선순위
            //int result = 10 + 2 * 5; // 곱셈이 덧셈보다 우선
            //Console.WriteLine(result);

            //int adjustedResult = (10 + 2) * 5; // 괄호로 우선순위 변경
            //Console.WriteLine(adjustedResult);


            // 예제 2: 데미지 계산
            int baseDamage = 50;
            int bonusDamage = 20;
            double criticalMultiplier = 1.5;

            // 잘못된 계산
            double damage1 = baseDamage + bonusDamage * criticalMultiplier;
            // 올바른 계산
            double damage2 = (baseDamage + bonusDamage) * criticalMultiplier;

            Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            Console.WriteLine($"기본 데미지: {baseDamage}");
            Console.WriteLine($"보너스 데미지: {bonusDamage}");
            Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
            Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            Console.WriteLine($"올바른 계산: {damage2}");  // 105.0



        }
    }
}
