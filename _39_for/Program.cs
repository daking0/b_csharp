using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 for문을 이용해서 1부터 10까지 중에 짝수만 출력하세요
 for문내에 조건문을 넣어주면 됨
 짝수 조건 if(num % 2 == 0)
 */
namespace _39_for
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<11;i++)
            {
                if(i %2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
