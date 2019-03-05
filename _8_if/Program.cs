using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//사용자한테 점수를 입력받으세요. 80점 이상 "합격", 80점 미만이면 "불합격"
namespace _8_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Console.WriteLine("점수를 입력하세요.");
            string score1 = Console.ReadLine();
            score = Int32.Parse(score1);

            if (score >= 80)
            {
                Console.WriteLine("합격");
            }
            else
            {
                Console.WriteLine("불합격");
            }


        }
    }
}
