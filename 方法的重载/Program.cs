using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的重载
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum("ss", "6"));
            Console.ReadKey();
        }
        public static int GetSum(int n1, int n2)
        {
            return n1 + n2;
        }
        public static double GetSum(double n1, double n2)
        {
            return n1 + n2;
        }
        public static string GetSum(string str1,string str2)
        {
            return str1 + str2;
        }
    }
}
