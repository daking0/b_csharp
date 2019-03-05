using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
반목문의 종류
while문
do~while문
for문

위 3가지 반복문은 100%호환이 가능하다.
*/
namespace _28_do_while
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

            do //조건과 상관없이 무조건 한 번은 실행
            {
                //실행문
                Console.WriteLine("나무를 {0}번 찍었습니다.", ++num);
            } while (num < 10); //한 번 실행 후 그 다음부터 조건 검사

        }
    }
}
