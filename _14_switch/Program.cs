using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*<문제>
 *"봄", "여름", "가을", "겨울"을 입력받아라
 * 봄->"꽃이 핀다"
 * 여름->"꽃이 자라난다" 
 * 가을 -> "꽃이 진다"
 * 겨울 -> "꽃이 숨어있다"
 */
namespace _14_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = "";

            Console.WriteLine("봄, 여름, 가을,겨울 입력");
            season = Console.ReadLine();

            switch(season)
            {
                case "봄":
                    Console.WriteLine("꽃이 핀다");
                    break;
                case "여름":
                    Console.WriteLine("꽃이 자라난다");
                    break;
                case "가을":
                    Console.WriteLine("꽃이 진다");
                    break;
                case "겨울":
                    Console.WriteLine("꽃이 숨어있다");
                    break;
                default:
                    Console.WriteLine("잘못 입력");
                    break;
            }
        }
    }
}
