using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 2. 양의 정수 입력받고 그 수만큼 3의 배수 출력하세요
   예를 들어 5를 입력받으면 3 6 9 12 15를 출력하면 됩니다
 */
namespace _25_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int i = 1;
            string num0 = "";
            Console.WriteLine("양의 정수를 입력하세요.");
            num0 = Console.ReadLine();
            num = Int32.Parse(num0);

            if(num < 0)
            {
                Console.WriteLine("양의 정수를 입력하세요.");
                num0 = Console.ReadLine();
                num = Int32.Parse(num0);
            }

            while (num >=i)
            {
                int result = i * 3;
                i++;
                Console.WriteLine(result);
            }


        }
    }
}
