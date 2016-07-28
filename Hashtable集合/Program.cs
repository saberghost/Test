using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, 3.133);
            ht.Add(3, '男');
            ht[false] = "错误的";
            ht.Remove(2);
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("{0},{1}", item, ht[item]);
            }
            Console.ReadKey();
        }
    }
}
