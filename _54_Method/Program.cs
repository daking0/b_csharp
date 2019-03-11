using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2개의 숫자와 연산자 입력 후 사칙연산, 출력하기
namespace _54_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int num0 = 0, num1 = 0;
            int result = 0;
            string op = "";

            Console.Write("첫 번째 숫자 입력: ");
            num0 = Int32.Parse(Console.ReadLine());

            Console.Write("두 번째 숫자 입력: ");
            num1 = Int32.Parse(Console.ReadLine());

            Console.Write("연산자 숫자 입력: ");
            op = Console.ReadLine();
            
            switch(op)
            {
                case "+":
                    result = num0 + num1;
                    break;

                case "-":
                    result = num0 - num1;
                    break;

                case "*":
                    result = num0 * num1;
                    break;

                case "/":
                    result = num0 / num1;
                    break;

                default:
                    Console.WriteLine("잘못 입력");
                    break;
            }

            Console.WriteLine("결과값은 " + result + " 입니다.");
        }
    }
}
