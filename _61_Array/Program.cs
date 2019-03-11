using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "홍길동", "임꺽정", "장길산", "일지매" };

            ViewName(names);
        }

        static void ViewName(string[] names)
        {
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("{0}번째 이름 {1}", i + 1, names[i]);
            }
        }
    }
}
