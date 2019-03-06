using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 1.구구단을 출력하되 1을 입력하면 홀수단만
   2를 입력하면 짝수단만 출력하라

 */
namespace _42_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string num0 = "";

            Console.WriteLine("1 혹은 2를 입력하세요.");
            num0 = Console.ReadLine();
            num = Int32.Parse(num0);
            
            if(num == 1)
            {
                for (int i = 1; i < 10; i=i + 2)
                {
                    for(int k = 1; k < 10; k++)
                    {
                        Console.WriteLine("{0} X {1} = {2}", i, k, i * k);
                    }
                }
            }else if(num == 2)
            {
                for (int i = 2; i <= 10; i = i + 2)
                {
                    for (int k = 1; k < 10; k++)
                    {
                        Console.WriteLine("{0} X {1} = {2}", i, k, i * k);
                    }
                }
            }

        }
    }
}
