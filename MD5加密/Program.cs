using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMD5("123"));
            Console.ReadKey();
        }
        public static string GetMD5(string pwd)
        {
            MD5 md5 = MD5.Create();
            byte[] buffer = Encoding.Default.GetBytes(pwd);
            byte[] MD5Buffer = md5.ComputeHash(buffer);
            //return Encoding.Default.GetString(MD5Buffer);
            string str = null;
            for (int i = 0; i < MD5Buffer.Length; i++)
            {
                str += MD5Buffer[i].ToString("x2");
            }
            return str;
        }
    }
}
