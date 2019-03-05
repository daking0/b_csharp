using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string num0 = "";

            while (true)
            {
                Console.WriteLine("숫자를 입력하세요.");
                num0 = Console.ReadLine();
                num = Int32.Parse(num0);

                //break는 현재를 감싸는 반복문을 즉각 빠져 나간다.
                if (num == -1)
                    break; 

                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", num, i, num * i);
                }
            }
        }
    }
}
