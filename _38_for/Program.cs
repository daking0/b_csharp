using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//문제 - for문을 이용해서 1부터 10까지 합을 출력하세요
namespace _38_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            for(int i = 1; i<11;i++)
            {
                result += i;
            }
            Console.WriteLine(result);
        }
    }
}
