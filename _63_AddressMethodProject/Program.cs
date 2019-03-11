using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* <주소록 프로젝트>
: 이름, 전화, 주소를 입력/검색/변경/삭제/전체출력

*기능 정의
0.메뉴 반복
void MainLoop();
1.메뉴 출력
void PrintMenu();
2.메뉴 선택
int GetSelectMenu();
3.주소 정보 입력(이름, 전화, 주소)
void InputAddress();
4.주소 정보 검색(이름으로 검색)
void SearchAddress();
5.주소 정보 변경(이름으로 검색 후 변경)
void UpdateAddress();
6.주소 정보 삭제(이름으로 검색 후 삭제)
void DeleteAddress();
7.주소 정보 전체 출력
void PrintAllAdress();
8.프로그램 종료
void ProgramExit();
9.화면 지우기
void ClearView();
*/
namespace _63_AddressMethodProject
{
    class Address
    {
        public string name;
        public string phone;
        public string address;
    }
    class Program
    {
        //최초에 10개 공간 할당 - 이후에는 알아서 증가
        static List<Address> arrayAddress = new List<Address>(10);
        
        static void MainLoop()
        {
            while (true)
            {
                ClearView(); //화면을 지워준다
                PrintMenu();
                int sel = GetSelectMenu();

                switch (sel)
                {
                    case 0:
                        InputAddress();
                        break;
                    case 1:
                        SearchAddress();
                        break;
                    case 2:
                        UpdateAddress();
                        break;
                    case 3:
                        DeleteAddress();
                        break;
                    case 4:
                        PrintAllAdress();
                        break;
                    case 5:
                        ProgramExit();
                        break;
                    default:
                        Console.WriteLine("잘못 입력");
                        break;
                }
            }
        }
        static void PrintMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("0. 주소 입력");
            Console.WriteLine("1. 주소 검색");
            Console.WriteLine("2. 주소 수정");
            Console.WriteLine("3. 주소 삭제");
            Console.WriteLine("4. 주소 전체 출력");
            Console.WriteLine("5.프로그램 종료");
            Console.WriteLine("--------------------");
        }
        static int GetSelectMenu()
        {
            int sel = -1;
            Console.Write("메뉴 선택 >>> ");
            sel = Int32.Parse(Console.ReadLine());
            return sel;
        }
        static void InputAddress()
        {
            ClearView();
            Console.Write("이름 입력: ");
            string name = Console.ReadLine();
            Console.Write("전화 입력: ");
            string phone = Console.ReadLine();
            Console.Write("주소 입력: ");
            string address = Console.ReadLine();
            Address addr = new Address();
            addr.name = name;
            addr.phone = phone;
            addr.address = address;
            arrayAddress.Add(addr); //저장소에 저장
        }
        static void SearchAddress()
        {
            ClearView();
            Console.Write("이름 입력: ");
            string name = Console.ReadLine();
            for(int i =0; i<arrayAddress.Count; i++)
            {
                //이름을 찾았다!
                if(name == arrayAddress[i].name)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("이름 : " + arrayAddress[i].name);
                    Console.WriteLine("이름 : " + arrayAddress[i].phone);
                    Console.WriteLine("이름 : " + arrayAddress[i].address);
                    Console.WriteLine("-------------------------------");
                    break;
                }
            }
            Console.ReadKey();
        }
        static void UpdateAddress()
        {
            ClearView();
            Console.Write("이름 입력: ");
            string name = Console.ReadLine();
            for (int i = 0; i < arrayAddress.Count; i++)
            {
                //이름을 찾았다!
                if (name == arrayAddress[i].name)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("이름 : " + arrayAddress[i].name);
                    Console.WriteLine("이름 : " + arrayAddress[i].phone);
                    Console.WriteLine("이름 : " + arrayAddress[i].address);
                    Console.WriteLine("-------------------------------");
                    Console.Write("이름 입력: ");
                    string uName = Console.ReadLine();
                    Console.Write("전화 입력: ");
                    string phone = Console.ReadLine();
                    Console.Write("주소 입력: ");
                    string address = Console.ReadLine();
                    arrayAddress[i].name = uName;
                    arrayAddress[i].phone = phone;
                    arrayAddress[i].address = address;
                    break;
                }
            }
            Console.ReadKey();
        }
        static void DeleteAddress()
        {
            ClearView();
            Console.Write("이름 입력: ");
            string name = Console.ReadLine();
            for (int i = 0; i < arrayAddress.Count; i++)
            {
                //이름을 찾았다!
                if (name == arrayAddress[i].name)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("이름 : " + arrayAddress[i].name);
                    Console.WriteLine("이름 : " + arrayAddress[i].phone);
                    Console.WriteLine("이름 : " + arrayAddress[i].address);
                    Console.WriteLine("-------------------------------");
                    Console.Write("진짜 지울래요?(y or n)");
                    string yesOrNo = Console.ReadLine();
                    if (yesOrNo == "y")
                        arrayAddress.RemoveAt(i);
                    break;
                }
            }
            Console.ReadKey();
        }
        static void PrintAllAdress()
        {
            ClearView();
            for(int i=0; i < arrayAddress.Count; i++)
            {
                Console.WriteLine("---------------{0}---------------", i);
                Console.WriteLine("이름 : " + arrayAddress[i].name);
                Console.WriteLine("이름 : " + arrayAddress[i].phone);
                Console.WriteLine("이름 : " + arrayAddress[i].address);
                Console.WriteLine("-------------------------------");
            }
            Console.ReadKey(); //입력받기 전까지 멈춰 있음
        }
        static void ProgramExit()
        {
            Environment.Exit(0); //프로그램 종료
        }
        static void ClearView()
        {
            Console.Clear(); //화면이 깨끗하게 claer된다
        }

        static void Main(string[] args)
        {
            MainLoop();
        }
    }
}
