using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "abcdefg";
            //char[] chs = s.ToCharArray();
            //chs[0] = 'b';
            //s = new string(chs);
            //Console.WriteLine(s);
            //Console.ReadKey();

            //StringBuilder sb = new StringBuilder();
            //string str = null;
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < 100000; i++)
            //{
            //    sb.Append(i);
            //}
            //sw.Stop();
            //Console.WriteLine(sb.ToString());
            //Console.WriteLine(sw.Elapsed);
            //Console.Read();

            //string s1 = Console.ReadLine();
            //string s2 = Console.ReadLine();
            //if (s1.Equals(s2, StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("2次输入的字符串相等");
            //}
            //else
            //{
            //    Console.WriteLine("2次输入的字符串不相等");
            //}
            //Console.ReadKey();

            //让用户输入一个日期2008-3-24，转化为2008年3月24日
            string s = "2008-3-24";
            string[] date = s.Split(new char[]{'-'}, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(s.Substring(0, 3));
            Console.WriteLine("{0}年{1}月{2}日", date[0], date[1], date[2]);
            Console.ReadKey();
        }
    }
}
