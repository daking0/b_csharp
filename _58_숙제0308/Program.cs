using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*문제1
 *****
  ****
   ***
    **
     *
     
2. 두 개의 정수를 입력받습니다.
   두 정수를 포함한 사이의 정수의 합을 출력하세요
   예를 들면 3과 5를 입력하면 3+4+5의 합을 출력하면 됩니다.

3. 구구단을 출력하세요
2x1=2 3x1=3 4x1=4 ... 9x1=9
2x2=4 3x2=6 4x2=8 ... 9x2=18
...
2x9=18 3x9=27 4x9=36... 9x9=81

4. 5를 입력하면 아래처럼 그림을 출력하세요

*
o*
oo*
ooo*
oooo*

*/
namespace _58_숙제0308
{
    class Program
    {
        static void Main(string[] args)
        {
            //문제1
            //string str = "";
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(str);
            //    str += " ";
            //    for (int j = 5 - i; j > 0; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}

            //문제2
            int num1 = 0, num2 = 0;
            int sum = 0;

            Console.Write("첫번째 입력: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("두번째 입력: ");
            num2 = Int32.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                for (int i = num2; i <= num1; i++)
                {
                    sum += i;
                }
            }
            else
            {
                for (int i = num1; i <= num2; i++)
                {
                    sum += i;
                }
            }

            Console.Write("결과는 " + sum);
            Console.Write("\n");
            //start,end 를 정해줘서 
            //for (; start <= end ; start++){
            //sum += if;
            //}



            //문제3
            for (int i = 1; i < 10; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    Console.Write(j + "*" + i + "=" + j * i + "\t");
                }
                Console.Write("\n");
            }


            //문제4 

            Console.Write("입력: ");
            int num = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++) //세로 - 각 라인의 반복
            {
                for (int j = 0; j < i; j++) 
                {
                    Console.Write("0");
                }
                Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}

