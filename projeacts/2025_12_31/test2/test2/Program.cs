using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 리터럴 선언.
            //int number = 10; // 정수형 리터럴.
            //double pi = 3.14; // 실수형 리터럴.
            //char letter = 'A'; // 문자 리터럴.
            //string name = "Alice"; // 문자열 리터럴.

            //Console.WriteLine(number); // 출력 10
            //Console.WriteLine(pi); // 출력 3.14
            //Console.WriteLine(letter); // 출력 A
            //Console.WriteLine(name); // 출력 Alice

            //리터럴 플레이 스코어 100, 파이 3.14, 등급 A, 플레이어 이름 홍길동

            int sc = 100;
            double pi = 3.14;
            char fc = 'A';
            string name = "홍길동";

            //결과 출력하기
            Console.WriteLine("스코어는 " + sc);
            Console.WriteLine("파이는 " + pi);
            Console.WriteLine("등급은 " + fc);
            Console.WriteLine("당신의 이름은 "+ name);
        }
    }
}
