using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*<문제> switch case로 만들기
 * 사용자한테 점수를 입력받으세요.
    90점 이상이면 "A학점", 80점 이상 "B학점", 70점 이상 "C학점", 60점 이상 "D학점", 60점 미만이면 "F학점"
*/
namespace _15_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Console.WriteLine("점수를 입력하세요.");
            string score1 = Console.ReadLine();
            score = Int32.Parse(score1);
            string result0 = "";

            switch(score /10)
            {
                case 10:
                case 9:
                    Console.WriteLine("A학점");
                    break;
                case 8:
                    Console.WriteLine("B학점");
                    break;
                case 7:
                    Console.WriteLine("C학점");
                    break;
                case 6:
                    Console.WriteLine("D학점");
                    break;
                default:
                    Console.WriteLine("F학점");
                    break;
            }
            /*
            if (score >= 90)
                result0 = "A";
            else if (score >= 80)
                result0 = "B";
            else if (score >= 70)
                result0 = "C";
            else if (score >= 60)
                result0 = "D";
            else
                result0 = "F";


            switch (result0)
            {
                case ("A"):
                    Console.WriteLine("A학점");
                    break;
                case ("B"):
                    Console.WriteLine("B학점");
                    break;
                case ("C"):
                    Console.WriteLine("C학점");
                    break;
                case ("D"):
                    Console.WriteLine("D학점");
                    break;
                case ("F"):
                    Console.WriteLine("F학점");
                    break;
            }
            */

                
        }
    }
}
