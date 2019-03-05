using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Console.WriteLine("점수를 입력하세요.");
            string score1 = Console.ReadLine();
            score = Int32.Parse(score1);

            if(score >= 80)
            {
                Console.WriteLine("합격");
            }
        }
    }
}
