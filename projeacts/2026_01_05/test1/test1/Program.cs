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
            //const double Pi = 3.14159;
            //const int MaxItems = 100;

            //Console.WriteLine("Value of Pi: " + Pi);
            //Console.WriteLine("Value of MaxItems: " + MaxItems);

            //const int players = 4;
            //const int golds = 1000;
            //const string bu = "1.0.0";

            //Console.WriteLine("```");
            //Console.WriteLine("=== 게임 설정 ===");
            //Console.WriteLine($"최대 플레이어 : {players}명");
            //Console.WriteLine($"시작 골드 : {golds}G");
            //Console.WriteLine($"버전 : {bu}");
            //Console.WriteLine("```");

            //int integerNum = 10;
            //float floatNum = 3.14f;
            //double doubleNum = 3.14159;

            //Console.WriteLine("Integer: " + integerNum);
            //Console.WriteLine("floatNum: " + floatNum);
            //Console.WriteLine("doubleNum: " + doubleNum);


            //          | 타입 | 크기 | 범위 | 용도 |
            // byte     | 1바이트 | 0 ~ 255 | 작은 정수(양수), 메모리 절약 | 나이, 레벨 등
            // sbyte    | 1바이트 | -128 ~ 127 | 작은 정수(음수 포함), 메모리 절약 | 온도, 좌표 등
            // short    | 2바이트 | -32,768 ~ 32,767 | 중간 크기 정수 | 공격력, 체력 등
            // ushort   | 2바이트 | 0 ~ 65,535 | 중간 크기 정수(양수), 메모리 절약 | 점수, 거리 등
            // int      | 4바이트 | -2,147,483,648 ~ 2,147,483,647 | 일반적인 정수 | 소지금, 경험치 등
            // uint     | 4바이트 | 0 ~ 4,294,967,295 | 일반적인 정수(양수), 메모리 절약 | 인구수, 파일 크기 등
            // long     | 8바이트 | -9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807 | 큰 정수 | 누적 점수, 대용량 데이터 등
            // ulong    | 8바이트 | 0 ~ 18,446,744,073,709,551,615 | 큰 정수(양수), 메모리 절약 | 천문학적 수치, 대용량 파일 크기 등

            byte level = 50; // 레벨 (0~255면 충분)
            short attack = 1500; // 공격력 (0~32,767면 충분)
            int gold = 1234567; // 소지금
            long experience = 99999999L; // 경험치

            Console.WriteLine("==== 캐릭터 정보 ====");
            Console.WriteLine($"레벨 : {level}");
            Console.WriteLine($"공격력 : {attack}");
            Console.WriteLine($"소지금 : {gold:N0}골드");
            Console.WriteLine($"경험치 : {experience:N0}명");


            Console.WriteLine("\n==== 타입별 최대값 ===");
            Console.WriteLine($"byte 최대값 : {byte.MaxValue}");
            Console.WriteLine($"short 최대값 : {short.MaxValue}");
            Console.WriteLine($"int 최대값 : {int.MaxValue:N0}");
            Console.WriteLine($"logn 최대값 : {long.MaxValue:N0}");



        }
    }
}
