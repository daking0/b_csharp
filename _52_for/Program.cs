using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string strNum = "";
            Console.WriteLine("구구단 중에 1은 홀수단, 2는 짝수단");
            strNum = Console.ReadLine();
            num = Int32.Parse(strNum);

            int firstNum = 0;
            if (num == 1)
                firstNum = 3;
            else if (num == 2)
                firstNum = 2;

            for(int i = 2; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    Console.WriteLine("{0}X{1}={2}", i, j, i * j);
                }
            }
        }
    }
}
