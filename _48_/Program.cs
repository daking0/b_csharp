using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = '#';
            char ch1 = ' ';
            int x = 0, y = 12;
            int tmpx = 1; //x축 방향 조절하는 변수
            int tmpy = -1; //y축 방향 조절하는 변수
            Console.SetCursorPosition(0, 12);

            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(ch);
                System.Threading.Thread.Sleep(100); //0.1초 정지
                Console.SetCursorPosition(x, y);
                Console.Write(ch1);
                x = x + (1 * tmpx); //x방향 조절하기 위한 식
                y = y + (1 * tmpy);//y방향 조절하기 위한 식


                if (y == 0) //맨 위 꼭대기에 만났을 때
                {
                    tmpy = tmpy * -1; 
                }
                else if (y == 12) //처음 시작했던 y의 위치가 되었을 때
                {
                    tmpx = tmpx * -1;
                }
                else if (y == 24) //맨 밑에 꼭지점
                {
                    tmpy = tmpy * -1;
                }

            }
        }
    }
}

