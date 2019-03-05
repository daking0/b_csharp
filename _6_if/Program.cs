using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("숫자를 입력하세요.");
            string strNum = Console.ReadLine();
            num = Int32.Parse(strNum);

            if (num == 100)
            {
                Console.WriteLine("num은 100입니다.");
            }
            else if (num < 100)
                Console.WriteLine("num은 100보다 작습니다.");
            else if (num > 100)
                Console.WriteLine("num은 100보다 큽니다.");

            /*
             else 
                Console.WriteLine("num은 100보다 큽니다.");

            로 쓰기도 가능.
            위에 두 조건이 아닌 다른 조건들일 경우로 묶어서 진행
             */
        }
    }
}
