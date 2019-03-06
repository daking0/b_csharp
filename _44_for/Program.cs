using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//두 수를 입력받고 최소공배수를 구하세요.
namespace _44_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            int gcd = 0, lcm = 0; //gcd는 최대공약수 lcm은 최소공배수
            string num0 = "";

            Console.WriteLine("숫자를 입력하세요.");
            num0 = Console.ReadLine();
            num1 = Int32.Parse(num0);

            Console.WriteLine("숫자를 입력하세요.");
            num0 = Console.ReadLine();
            num2 = Int32.Parse(num0);

            for (int i = 0; i <= num1 * num2; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    gcd = i;
                }
            }

            Console.WriteLine("최대공약수: " + gcd);
            Console.WriteLine("최소공배수: " + lcm);

        }
    }
}
