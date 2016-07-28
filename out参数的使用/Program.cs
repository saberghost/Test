using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out参数的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string psd = Console.ReadLine();
            string result;
            bool longin = Login(name, psd, out result);
            Console.WriteLine("{0},{1}", longin, result);
            Console.ReadLine();

        }
        public static bool Login(string name, string psd, out string result)
        {
            if (name == "Admin" && psd == "000000")
            {
                result = "登录成功";
                return true;
            }
            else if (name != "Admin" && psd == "000000")
            {
                result = "用户名错误";
                return false;
            }
            else if (name == "Admin" && psd != "000000")
            {
                result = "密码错误";
                return false;
            }
            else
            {
                result = "用户名,密码错误";
                return false;
            }
        }
    }
}