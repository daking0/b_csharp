using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*문제
while문을 이용해서 1부터 100까지 중에 짝수만 출력하세요.
짝수 구하는 조건-> if(num%2 ==0)
*/
namespace _23_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num < 100)
            {
                if (num % 2 == 0)
                    Console.WriteLine(num);
                num++;
            }

        }
    }
}
