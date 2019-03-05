using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*문제
while을 사용해 10부터 20까지 출력
*/
namespace _20_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 9;
            while (num < 20)
            {
                num++;
                Console.WriteLine(num);
            }

            /*
            int num = 10;
            while (num < 21)
            {
                Console.WriteLine("{0}",num++); //num이 {0}에 찍힌 후 1증가
            }
            */


            //10~20까지 2씩 증가
            int num1 = 10;
            while (num1 < 21)
            {
                Console.WriteLine("{0}",num1); 
                num1 = num1 + 2;
            }

        }
    }
}
