using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
사용자로부터 정수를 입력받습니다.
입력 받은 값을 계속 더합니다
사용자가 0을 입력하면 합을 출력합니다
프로그램을 종료합니다.
 */
namespace _41_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int result = 0;
            string num0 = "";

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("숫자를 입력하세요.");
                num0 = Console.ReadLine();
                num = Int32.Parse(num0);
                result += num;

                if (num == 0)
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
