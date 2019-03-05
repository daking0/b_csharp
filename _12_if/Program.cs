using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1)두 개의 숫자를 입력받아라.
 2)사칙 연산자를 입력받아라.
 3)사칙 연산자의 종류에 따라 연산을 한다.
 4)연산의 결과를 출력한다.
 */

 /*
 위에 과정을 고려한 후에는 변수 선언 진행
 1)프로그램 전체에 사용되는 변수는 시작 부분에 선언 (반복적으로 사용되는 변수)
 2)특정 위치에서만 사용되는 변수는 그 부분에 선언
 */

namespace _12_if
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

            Console.WriteLine("결과값은" + result);
        }
    }
}
