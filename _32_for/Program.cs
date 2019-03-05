using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*for문으로
 *숫자를 입력받고 해당 숫자의 구구단 부분을 출력하세요
 * 3이면 3단출력
 */
namespace _
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("숫자를 입력하세요.");
            string num0 = Console.ReadLine();
            num = Int32.Parse(num0);

            for(int i =1; i<10; i++)
            {
                //Console.WriteLine(num + " * " + i + " = " + num * i);
                Console.WriteLine("{0} X {1} = {2}", num, i, num * i);
            }
        }
    }
}
