using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//문제1 0부터 더한 합이 1000 넘으면 스탑
//문제2 최소공배수 구하기
//문제3 
namespace _53_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //문제1
            int sum = 0;
            for (int i = 0; ; i++)
            {
                sum += i;
                if (sum > 1000)
                    break;
            }
            Console.WriteLine(sum);

            //문제2
            int num0 = 0, num1 = 0;

            Console.WriteLine("첫 번째 숫자 입력");
            num0 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("두 번째 숫자 입력");
            num1 = Int32.Parse(Console.ReadLine());
            
            for(int i=1; ; i++)
            {
                if (i % num0 == 0 && i%num1==0) 
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            //&& 그리고 and
            //A &&B =>A도 참, B도 참
            //|| 또는 or
            //A || B =>A나 B 둘중에 하나 참
        }
    }
}
