using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 3. 입력받은 숫자의 구구단을 출력하세요
   예를 들어 3을 입력하면 
   3 x 1 = 3
   3 x 2 = 6
   ...
   3 x 9 = 27
 */
namespace _26_while
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

            while (i <10)
            {
                int result = num * i;
                Console.WriteLine(num + "x" + i + "=" +result);
                i++;
            }
        }
    }
}
