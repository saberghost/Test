using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "老王", "老赵", "老杨", "老李" };
            for (int i = 0; i < names.Length; i++)
            {
                int j = 0;
                j = names.Length - i - 1;
                Console.Write(names[j] + "|");
            }
            Console.ReadKey();
        }
    }
}
