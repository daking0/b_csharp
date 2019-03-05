using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* While문 :()안의 내용이 참인 조건일 때 계속 실행문을 반복
 * while(참)
   {
       실행문
    } 
*/
namespace _18_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0; //시작 조건
            while (num < 1000) //종료 조건
            {
                //실행문
                Console.WriteLine("나무를 {0}번 찍었습니다.", ++num);
            }
            /*
             while (num < 10)
                Console.WriteLine("나무를 {0}번 찍었습니다.", ++num);
             */
        }
    }
}
