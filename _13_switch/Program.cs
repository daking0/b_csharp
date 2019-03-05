using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int num0 = 0, num1 = 0; //입력변수
            int result = 0; //결과변수
            string str0p = ""; //입력연산자

            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            string strNum0 = Console.ReadLine();
            num0 = Int32.Parse(strNum0);

            Console.WriteLine("두 번째 숫자를 입력하세요.");
            string strNum1 = Console.ReadLine();
            num1 = Int32.Parse(strNum1);

            Console.WriteLine("연산자를 입력(+ - * /)");
            str0p = Console.ReadLine();
            /*
            if (str0p == "+")
                result = num0 + num1;
            else if (str0p == "-")
                result = num0 - num1;
            else if (str0p == "*")
                result = num0 * num1;
            else if (str0p == "/")
                result = num0 / num1;
            else
                Console.WriteLine("결과값은" + result);
            */

            //Switch-case문(만약 -라면)
            switch (str0p)
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

            Console.WriteLine("결과값은" + result);
        }
    }
}
