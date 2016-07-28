using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合的3个练习
{
    /// <summary>
    /// 将一个数组中的奇数放到一个集合中，再将偶数放到另一个集合中，最终将两个集合合并为一个集合，并且奇数显示在左边，偶数显示在右边
    /// </summary>
    public static class Practice
    {
        public static void Practice1()
        {
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    list2.Add(num[i]);
                }
                else
                {
                    list1.Add(num[i]);
                }
            }
            List<int> list3 = new List<int>();
            list3.AddRange(list1);
            list3.AddRange(list2);
            foreach (int item in list3)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 提示用户输入一个字符串，通过foreach循环将用户输入的字符串复制给一个字符数组
        /// </summary>
        public static void Practice2()
        {
            Console.WriteLine("请输入字符串");
            string str = Console.ReadLine();
            //List<char> listCh = new List<char>();
            //foreach (char item in str)
            //{
            //    listCh.Add(item);
            //}
            //char[] ch = listCh.ToArray();
            char[] ch = new char[str.Length];
            int i = 0;
            foreach (var item in str)
            {
                ch[i] = item;
                i++;
            }
            foreach (char item in ch)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 统计welcome to china中每个字符出现的次数，不考虑大小写
        /// </summary>
        public static void Practice3()
        {
            string str = "welcome to china";
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]==' ')
                {
                    continue;
                }
                if(!dic.ContainsKey(str[i]))
                {
                    dic.Add(str[i], 1);
                }
                else
                {
                    dic[str[i]]++;
                }
            }
            //dic.Remove(' ');
            foreach (KeyValuePair<char,int> kv in dic)
            {
                Console.WriteLine("字母{0}出现了{1}次", kv.Key, kv.Value);
            }
            Console.ReadKey();

        }
    }
}
