using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习97
{
    class Program
    {
        static void Main(string[] args)
        {
            //请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转
            string[] str = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            for (int i = 0; i < str.Length/2; i++)
            {
                string temp = null;
                temp = str[i];
                str[i] = str[str.Length - i-1];
                str[str.Length - i-1] = temp;
            }
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.ReadKey();
        }
    }
}
