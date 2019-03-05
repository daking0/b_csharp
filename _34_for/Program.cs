using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string num0 = "";

            while (num != -1)
            {
                Console.WriteLine("숫자를 입력하세요.");
                num0 = Console.ReadLine();
                num = Int32.Parse(num0);

                if(num != -1) //-1이 아닐때만 실행
                {
                    for (int i = 1; i < 10; i++)
                    {
                        Console.WriteLine("{0} X {1} = {2}", num, i, num * i);
                    }
                }
            }
        }
    }
}
