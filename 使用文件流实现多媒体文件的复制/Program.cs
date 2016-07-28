using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用文件流实现多媒体文件的复制
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"E:\[DMG][Bakuman2][01][AVC_AAC][720P].mp4";
            string target = @"E:\new.mp4";
            CopyFile(source, target);
            Console.WriteLine("复制成功");
            Console.ReadKey();
        }
        public static void CopyFile(string source, string target)
        {
            using (FileStream fsRead = new FileStream(source, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    while (true)
                    {
                        int s = fsRead.Read(buffer, 0, buffer.Length);
                        if (s == 0)
                        {
                            break;
                        }
                        fsWrite.Write(buffer, 0, s);
                    }
                }
            }
        }
    }
}
