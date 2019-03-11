using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_method
{
    class Program
    {
        //입력메서드
        static int InputNum(string order)
        {
            int num = 0;
            Console.Write(order + "번째 숫자 입력: ");
            num = Int32.Parse(Console.ReadLine());
            return num;
        }

        static string InputOp()
        {
            string op;
            Console.Write("연산자 숫자 입력: ");
            op = Console.ReadLine();
            return op;
        }
        //계산 메서드
        static int CalcArith(string op, int num0, int num1)
        {
            int result = 0;
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
            //이 method를 호출한 곳으로 이 값을 가지고 반환
            return result; //이 값은 반드시 method에서 정의한 형태로 반환(여기서는 int니까 int로 반환)
        }
        //입력과 계산
        //static int InputCalcArith() //int로 return값 받기
        //{
        //    int num0 = 0, num1 = 1;
        //    int result = 0;
        //    string op = "";

        //    num0 = InputNum("첫");
        //    num1 = InputNum("두");
        //    op = InputOp();

        //    result = CalcArith(op, num0, num1);

        //    return result;
        //}

        //결과값 출력 method
        static void PRintResult(int re) //return값이 없을땐 void라고 쓴다.
                                        //(int re)는 매개변수. 매개변수를 받아서 다음 method를 진행
        {
            Console.WriteLine("결과값은 " + re + " 입니다.");
        }

        //프로그램의 시작
        //필수 method로 무조건 여기서 시작한다.
        static void Main(string[] args)
        {
            //변수 영역
            int num0 = 0, num1 = 1;
            int result = 0;
            string op = "";

            //메서드 영역
            num0 = InputNum("첫");
            num1 = InputNum("두");
            op = InputOp();
            result = CalcArith(op, num0, num1);
            PRintResult(result);

            //int r = InputCalcArith();
            /*
            a = Input();
            CalcArith(a);
            이렇게 여러가지 하기 위해서는 class 개념이 필요하다.
             */
            //오른쪽 실행 후 그 값을 왼쪽 변수에 저장하는데, 여기선 오른쪽 처리 식이 method니까 
            //그 이름을 가진 method로 간다.
            //PRintResult(result);  //위에 변수 r값을 PrintResult의 매개변수로 가져가서 실행
            
        }
    }
}
