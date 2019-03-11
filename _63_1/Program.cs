using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* <주소록 프로젝트>
 1.시작 클래스
 2.주소 클래스(Model =>Data를 의미)
 3.메뉴 클래스(View =>화면을 의미)
 4.주소록 관리 클래스(Controller =>비즈니스 로직을 의미,좀 더 추상적)
 */ 

namespace _64_AddressClassProject
{
    //주소 클래스
    class Address
    {
        public string name;
        public string phone;
        public string address;
    }

    //메뉴 클래스
    class Menu
    {
        AddressManager addrManager = new AddressManager();

        public void MainLoop()
        {
            while (true)
            {
                ClearView();
                PrintMenu(); //메뉴 보여주기
                int sel = GetSelectMenu(); //메뉴 선택
                switch (sel)
                {
                    case 0:
                        addrManager.InputAddress();
                        break;
                }
            }
        }
        void PrintMenu()
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

        int GetSelectMenu() 
        {
            int sel = -1;
            Console.Write("메뉴 선택 >>> ");
            sel = Int32.Parse(Console.ReadLine());
            return sel;
        }

        void ProgramExit()
        {
            Environment.Exit(0);
        }

        public  void ClearView()
        {
            Console.Clear();
        }

    }

    //주소록 관리 클래스
    class AddressManager
    {
        List<Address> arrayAddress = new List<Address>();
        
        public void InputAddress()
        {
            Menu menu = new Menu();
            menu.ClearView();
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

        public void SearchAddress()
        {
            Menu menu = new Menu();
            menu.ClearView();
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
                    break;
                }
            }
            Console.ReadKey();
        }

        public void UpdateAddress()
        {
            Menu menu = new Menu();
            menu.ClearView();
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
        
        public void DeleteAddress()
        {
            Menu menu = new Menu();
            menu.ClearView();
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

        public void PrintAllAddress()
        {
            Menu menu = new Menu();
            menu.ClearView();
            for (int i = 0; i < arrayAddress.Count; i++)
            {
                Console.WriteLine("---------------{0}---------------", i);
                Console.WriteLine("이름 : " + arrayAddress[i].name);
                Console.WriteLine("이름 : " + arrayAddress[i].phone);
                Console.WriteLine("이름 : " + arrayAddress[i].address);
                Console.WriteLine("-------------------------------");
            }
            Console.ReadKey(); //입력받기 전까지 멈춰 있음
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.MainLoop();
        }
    }
}
