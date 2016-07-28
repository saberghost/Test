using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path类
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\book.txt";
            Console.WriteLine("文件名：{0}", Path.GetFileName(path));
            Console.WriteLine("文件路径：{0}", Path.GetFullPath(path));
            Console.WriteLine("文件夹名称：{0}", Path.GetDirectoryName(path));
            Console.WriteLine("拼接文件路径{0}", Path.Combine(@"E:\facebook\", "book.txt"));
            Console.ReadKey();
        }
    }
}
