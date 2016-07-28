using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的姓名");
            string strName = Console.ReadLine();
            Console.WriteLine("语文成绩");
            double strChinese = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("数学成绩");
            double strMath = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("英语成绩");
            double strEnglish = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}你的总成绩是{1},平均成绩是{2:0.00}", strName, strChinese+strMath+strEnglish,(strChinese+strMath+strEnglish)/3);
            Console.ReadKey();
        }
    }
}