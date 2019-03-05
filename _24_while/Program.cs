using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1. 양의 정수를 입력받고 그 수만큼 "감사합니다"를 출력하세요
 */
namespace _24_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string num0 = "";
            Console.WriteLine("양의 정수를 입력하세요.");
            num0 = Console.ReadLine();
            num = Int32.Parse(num0);

            if (num < 0)
            {
                Console.WriteLine("양의 정수를 입력하세요.");
                num0 = Console.ReadLine();
                num = Int32.Parse(num0);
            }

            while (num > 0)
            {
                Console.WriteLine("감사합니다.");
                num--;
            }
        }
    }
}
