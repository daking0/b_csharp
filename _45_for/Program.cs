using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
입력받은 숫자의 구구단을 출력하는데 역순으로 출력
  예) 3*9=27
      3*8=24... 
*/
namespace _45_for
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

            for (int k = 9; k >0; k--)
            {
                Console.WriteLine("{0} X {1} = {2}", num1, k, num1 * k);
            }
        }
    }
}
