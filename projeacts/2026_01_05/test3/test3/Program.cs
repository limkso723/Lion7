using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // string 형식 : 여러 문자를 저장.
            //string greeting = "Hello, World!"; // 문자열 저장
            //string name = "Alice"; // 이름 저장

            //Console.WriteLine(greeting); // "Hello, World!" 출력
            //Console.WriteLine(name); // Alice 출력

            //string name = "홍길동";
            //char grade = 'A';

            //Console.WriteLine("** 실행 결과 **");
            //Console.WriteLine($"플레이어 : {name}");
            //Console.WriteLine($"등급 : {grade}등급 ★");
            //Console.WriteLine("게임에 오신 것을 환영합니다");

            //bool isRunning = true;
            //bool isFinished = false;

            //Console.WriteLine(isRunning);
            //Console.WriteLine(isFinished);


            bool T = true;
            bool F = false;
            int health = 80;

            Console.WriteLine("=== 게임 상태 ===");
            Console.WriteLine($"게임 실행 중 : {T}");
            Console.WriteLine($"일시정지 : {F}");
            Console.WriteLine($"열쇠 소지 : {F}");
            Console.WriteLine($"문 열림 : {F}");
            Console.WriteLine($"플레이어 생존 : {T}");
            Console.WriteLine();
            Console.WriteLine("=== 캐릭터 상태 ===");
            Console.WriteLine($"체력 : {health}");
            Console.WriteLine($"건강 상태 : {T}");
            Console.WriteLine($"위험 상태 : {F}");
        }
    }
}
