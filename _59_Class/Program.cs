using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
-메서드(행위)
1.2개의 숫자와 연산자 입력
2.사칙연산
3.출력하기
메서드 일 때는 이렇게 3개의 메서드로 분리

-클래스 ->좀 더 큰 단위로 묶고자 탄생
사칙연산 담당 클래스
필드(변수) +메서드 ->두 가지가 공존

-클래스의 생성 목적
1.시대가 복잡해지므로 큰 단위가 요구됨(정리 용이)
2.프로그램에서는 반드시 변수와 함수가 결합됨
-어차피 둘다 필요한 것이니까 관련있는 것들끼리 하나로 묶자
3.문장 1형식 = 주어+동사 
  프로그램 = 변수 + 메서드
  어느 정도 독립성(캡슐화)
 */
namespace _59_Class
{
    class CalcManager
    {
        //변수 영역
        int num0 = 0, num1 = 1;
        int result = 0;
        string op = "";


        //메서드 영역
        public void InputTwoValueOp()  //외부에서 접근되려면 public
        {
            num0 = InputNum("첫");
            num1 = InputNum("두");
            InputOp();
        }
        //입력
        int InputNum(string order)
        {
            int num = 0;
            Console.Write(order + "번째 숫자 입력: ");
            num = Int32.Parse(Console.ReadLine());
            return num;
        }
        void InputOp()
        {
            Console.Write("연산자 숫자 입력: ");
            op = Console.ReadLine();
        }
        //계산 
        public void CalcArith()
        {
            switch (op)
            {
                case "+":
                    result = num0 + num1;
                    break;

                case "-":
                    result = num0 - num1;
                    break;

                case "*":
                    result = num0 * num1;
                    break;

                case "/":
                    result = num0 / num1;
                    break;

                default:
                    Console.WriteLine("잘못 입력");
                    break;
            }
        }
        //출력
        public void PRintResult() 
        {
            Console.WriteLine("결과값은 " + result + " 입니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //클래스 객체(변수)=instant
            //푸들   모모  ->실체를 사용하기 위해 모모라는 객체 만듦
            //자료형 변수
            //int    num =0; ->int를 사용하기 위해 num이라는 변수를 만들어서 사용
            CalcManager calcMgr = new CalcManager();
            calcMgr.InputTwoValueOp();
            calcMgr.CalcArith();
            calcMgr.PRintResult();
        }
    }
}
