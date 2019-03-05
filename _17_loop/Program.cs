using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("나무를 {0}번 찍었습니다.", ++num); //++num은 즉시 1을 증가, num++ 일단 사용하고 나서 1을 증가
            Console.WriteLine("나무를 {0}번 찍었습니다.", ++num);
            Console.WriteLine("나무를 {0}번 찍었습니다.", ++num);
            Console.WriteLine("나무를 {0}번 찍었습니다.", ++num);
            Console.WriteLine("나무를 {0}번 찍었습니다.", ++num);
            Console.WriteLine("나무를 {0}번 찍었습니다.", ++num);
            Console.WriteLine("나무를 {0}번 찍었습니다.", ++num);
            Console.WriteLine("나무를 {0}번 찍었습니다.", ++num);
            Console.WriteLine("나무를 {0}번 찍었습니다.", ++num);
            Console.WriteLine("나무를 {0}번 찍었습니다.", ++num);
        }
    }
}
