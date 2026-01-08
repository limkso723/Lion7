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

            //int day = 3;

            //switch (day) {

            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    default :
            //        Console.WriteLine("존재하지 않는 요일입니다.");
            //        break;
            //}

            Console.WriteLine("==== 캐릭터 선택 화면 ====");
            Console.WriteLine("캐릭터를 생성하시겠습니까? Y or N : ");
            string count = (Console.ReadLine());
            bool count1 = (count == "Y" ) ? true : false;
            int day = 3;

            if (count1 == true) {
                Console.WriteLine("어떤 캐릭터를 선택하시겠습니까?");
                Console.WriteLine("1. 전사 2. 마법사, 3. 궁수, 4. 도적 : ");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
            {

                case 1:
                    Console.WriteLine("=== 캐릭터 생성 ===");
                    Console.WriteLine("직업 : 마법사");
                    Console.WriteLine("특성 : 강력한 마법 공격");
                    Console.WriteLine("주 무기 : 지팡이, 마법서");
                    Console.WriteLine("스탯: 마나 + 100, 마법력 + 20");
                    break;
                case 2:
                    Console.WriteLine("=== 캐릭터 생성 ===");
                    Console.WriteLine("직업 : 마법사");
                    Console.WriteLine("특성 : 강력한 마법 공격");
                    Console.WriteLine("주 무기 : 지팡이, 마법서");
                    Console.WriteLine("스탯: 마나 + 100, 마법력 + 20");
                    break;
                case 3:
                    Console.WriteLine("=== 캐릭터 생성 ===");
                    Console.WriteLine("직업 : 마법사");
                    Console.WriteLine("특성 : 강력한 마법 공격");
                    Console.WriteLine("주 무기 : 지팡이, 마법서");
                    Console.WriteLine("스탯: 마나 + 100, 마법력 + 20");
                    break;
                case 4:
                        Console.WriteLine("=== 캐릭터 생성 ===");
                        Console.WriteLine("직업 : 마법사");
                        Console.WriteLine("특성 : 강력한 마법 공격");
                        Console.WriteLine("주 무기 : 지팡이, 마법서");
                        Console.WriteLine("스탯: 마나 + 100, 마법력 + 20");
                        break;
                    default:
                    Console.WriteLine("존재하지 않는 직업입니다.");
                    break;
                }
            }

        }
    }
}
