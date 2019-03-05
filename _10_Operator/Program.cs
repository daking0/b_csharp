using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.가로와 세로를 입력받아서 사각형의 넓이를 출력하세요.

namespace _10_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 0;  int height = 0; int result = 0;
            Console.WriteLine("가로를 입력하세요.");
            string w1 = Console.ReadLine();
            Console.WriteLine("세로를 입력하세요.");
            string h1 = Console.ReadLine();
            width = Int32.Parse(w1);
            height = Int32.Parse(h1);

            result = width * height;
            Console.WriteLine("사각형의 넓이는 " + result + " 입니다.");
            //Console.WriteLine("사각형의 넓이는 " + width * height + " 입니다.");

        }
    }
}
