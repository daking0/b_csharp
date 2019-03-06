using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 정수 n을 입력받고 n!을 구하세요.(factorial)
 5를 입력한경우 1*2*3*4*5를 구하세요.
*/
namespace _46_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, result =1;
            string num0 = "";

            Console.WriteLine("숫자를 입력하세요.");
            num0 = Console.ReadLine();
            num1 = Int32.Parse(num0);

            for(int i = 1; i <= num1; i++)
            {
                result = result * i;
            }

            Console.WriteLine(result);
        }
    }
}
