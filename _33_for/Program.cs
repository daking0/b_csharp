using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_for
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

                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", num, i, num * i);
                }
            }
        }
    }
}
