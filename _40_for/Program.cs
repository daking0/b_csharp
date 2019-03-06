using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
문제1
 양의 정수를 입력받고 그 수만큼 "감사합니다"를 출력하세요

문제2
양의 정수 입력받고 그 수만큼 3의 배수 출력하세요
예를 들어 5를 입력받으면 3 6 9 12 15를 출력하면 됩니다

문제3
입력받은 숫자의 구구단을 출력하세요
   예를 들어 3을 입력하면 
   3 x 1 = 3
   3 x 2 = 6
   ...
   3 x 9 = 27
*/
namespace _40_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string num0 = "";

            Console.WriteLine("숫자를 입력하세요.");
            num0 = Console.ReadLine();
            num = Int32.Parse(num0);

            //문제1
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("감사합니다.");
            }

            //문제2
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i * 3);
            }

            //문제3
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", num, i, num * i);
            }

            //문제4
        }
    }
}
