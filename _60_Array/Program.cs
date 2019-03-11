using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//10명의 성적을 입력받아라
//10명의 성적 출력
//총점 출력
//평점 출력
namespace _60_Array
{
    class Program
    {
        static void Main(string[] args)
        {   
            //한 번에 10개의 int를 선언
            int[] scores = new int[10];
            for(int i = 0; i < scores.Length; i++) //scores.Length =10
            {
                Console.WriteLine(i + 1 + "번째 입력");
                scores[i] = Int32.Parse(Console.ReadLine());
            }
            
            for(int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(i + 1 + " : " + scores[i]);
            }
            //Console.WriteLine(scores[0]);
        }
    }
}
