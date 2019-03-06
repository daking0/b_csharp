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
            string num0 = "";

            Console.WriteLine("숫자를 입력하세요.");
            num0 = Console.ReadLine();
            num1 = Int32.Parse(num0);

            Console.WriteLine("숫자를 입력하세요.");
            num0 = Console.ReadLine();
            num2 = Int32.Parse(num0);

            if (num1 >= num2)
            {
                if (num1 % num2 == 0)
                {
                    Console.WriteLine("최소공배수는 " + num1);
                }
                else
                {
                    Console.WriteLine("최소공배수는 " + (num1 * num2));
                }
            }
            else
            {
                if (num2 % num1 == 0)
                {
                    Console.WriteLine("최소공배수는 " + num2);
                }
                else
                {
                    Console.WriteLine("최소공배수는 " + (num1 * num2));
                }
            }


        }
    }
}
