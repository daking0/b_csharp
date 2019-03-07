using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = '#';
            int x = 0;
            int dir = 1;
            //Console.SetCursorPosition(0, 12);

            /*for (int i = 0; i < 40; i++)
            {
                Console.Write(ch);
                System.Threading.Thread.Sleep(100); //0.1초 정지
                Console.SetCursorPosition(x, 12);
                x++;
                Console.Write(' ');
            }*/
           

            while (true)
            {

                Console.SetCursorPosition(x, 12);
                Console.Write(ch);
                System.Threading.Thread.Sleep(100); //0.1초 정지
                Console.SetCursorPosition(x, 12);
                Console.Write(' ');
                x = x + dir;

                if (x == 20)
                {
                    dir = dir * (-1);
                }
                if (x == 0)
                {
                    dir = dir * (-1);
                }
            }
         
        }
    }
}
        

