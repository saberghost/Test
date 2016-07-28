using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法79
{
    class Program
    {
        static void Main(string[] args)
        {
            //用方法来实现：有一个字符串数组：{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出最长的字符串。
            string maxStr = MaxArray("马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特");
            Console.WriteLine(maxStr);
            Console.ReadKey();
        }
        public static string MaxArray(params string[] str)
        {
            string maxStr = str[0];
            for (int i = 0; i < str.Length; i++)
            {
                if(maxStr.Length<str[i].Length)
                {
                    maxStr = str[i];
                }
            }
            return maxStr;
        }
    }
}
