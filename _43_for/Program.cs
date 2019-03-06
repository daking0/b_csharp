using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 0부터 1씩 증가한 값을 누적하여 더합니다.
 모두 더한값이 1000이 넘을 때 의 총합과 
 더한 값을 구하세요.
 */
namespace _43_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int result = 0;

            for (int i = 0; i >= 0; i++)
            {
                result += i;
                if (result >= 1000)
                    break;
            }

            //while (true)
            //{
            //    num1++;
            //    result = num1 + result;
            //    if (result >= 1000)
            //        break;
            //}
            Console.WriteLine("1000이 넘을 때의 값은 " + result);
        }
    }
}
