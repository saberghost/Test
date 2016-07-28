using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 属性
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ZhangSan = new Person("张三", 118, '猪');
            ZhangSan.Info();
            Console.ReadKey();
        }
    }
}
