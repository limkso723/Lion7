using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 같은 데이터 타입의 변수를 쉼표로 구분해 한번에 선언.
            //int x = 10, y = 20, z = 30;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine("x + y + z = " + x + y + z);
            
            //int age = 10;
            //string name ="김철수";
            //Console.WriteLine("너의 이름은 {0}, 나이는 {1}", name, age);
            //Console.WriteLine($"나이: {age}"); // 주로 많이 쓰임

            int posX = 0, posY = 50, posZ = 100;

            Console.WriteLine("X : {0}, Y : {1}, Z : {2}", posX, posY, posZ);
            Console.WriteLine("X : " + posX + ", Y : " + posY + ", Z : " + posZ);
            Console.WriteLine($"X : {posX}, Y : {posY}, Z : {posZ}");

            int red = 255, green = 128, blue = 0;

            Console.WriteLine("red : {0}, green : {1}, blue : {2}", red, green, blue);
            Console.WriteLine("red : " + red +", green : " + green+ ", blue : " + blue);
            Console.WriteLine($"red : {red}, green : {green}, blue : {blue}");

        }
    }
}
