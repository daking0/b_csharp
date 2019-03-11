using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_숙제0308
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("숫자 입력: ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.Write("숫자 입력: ");
            int num3 = Int32.Parse(Console.ReadLine());
            
            
            int large = 0, small = 0;
            large = largenum(num1, num2, num3);
            small = smallnum(num1, num2, num3);

            Console.Write("큰 수는 " +large);
            Console.Write("작은 수는 " +small);
        }
        public static int largenum(int num1, int num2, int num3)
        {
            int large = 0;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    large = num1;
                }
                else
                {
                    large = num2;
                }
            }
            else
            {
                if (num2 > num3)
                {
                    large = num2;
                }
                else
                {
                    large = num3;
                }
            }

            return large;

        }

        public static int smallnum(int num1, int num2, int num3)
        {
            int small = 0;

            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    small = num1;
                }
                else
                {
                    small = num2;
                }
            }
            else
            {
                if (num2 < num3)
                {
                    small = num2;
                }
                else
                {
                    small = num3;
                }
            }

            return small;

        }
    }
}
