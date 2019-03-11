using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*<식당 클래스>
 * 음식종류들
 * 주문요청
 * 음식선택
 * 음식전달
 */ 
namespace _62_Class
{
    class Restaurant
    {
        string[] foods = { "냉면", "칼국수", "쌀국수", "떡볶이", "순대", "튀김" };
        string selFood;

        //음식을 보여준다.
        public void QuestionOrder()
        {
            for(int i=0; i< foods.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i , foods[i]);
            }
        }

        //음식을 선택한다.
        public void SelectFood()
        {
            Console.WriteLine("음식을 선택하실래요?(번호만 입력)");
            int select = Int32.Parse(Console.ReadLine());
            selFood = foods[select];
        }

        //음식을 전달한다.
        public void DeliveryFood()
        {
            Console.WriteLine("{0}이 나왔습니다.", selFood);
            Console.WriteLine("맛있게 드세요 ^^");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant rest = new Restaurant();
            rest.QuestionOrder();
            rest.SelectFood();
            rest.DeliveryFood();
        }
    }
}


/*
주인은 주인의 일만, 손님은 손님의 일만 진행할 수 있도록 해야한다. 
*/