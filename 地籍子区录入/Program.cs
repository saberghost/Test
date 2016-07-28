using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 地籍子区录入
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strRead= File.ReadAllLines(@"E:\djzq.txt", Encoding.Default);
            int z = 0;
            for (int i = 0; i < strRead.Length; i++)
            {
                string[] strSp= strRead[i].Split('\t');
                string[] strsp2 = strSp[2].Split('、');
                for (int j = 0; j < strsp2.Length; j++)
                {
                    string str1 = string.Join("",new string[]{strSp[0],strSp[1],strsp2[j]});
                    string str2="地籍子区"+Convert.ToInt32(strsp2[j]);
                    string str3 = str1 + " " + str2;
                    //Console.WriteLine(str3);
                    File.AppendAllText(@"E:\new.txt", str3+"\r\n");
                }
                //Console.WriteLine(strSp[0]);
            }
            Console.ReadKey();
        }
    }
}
