using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5.가로와 세로를 입력받아서 다시 "사각형"인지 "삼각형"인지 입력받아라.
//사각형이면 사각형의 넓이를, 삼각형이면 삼각형의 넓이를 출력하세요.

namespace _11_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 0; int height = 0; int result = 0;
            string result1=""; //string은 ""로 초기화한다.

            Console.WriteLine("가로를 입력하세요.");
            string w1 = Console.ReadLine();
            Console.WriteLine("세로를 입력하세요.");
            string h1 = Console.ReadLine();
            Console.WriteLine("사각형인지 삼각형인지 입력하세요.");
            result1 = Console.ReadLine();

            width = Int32.Parse(w1);
            height = Int32.Parse(h1);

            if(result1 == "삼각형")
            {
                result = (width * height)/2;
                Console.WriteLine("삼각형의 넓이는 " + result + " 입니다.");
            }
            else if(result1 == "사각형")
            {
                result = width * height;
                Console.WriteLine("사각형의 넓이는 " + result + " 입니다.");
            }
        }
    }
}
