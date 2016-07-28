using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //交换2个数的值
            int n1 = 10;
            int n2 = 20;
            ExchangeNum(ref n1,ref n2);
            Console.WriteLine(n1+","+n2);
            Console.ReadKey();
        }
        public static void ExchangeNum(ref int n1,ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
