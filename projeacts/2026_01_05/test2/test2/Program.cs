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

            // 실수 데이터 형식 : 소수점을 포함한 숫자를 표현.
            //float singlePrecision = 3.14f; // 4바이트 , 단정밀도 실수.
            //double doublePrecision = 3.141592653589793; // 8바이트 , 배정밀도 실수.
            //decimal highPrecision = 3.1415926535897932384626433832m; // 16바이트 , 고정밀도 실수.

            //Console.WriteLine(singlePrecision);
            //Console.WriteLine(doublePrecision);
            //Console.WriteLine(highPrecision);

            // 접미사 사용 : 숫자의 데이터 형식을 명시
            //int integerValue = 100; // 기본 정수형(int)
            //long longValue = 100L; // 접미사 L을 사용하여 long형으로 지정 (정수)
            //float floatValue = 3.14f; // 접미사 f를 사용하여 float형으로 지정 (실수)
            //double doubleValue = 3.14; // 기본 실수형(double)
            //decimal decimalValue = 3.14m; // 접미사 m을 사용하여 decimal형으로 지정 (고정밀도 실수)

            //Console.WriteLine(integerValue);
            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(doubleValue);
            //Console.WriteLine(decimalValue);

            // char 형식 : 단일 문자 표현
            //char letter = 'A'; // 문자 'A' 저장
            //char symbol = '#'; // 특수 문자 '#' 저장
            //char number = '9'; // 숫자 형태의 문자 저장(숫자 아님)

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);


            // 출력
            // ===== 캐릭터 능력치 =====
            // float 이동속도 5.5
            // double 공격속도 1.25
            // decimal 아이템 가격 12.99

            const float speed = 5.5f;
            const double attackSpeed = 1.25;
            const decimal itemPrice = 12.99m;

            Console.WriteLine("===== 캐릭터 능력치 =====");
            Console.WriteLine("이동속도: " + speed);
            Console.WriteLine("공격속도: " + attackSpeed);
            Console.WriteLine("아이템 가격: " + itemPrice);


        }
    }
}
