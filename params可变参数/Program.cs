using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace params可变参数
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = GetSum(3, 4, 2, 5, 3, 4);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        public static int GetSum(params int[] num)
        {
            int sum=0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            return sum;
        }
    }
}
