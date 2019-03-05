using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
for문의 구조
for(시작조건;종료조건;증감식)
{
    실행문
}
*/
namespace _30_for
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num =1; num <= 10;++num)
            {
                //실행문
                Console.WriteLine("나무를 {0}번 찍었습니다.", num);
            }
        }
    }
}
