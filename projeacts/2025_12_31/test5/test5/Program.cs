using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "홍길동";
            
            Console.WriteLine("             ┌────────────────────┐            ");
            Console.WriteLine("┌────────────│    자유시간 게임   │────────────┐");
            Console.WriteLine("│            └────────────────────┘            │");
            Console.WriteLine("│                                              │");
            Console.WriteLine("│            ┌────────────────────┐            │");
            Console.WriteLine($"│            │   닉네임 : {name}  │            │");
            Console.WriteLine("│            └────────────────────┘            │");
            Console.WriteLine("│            ┌────────────────────┐            │");
            Console.WriteLine("│            │       처음부터     │            │");
            Console.WriteLine("│            └────────────────────┘            │");
            Console.WriteLine("│            ┌────────────────────┐            │");
            Console.WriteLine("│            │      이어서하기    │            │");
            Console.WriteLine("│            └────────────────────┘            │");
            Console.WriteLine("│            ┌────────────────────┐            │");
            Console.WriteLine("│            │        옵 션       │            │");
            Console.WriteLine("│            └────────────────────┘            │");
            Console.WriteLine("│            ┌────────────────────┐            │");
            Console.WriteLine("│            │     조작 방법 :    │            │");
            Console.WriteLine("│            │ 방향키(←,↑,→,↓)│            │");
            Console.WriteLine("│            └────────────────────┘            │");
            Console.WriteLine("│                                              │");
            Console.WriteLine("│            ┌────────────────────┐            │");
            Console.WriteLine("│            │      게임 시작     │            │");
            Console.WriteLine("│            └────────────────────┘            │");
            Console.WriteLine("│            ┌────────────────────┐            │");
            Console.WriteLine("└────────────│      게임 종료     │────────────┘");
            Console.WriteLine("             └────────────────────┘");
        }
    }
}
