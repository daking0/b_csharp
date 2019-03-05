using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//사용자한테 점수를 입력받으세요.
//90점 이상이면 "A학점", 80점 이상 "B학점", 70점 이상 "C학점", 60점 이상 "D학점", 60점 미만이면 "F학점"

namespace _9_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Console.WriteLine("점수를 입력하세요.");
            string score1 = Console.ReadLine();
            score = Int32.Parse(score1);

            if(score >= 90)
            {
                Console.WriteLine("A학점");
            }else if(score >= 80)
            {
                Console.WriteLine("B학점");
            }else if(score >= 70)
            {
                Console.WriteLine("C학점");
            }else if(score >= 60)
            {
                Console.WriteLine("D학점");
            }
            else
            {
                Console.WriteLine("F학점");
            }
        }
    }
}
