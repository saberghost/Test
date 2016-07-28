using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串练习
{
    public class Class1
    {
        /// <summary>
        /// 接收用户输入的字符串，将其中的字符以与输入相反的顺序输出。"abc"→"cba"
        /// </summary>
        public static void Practice1()
        {
            string str = Console.ReadLine();
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(str[i]);
            //}
            char[] chs = str.ToCharArray();
            for (int i = 0; i < chs.Length/2; i++)
            {
                char temp = str[i];
                chs[i] = str[str.Length-1-i];
                chs[str.Length - 1 - i] = temp;
            }
            str = new string(chs);
            Console.WriteLine(str);
            Console.ReadKey();
        }
        /// <summary>
        /// 接收用户输入的一句英文，将其中的单词以反序输出。"hello c sharp"→"sharp c hello"
        /// </summary>
        public static void Practice2()
        {
            string str = "hello c sharp";
            string[] temp = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = temp.Length - 2; i >= 0; i--)
            {
                Console.Write(temp[i] + ' ');
            }
            Console.Write(temp[temp.Length - 1]);
            Console.ReadKey();
        }
        /// <summary>
        /// 从Email中提取出用户名和域名：abc@163.com
        /// </summary>
        public static void Practice3()
        {
            string Email = "abc@163.com";
            int index = Email.IndexOf('@');
            string usename = Email.Substring(0, index);
            string linename = Email.Substring(index + 1);
            Console.WriteLine("用户名：{0}", usename);
            Console.WriteLine("域名：{0}", linename);
            Console.ReadKey();
        }
        /// <summary>
        /// 文本文件中存储了多个文章标题、作者，标题和作者之间用若干空格（数量不定）隔开，每行一个，标题有的长有的短，输出到控制台的时候最多标题长度10，如果超过10，则截取长度8的子串并且最后添加“...”，加一个竖线后输出作者的名字。
        /// </summary>
        public static void Practice4()
        {
            string path = @"E:\book.txt";
            string[] contents = File.ReadAllLines(path, Encoding.Default);
            for (int i = 0; i < contents.Length; i++)
            {
                string[] temp = contents[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (temp[0].Length > 10)
                {
                    temp[0] = temp[0].Substring(0, 8) + "...";
                }
                string outline = string.Join("|", temp);
                Console.WriteLine(outline);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 让用户输入一句话,找出所有e的位置
        /// </summary>
        public static void Practice5()
        {
            string str = "my name is eli,eli is a elldge";
            int index = 0;
            while (index != -1)
            {
                index = str.IndexOf('e', index);
                if (index == -1)
                {
                    break;
                }
                Console.WriteLine(index);
                index = index + 1;
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 让用户输入一句话,判断这句话中有没有邪恶,如果有邪恶就替换成这种形式然后输出,如:老牛很邪恶,输出后变成老牛很**;
        /// </summary>
        public static void Practice6()
        {
            string str = "老牛很邪恶";
            if (str.Contains("邪恶"))
            {
                str = str.Replace("邪恶", "**");
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
        /// <summary>
        /// 把{“诸葛亮”,”鸟叔”,”卡卡西”,”卡哇伊”}变成诸葛亮|鸟叔|卡卡西|卡哇伊,然后再把|切割掉
        /// </summary>
        public static void Practice7()
        {
            string[] str = {"诸葛亮", "鸟叔", "卡卡西", "卡哇伊"};
            string temp= string.Join("|", str);
            Console.WriteLine(temp);
            string[] tempAraay =temp.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            temp = string.Join("", tempAraay);
            Console.WriteLine(temp);
            Console.ReadKey();
        }
    }
}
