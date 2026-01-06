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

            // 사용자 입력을 문자열로 받기
            //Console.Write("이름을 입력하세요: ");
            //string name = Console.ReadLine(); // 사용자로부터 이름 입력 받기
            //Console.Clear();
            //Console.Write("레벨을 입력하세요: ");
            //string level = Console.ReadLine();
            //Console.Clear();
            //Console.Write("게임을 입력하세요: ");
            //string game = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine($"안녕하세요, {name}님! 당신의 나이는 {level}고, 좋아하시는 게임은 {game} 이군요.");

            //Console.Write("나이를 입력하세요: ");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);
            //Console.Clear();

            //Console.WriteLine($"당신의 나이는 {age}살 입니다.");

            // 이진수를 정수로 변환
            //Console.Write("2진수를 입력하세요: ");
            //string binaryInput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryInput, 2); // 2진수 -> 10진수 변환

            //Console.WriteLine($"입력한 2진수 {binaryInput}는 10진수로 {decimalValue}입니다.");

            // 사용자로부터 이름 입력 받기


            //Console.WriteLine($"==== 캐릭터 생성 ====");
            //Console.Write("캐릭터 이름을 입력하세요: ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"환영합니다, {name}님!");
            //Console.Write($"시작 레벨을 입력하세요.");
            //string level = Console.ReadLine();
            //Console.WriteLine($"{name}님의 시작 레벨은 {level}입니다.");

            // var를 사용하여 변수 선언
            //var name = "Alice"; // 문자열로 추론
            //var age = 25;       // 정수로 추론
            //var isStudent = true; // 논리값으로 추론

            //Console.WriteLine($"이름: {name}, 나이: {age}, 학생 여부: {isStudent}");

            // default 키워드를 사용한 기본값 설정
            //int defaultInt = default; // 0
            //string defaultString = default; // null
            //bool defaultBool = default; // false

            //Console.WriteLine($"정수 기본값: {defaultInt}");
            //Console.WriteLine($"정수 기본값: {defaultString}");
            //Console.WriteLine($"정수 기본값: {defaultBool}");

            // 암시적 변환 (작은 타입 -> 큰 타입)
            int smallNumber = 100;
            long bigNumber = smallNumber; // int -> long 자동 변환
            double doubleNumer = smallNumber; // int -> double 자동 변환

            Console.WriteLine("==== 암시적 변환 ====");
            Console.WriteLine($"int: {smallNumber}");
            Console.WriteLine($"long: {bigNumber}");
            Console.WriteLine($"double: {doubleNumer}");

            // 명시적 변환 (큰 타입 -> 작은 타입)
            double pi = 3.14159;
            int intPi = (int)pi; // 소수점을 버림 (명시적 변환 필요)

            Console.WriteLine("==== 명시적 변환 ====");
            Console.WriteLine($"double: {pi}");
            Console.WriteLine($"int로 변환: {intPi}");

            // int, flaot, double, char, long 정파
            // string 사파 , 커스터마이징
            // 스타벅스 tall 벤티 그란데
            // 개인 텀블러
            // 클래스 신공 구절은 다 외우기 힘듬

            // 문자열을 숫자로 변환
            string scoreText = "95";
            int score = int.Parse(scoreText); // 문자열 -> 정수 변환

            string priceText = "19.99";
            double price = double.Parse(priceText); // 문자열 -> 실수 변환

            Console.WriteLine("==== 문자열을 숫자로 변환 ====");
            Console.WriteLine($"점수(문자열): {scoreText} -> 숫자 {score}");
            Console.WriteLine($"가격(문자열): {priceText} -> 숫자 {price}");

            // 숫자를 문자열로 변환
            int playerLevel = 50;
            string levelText = playerLevel.ToString(); // 정수 -> 문자열 변환

            Console.WriteLine("==== 숫자를 문자열로 =====");
            Console.WriteLine($"레벨(숫자): {playerLevel} -> 문자열 '{levelText}'");


        }
    }
}
