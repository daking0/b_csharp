using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*문제
 while문을 이용해서 1부터 10까지 합을 출력하세요.
 */
namespace _22_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int result = 0;
            while (num <= 10)
            {
                result += num;
                num++;

                /*
                int num=0;
                ++num;
                result += num; 
                */
            }
            Console.WriteLine("합은" + result);
        }
    }
}
