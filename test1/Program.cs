using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请问你的名字是？");
            string name = Console.ReadLine();
            Console.WriteLine("请问你的年龄是？");
            string age = Console.ReadLine();
            Console.WriteLine("请问你的性别是？");
            string sex = Console.ReadLine();
            string chr = string.Format("你的名字是{0}\r\n你的年龄是{1}\r\n你的性别是{2}",name,age,sex);
            Console.WriteLine("DON");
            Console.ReadKey();


        }
    }
}
