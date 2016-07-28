using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环的3个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //int num = 0;
            //int i=0;
            //for (; i < 5; i++)
            //{
            //    num = int.Parse(Console.ReadLine());
            //    if(num<0||num>100)
            //    {
            //        i--;
            //        continue;
            //    }
            //    sum += num;
            //}
            //Console.WriteLine("{0}/{1}={2}", sum, i, sum / i);
            //Console.ReadKey();
            string name = "";
            string password = "";
            while (true)
            {
                name = Console.ReadLine();
                password = Console.ReadLine();
                if (name == "admin" && password == "888888")
                {
                    break;
                }
            }
        }
    }
}
