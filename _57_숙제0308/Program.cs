using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_숙제0308
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 0;
            int min = 0, sec = 0;

            Console.Write("초를 입력하세요.");
            int time = Int32.Parse(Console.ReadLine());

            hour = hourset(time);
            min = minset(time);
            sec = secset(time);

            Console.Write("[" + hour + "시간, " + min + "분 , " + sec + "초]");


            //string a = geth(time);   -전체 계산부터 문장까지 모두 완성 후 return을 string에 담아줌
            //Console.WriteLine(a);
        }

        ////시 계산
        public static int hourset(int time)
        {
            int hour = 0;
            hour = time / 3600;

            return hour;
        }

        ////분 계산
        public static int minset(int time)
        {
            int min = 0;
            min = time % 3600 / 60;

            //min = time / 60;
            //if (min >= 60)
            //{
            //    min = min - 60;
            //}

            return min;
        }

        ////초 계산
        public static int secset(int time)
        {
            int sec = 0;
            sec = time % 60;

            return sec;
        }


        //선생님 해설 -> 하나의 메서드 안에 계산 끝내고, string으로 문장까지 완성해서 return해주기
        //static string geth(int s)
        //{
        //    string time;
        //    int hour = (s / 60) / 60;
        //    int min = (s / 60) % 60;
        //    int sec = s % 60;
        //    time = "[" + hour + " ," + min + "," + sec + "]";
        //    return time;
        //}
    }
}

/*메서드를 만드는 목적
 1.복잡한 프로그램일수록 적절한 단위로 분산 
 -그룹핑, 관리용이,정리(가독성이 좋아짐)
 2.반복적인 코드를 줄일때
 -메서드 이름만으로 호출 가능
*/

