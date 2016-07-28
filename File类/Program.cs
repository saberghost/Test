using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File类
{
    class Program
    {
        static void Main(string[] args)
        {
            File.SetCreationTime(@"E:\book.txt", DateTime.Now);
            File.WriteAllLines(@"E:\new.doc", new string[] { "wo", "ai", "ni" }, Encoding.Default);
            string[] newText=File.ReadAllLines(@"E:\new.doc", Encoding.Default);
            foreach (var item in newText)
            {
                Console.WriteLine(item);
            }
            byte[] bt= File.ReadAllBytes(@"E:\book.txt");
            File.WriteAllBytes(@"E:\bok.txt", bt);
            //File.Copy(@"E:\new.txt", @"E:\new2.txt");
            Console.ReadKey();
        }
    }
}
