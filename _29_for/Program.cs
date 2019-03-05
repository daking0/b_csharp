using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0; //시작 조건

            //while (num < 10) //종료 조건
            //{
            //    //실행문
            //    Console.WriteLine("나무를 {0}번 찍었습니다.", ++num);
            //}

            for(; num<10; )
            {
                //실행문
                Console.WriteLine("나무를 {0}번 찍었습니다.", ++num);
            }

        }
    }
}
