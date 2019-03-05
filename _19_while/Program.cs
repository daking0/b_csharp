using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*문제 : while문을 이용해서 1부터 100까지 출력*/
namespace _19_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num < 100)
            {
                ++num;
                Console.WriteLine(num);
            }
        }
    }
}
