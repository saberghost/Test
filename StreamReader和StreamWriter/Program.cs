using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReader和StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"E:\book.txt", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            Console.ReadKey();

            //using(StreamWriter sw=new StreamWriter(@"E:\123.txt",true))
            //{
            //    sw.Write("fuck you");
            //}
        }
    }
}
