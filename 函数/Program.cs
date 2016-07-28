using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数
{
    class Program
    {
        public static int b = 5;
        static void Main(string[] args)
        {
            //string n1 = Console.ReadLine();
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Input(n1, n2);
            int a = 3;
            Console.WriteLine(AddA(a));
            Console.WriteLine(AddB());
            Console.ReadKey();

        }
        public static void Input(string n1, int n2)
        {
            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }
        public static int AddA(int number)
        {
            number += 5;
            return number;
        }
        public static int AddB()
        {
            b += 9;
            return b;
        }
    }
}
