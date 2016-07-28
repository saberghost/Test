using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 求100以内的质数
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                bool b = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
            //string name = Console.ReadLine();
            //string result = name == "杨威" ? "帅哥" : "bitch";
            //Console.WriteLine(result);
            //Console.ReadKey();

        }
    }
}
