using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] names = new string[3] { "张三", "李四", "王五" };
                Random r = new Random();
                int n = r.Next(0, names.Length);
                Console.WriteLine(names[n]);
                Console.ReadKey();
            }
        }
    }
}
