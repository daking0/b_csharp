using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//홀수만 또는 짝수만 출력
namespace _51_for
{
    class Program
    {
        //1.조건문을 사용해서 필터링
        //static void Main(string[] args)
        //{
        //    for (int i = 2; i <= 9; i++)
        //    {
        //        for (int j = 1; j <= 9; j++)
        //        {
        //            if(j%2==0)
        //              Console.WriteLine("{0}*{1}={2}", i, j, i * j);
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //2.초기값과 증가값을 이용해서 출력
        //static void Main(string[] args)
        //{
        //    for (int i = 2; i <= 9; i++)
        //    {
        //        for (int j = 2; j <= 9; j+=2)
        //        {
        //            Console.WriteLine("{0}*{1}={2}", i, j, i * j);
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //3.continue문을 이용해서 필터
        //programming 에서의 continue의 의미는
        //위로 돌아가서 계속 진행해라
        static void Main(string[] args)
        {
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (j % 2 == 1)//홀수일 때
                        continue; //홀수면 밑으로 내려가지 않고 바로 맨위 j++로 다시 시작

                    Console.WriteLine("{0}*{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
