using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 比较三个数大小
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第三个数");
            int numTree = Convert.ToInt32(Console.ReadLine());
            if (numOne > numTwo && numOne > numTree)
            {
                if (numTwo > numTree)
                    Console.WriteLine("{0}>{1}>{2}", numOne, numTwo, numTree);
                else
                    Console.WriteLine("{0}>{1}>{2}", numOne, numTree, numTwo);
            }
            else if (numTwo > numOne && numTwo > numTree)
            {
                if (numOne > numTree)
                    Console.WriteLine("{0}>{1}>{2}", numTwo, numOne, numTree);
                else
                    Console.WriteLine("{0}>{1}>{2}", numTwo, numTree, numOne);
            }
            else if (numTree > numOne && numTree > numTwo)
            {
                if (numOne > numTwo)
                    Console.WriteLine("{0}>{1}>{2}", numTree, numOne, numTwo);
                else
                    Console.WriteLine("{0}>{1}>{2}", numTree, numTwo, numOne);
            }
            Console.ReadKey();

        }
    }
}
