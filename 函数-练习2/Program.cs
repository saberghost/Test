using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数_练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个字符");
            string str1 = Console.ReadLine();
            OnlyYorN(str1);
            Console.ReadKey();
        }
        public static void OnlyYorN(string s)
        {
            while(true)
            {
                if(s=="Y"||s=="N")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("你输入的不是Y或N");
                    s = Console.ReadLine();
                }
            }

        }
    }
}
