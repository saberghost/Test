using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自己动手写TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int numTwo;
            bool b = int.TryParse("123d", out num);
            bool c = MyTryParse("222", out numTwo);
            Console.WriteLine("{0},{1}", b, num);
            Console.WriteLine("{0},{1}", c, numTwo);
            Console.ReadKey();
        }
        public static bool MyTryParse(string str, out int num)
        {
            try
            {
                num = Convert.ToInt32(str);
                return true;
            }
            catch
            {
                num = 0;
                return false;
            }
        }
    }
}
