using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_if
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
        }
    }
}
