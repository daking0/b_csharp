using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//구구단 전체 출력
namespace _49_for
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 2; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    Console.WriteLine("{0}*{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
