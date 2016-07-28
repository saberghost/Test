using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher tea = new Teacher("张三", '男', 32, 12);
            tea.TeacherSayHello();
            Console.ReadKey();
        }
    }
}
