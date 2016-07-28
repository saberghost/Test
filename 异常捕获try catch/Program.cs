using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 异常捕获try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 0;
            //try
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(num * 2);
            //}
            //catch
            //{
            //    Console.WriteLine("你输入的不是数字！");
            //}
            //Console.ReadKey();
            int num = 0;
            bool p = true;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("你输入的不是数字！");
                p = false;
            }
            if (p)
            {
                Console.WriteLine(num * 2);
            }
            Console.ReadKey();
        }
    }
}
