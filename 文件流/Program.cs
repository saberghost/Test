using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fsRead = new FileStream(@"E:\book.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //byte[] buffer = new byte[1024 * 1024 * 5];
            //int r = fsRead.Read(buffer, 0, buffer.Length);
            //string s = Encoding.Default.GetString(buffer, 0, r);
            ////关闭文件流
            //fsRead.Close();
            ////释放所占资源
            //fsRead.Dispose();
            //Console.WriteLine(s);
            //Console.ReadKey();

            using(FileStream fsWrite =new FileStream(@"E:\new.txt",FileMode.OpenOrCreate,FileAccess.Write))
            {
                string str="骨精";
                byte[] bufffer=Encoding.Default.GetBytes(str);
                fsWrite.Write(bufffer, 0, bufffer.Length);
            }
        }
    }
}
